import { Injectable, OnInit } from '@angular/core';
import { OidcSecurityValidationService } from '../Services/oidc-security-validation.service';
import { AuthConfigurationService } from '../Services/auth-configuration.service';
import { JwtKeys } from '../CommonConstants/jwt-keys';
import { Observable, Subject } from 'rxjs/Rx';
import { Http, Headers, Response } from '@angular/http';
import { Router } from '@angular/router';

import { TokenService } from '../Services/token.service';

@Injectable()
export class OidcSecurityService {

    public headers: Headers;
    public _isAuthorized: boolean;
    private oidcSecurityValidation: OidcSecurityValidationService;
    private jwtKeys: JwtKeys;
    private errorMessage: string;
    private storage: any;
    public UserData: any;
    private _tokenService: TokenService;
    private _returnUrl: string;

    constructor(private _http: Http, private _configuration: AuthConfigurationService, private _router: Router) {
        this.oidcSecurityValidation = new OidcSecurityValidationService();
        this.headers = new Headers();
        this.headers.append('Content-Type', 'application/json');
        this.headers.append('Accept', 'application/json');
        this.storage = localStorage;
        this._tokenService = new TokenService();


        if (this.retrieve('_isAuthorize') !== '') {
            this._isAuthorized = this.retrieve('_isAuthorized');
        }


    }

    public IsAuthorized(): boolean {
        if (this._isAuthorized) {
            if (this.oidcSecurityValidation.IsTokenExpired(this.retrieve('authorizationDataIdToken'))) {
                this.ResetAuthorizationData();
                return false;
            }
            return true
        }
        return false;
    }

    public AuthorizedCallback() {

        this.ResetAuthorizationData();
        let hash = window.location.hash.substr(1);
        
        let result: any = hash.split('&').reduce(function (result: any, item: string) {
            let parts = item.split('=');
            result[parts[0]] = parts[1];
            return result;
        }, {});

        let token = '';
        let id_token = '';
        let authResponseIsValid = false;

        this.getSigningKeys().subscribe(jwtkeys => {
            this.jwtKeys = jwtkeys;

            if (!result.error) {
                // validate state
                if (this.oidcSecurityValidation.ValidateStateFromHashCallback(result.state, this.retrieve('authStateControl'))) {
                    token = result.access_token;
                    id_token = result.id_token;
                    let decoded: any;
                    let headerDecoded;
                    decoded = this.oidcSecurityValidation.GetPayloadFromToken(id_token, false);
                    headerDecoded = this.oidcSecurityValidation.GetHeaderFromToken(id_token, false);

                    // validate jwt signature
                    if (this.oidcSecurityValidation.Validate_signature_id_token(id_token, this.jwtKeys)) {
                        // validate nonce
                        if (this.oidcSecurityValidation.Validate_id_token_nonce(decoded, this.retrieve('authNonce'))) {
                            // validate iss
                            if (this.oidcSecurityValidation.Validate_id_token_iss(decoded, this._configuration.iss)) {
                                // validate aud
                                if (this.oidcSecurityValidation.Validate_id_token_aud(decoded, this._configuration.client_id)) {
                                    // valiadate at_hash and access_token
                                    if (this.oidcSecurityValidation.Validate_id_token_at_hash(token, decoded.at_hash) || !token) {
                                        this.store('authNonce', '');
                                        this.store('authStateControl', '');

                                        authResponseIsValid = true;

                                    } else {
                                        console.log('AuthorizedCallback incorrect aud');
                                    }
                                } else {
                                    console.log('AuthorizedCallback incorrect aud');
                                }
                            } else {
                                console.log('AuthorizedCallback incorrect iss');
                            }
                        } else {
                            console.log('AuthorizedCallback incorrect nonce');
                        }
                    } else {
                        console.log('AuthorizedCallback incorrect Signature id_token');
                    }
                } else {
                    console.log('AuthorizedCallback incorrect state');
                }

            }

            if (authResponseIsValid) {
                this.SetAuthorizationData(token, id_token);

                // router navigate to Users
                this._returnUrl = this._tokenService.retrieveItem("redirectUrl");
                console.log("Local Storage Variabl", localStorage.getItem("redirectUrl"))
                console.log("This URL from oidc security: ", this._returnUrl);
                if (this._returnUrl !== null)
                {
                    this._router.navigateByUrl(this._returnUrl);
                } else
                {
                    this._router.navigate(['admin/home/dashboard']);
                }
                
            } else {
                this.ResetAuthorizationData();
                //this._router.navigate(['/Unauthorize']);
            }
        });
    }

    public Logoff() {
        // /connect/endsession?id_token_hint=...&post_logout_redirect_uri=https://myapp.com

        let authorizationEndsessionUrl = this._configuration.logoutEndSession_url;

        let id_token_hint = this.retrieve('authorizationDataIdToken');
        let post_logout_redirect_uri = this._configuration.post_logout_redirect_uri;

        let url =
            authorizationEndsessionUrl + '?' +
            'id_token_hint=' + encodeURI(id_token_hint) + '&' +
            'post_logout_redirect_uri=' + encodeURI(post_logout_redirect_uri);
        this.store('_isAuthorized', false);
        this.ResetAuthorizationData();
        this._tokenService.removeItem("redirectUrl"); // Added By Kyam

        window.location.href = url;
        //window.open(url,"_blank")
    }
    private getSigningKeys(): Observable<JwtKeys> {
        return this._http.get(this._configuration.jwks_url)
            .map(this.extractData)
            .catch(this.handleError);
    }
    private runGetSigningKeys() {
        this.getSigningKeys()
            .subscribe(
            jwtKeys => this.jwtKeys = jwtKeys,
            error => this.errorMessage = <any>error);
    }
    private extractData(res: Response) {
        let body = res.json();
        return body;
    }
    private handleError(error: Response | any) {
        // In a real world app, you might use a remote logging infrastructure
        let errMsg: string;
        if (error instanceof Response) {
            const body = error.json() || '';
            const err = body.error || JSON.stringify(body);
            errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
        } else {
            errMsg = error.message ? error.message : error.toString();
        }
        console.error(errMsg);
        return Observable.throw(errMsg);
    }
    public ResetAuthorizationData() {
        this.store('authorizationData', '');
        this.store('authorizationDataIdToken', '')
        this._isAuthorized = false;
        
        
    }
    public SetAuthorizationData(token: any, id_token: any) {
        if (this.retrieve('authorizationData') !== '') {
            this.store('authorizationData', '');
        }
        this.store('authorizationData', token);
        this.store('authorizationDataIdToken', id_token);
        this._isAuthorized = true;
        this.store('_isAuthorized', true);



    }
    public Authorize() {
        this.ResetAuthorizationData();
        console.log('BEGIN Authorize, no auth data');
        let authorizationUrl = this._configuration.server + '/connect/authorize';
        let client_id = this._configuration.client_id;
        let redirect_uri = this._configuration.redirect_url;
        let response_type = this._configuration.response_type;
        let scope = this._configuration.scope;
        let nonce = 'N' + Math.random() + '' + Date.now();
        let state = Date.now() + '' + Math.random();

        this.store('authStateControl', state);
        this.store('authNonce', nonce);
        console.log('AuthorizedController created. adding myautostate: ' + this.retrieve('authStateControl'));

        let url = authorizationUrl + '?' +
            'response_type=' + encodeURI(response_type) + '&' +
            'client_id=' + encodeURI(client_id) + '&' +
            'redirect_uri=' + encodeURI(redirect_uri) + '&' +
            'scope=' + encodeURI(scope) + '&' +
            'nonce=' + encodeURI(nonce) + '&' +
            'state=' + encodeURI(state);

        window.location.href = url;

    }
    private getUserData = (): Observable<string[]> => {
        this.setHeaders();
        return this._http.get(this._configuration.userinfo_url, {
            headers: this.headers,
            body: ''
        }).map(res => res.json());
    }
    public retrieve(key: string): any {

        var item = this.storage.getItem(key);

        if (item && item !== 'undefined') {
            return JSON.parse(this.storage.getItem(key));
        }

        return;
    }
    private store(key: string, value: any) {
        this.storage.setItem(key, JSON.stringify(value));
    }
    private GetToken() {
        return this.retrieve('authorizationData');
    }
    private setHeaders() {
        this.headers = new Headers();
        this.headers.append('Content-type', 'application/json');
        this.headers.append('Accept', 'application/json');

        var token = this.GetToken();
        if (token !== "") {
            this.headers.append('Authorization', 'Bearer ' + token);
        }
    }


}
