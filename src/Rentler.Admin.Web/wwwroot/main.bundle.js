webpackJsonp([3],{

/***/ "../../../../../src async recursive":
/***/ (function(module, exports, __webpack_require__) {

var map = {
	"../app/app-sidenav/app-sidenav.module": [
		"../../../../../src/app/app-sidenav/app-sidenav.module.ts",
		1
	],
	"../component-viewer/component-viewer.module": [
		"../../../../../src/app/component-viewer/component-viewer.module.ts",
		0
	]
};
function webpackAsyncContext(req) {
	var ids = map[req];
	if(!ids)
		return Promise.reject(new Error("Cannot find module '" + req + "'."));
	return __webpack_require__.e(ids[1]).then(function() {
		return __webpack_require__(ids[0]);
	});
};
webpackAsyncContext.keys = function webpackAsyncContextKeys() {
	return Object.keys(map);
};
module.exports = webpackAsyncContext;
webpackAsyncContext.id = "../../../../../src async recursive";

/***/ }),

/***/ "../../../../../src/app/CommonConstants/toasttheme-configuration.constant.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ToastthemeConfiguration; });
var ToastthemeConfiguration = (function () {
    function ToastthemeConfiguration() {
        this.default = 'default';
        this.material = 'material';
        this.bootstrap = 'bootstrap';
    }
    return ToastthemeConfiguration;
}());

//# sourceMappingURL=toasttheme-configuration.constant.js.map

/***/ }),

/***/ "../../../../../src/app/CommonConstants/toasttype-configuration.constant.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ToasttypeConfiguration; });
var ToasttypeConfiguration = (function () {
    function ToasttypeConfiguration() {
        this.info = "info";
        this.success = "success";
        this.wait = "wait";
        this.error = "error";
        this.warning = "warning";
    }
    return ToasttypeConfiguration;
}());

//# sourceMappingURL=toasttype-configuration.constant.js.map

/***/ }),

/***/ "../../../../../src/app/Services/auth-configuration.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AuthConfigurationService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};

var AuthConfigurationService = (function () {
    function AuthConfigurationService() {
        // The Issuer Identifier for the OpenID Provider (which is typically obtained during Discovery) MUST exactly match the value of the iss (issuer) Claim.
        this.iss = 'http://localhost:5000';
        this.server = 'http://localhost:5000';
        this.redirect_url = 'http://localhost:4200';
        // This is required to get the signing keys so that the signiture of the Jwt can be validated.
        this.jwks_url = 'http://localhost:5000/.well-known/openid-configuration/jwks';
        this.userinfo_url = 'http://localhost:5000/connect/userinfo';
        // The Client MUST validate that the aud (audience) Claim contains its client_id value registered at the Issuer identified by the iss (issuer) Claim as an audience.
        // The ID Token MUST be rejected if the ID Token does not list the Client as a valid audience, or if it contains additional audiences not trusted by the Client.
        this.client_id = 'Rentler.Admin.ID';
        this.response_type = 'id_token token';
        this.scope = 'openid profile admin.rentler.com-core.api';
        this.post_logout_redirect_uri = 'http://localhost:4200/login';
        this.logoutEndSession_url = 'http://localhost:5000/connect/endsession';
    }
    return AuthConfigurationService;
}());
AuthConfigurationService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])()
], AuthConfigurationService);

//# sourceMappingURL=auth-configuration.service.js.map

/***/ }),

/***/ "../../../../../src/app/Services/http.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_Observable__ = __webpack_require__("../../../../rxjs/Observable.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_Observable___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_1_rxjs_Observable__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_Rx__ = __webpack_require__("../../../../rxjs/Rx.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_Rx___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_2_rxjs_Rx__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__angular_http__ = __webpack_require__("../../../http/@angular/http.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__Services_progressbar_service__ = __webpack_require__("../../../../../src/app/Services/progressbar.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__options_angular_redux_request_options__ = __webpack_require__("../../../../../src/app/options/angular-redux-request.options.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return HttpService; });
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};






var HttpService = (function (_super) {
    __extends(HttpService, _super);
    function HttpService(backend, defaultOptions, loaderService) {
        var _this = _super.call(this, backend, defaultOptions) || this;
        _this.loaderService = loaderService;
        _this.apiUrl = "/api/";
        return _this;
    }
    HttpService.prototype.get = function (url, options) {
        var _this = this;
        this.showLoader();
        return _super.prototype.get.call(this, this.getFullUrl(url), this.requestOptions(options))
            .catch(this.onCatch)
            .do(function (res) {
            _this.onSuccess(res);
        }, function (error) {
            _this.onError(error);
        })
            .finally(function () {
            _this.onEnd();
        });
    };
    HttpService.prototype.requestOptions = function (options) {
        if (options == null) {
            options = new __WEBPACK_IMPORTED_MODULE_5__options_angular_redux_request_options__["a" /* AngularReduxRequest */]();
        }
        if (options.headers == null) {
            options.headers = new __WEBPACK_IMPORTED_MODULE_3__angular_http__["Headers"]();
        }
        return options;
    };
    HttpService.prototype.getFullUrl = function (url) {
        return this.apiUrl + url;
    };
    HttpService.prototype.onCatch = function (error, caught) {
        return __WEBPACK_IMPORTED_MODULE_1_rxjs_Observable__["Observable"].throw(error);
    };
    HttpService.prototype.onSuccess = function (res) {
        console.log('Request successful');
    };
    HttpService.prototype.onError = function (res) {
        console.log('Error, status code: ' + res.status);
    };
    HttpService.prototype.onEnd = function () {
        this.hideLoader();
    };
    HttpService.prototype.showLoader = function () {
        this.loaderService.show();
    };
    HttpService.prototype.hideLoader = function () {
        this.loaderService.hide();
    };
    return HttpService;
}(__WEBPACK_IMPORTED_MODULE_3__angular_http__["Http"]));
HttpService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_3__angular_http__["XHRBackend"] !== "undefined" && __WEBPACK_IMPORTED_MODULE_3__angular_http__["XHRBackend"]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_5__options_angular_redux_request_options__["a" /* AngularReduxRequest */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_5__options_angular_redux_request_options__["a" /* AngularReduxRequest */]) === "function" && _b || Object, typeof (_c = typeof __WEBPACK_IMPORTED_MODULE_4__Services_progressbar_service__["a" /* ProgressbarService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_4__Services_progressbar_service__["a" /* ProgressbarService */]) === "function" && _c || Object])
], HttpService);

var _a, _b, _c;
//# sourceMappingURL=http.service.js.map

/***/ }),

/***/ "../../../../../src/app/Services/oidc-security-validation.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return OidcSecurityValidationService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};

// http://openid.net/specs/openid-connect-implicit-1_0.html
// id_token
//// id_token C1: The Issuer Identifier for the OpenID Provider (which is typically obtained during Discovery) MUST exactly match the value of the iss (issuer) Claim.
//// id_token C2: The Client MUST validate that the aud (audience) Claim contains its client_id value registered at the Issuer identified by the iss (issuer) Claim as an audience.The ID Token MUST be rejected if the ID Token does not list the Client as a valid audience, or if it contains additional audiences not trusted by the Client.
// id_token C3: If the ID Token contains multiple audiences, the Client SHOULD verify that an azp Claim is present.
// id_token C4: If an azp (authorized party) Claim is present, the Client SHOULD verify that its client_id is the Claim Value.
//// id_token C5: The Client MUST validate the signature of the ID Token according to JWS [JWS] using the algorithm specified in the alg Header Parameter of the JOSE Header. The Client MUST use the keys provided by the Issuer.
//// id_token C6: The alg value SHOULD be RS256. Validation of tokens using other signing algorithms is described in the OpenID Connect Core 1.0 [OpenID.Core] specification.
//// id_token C7: The current time MUST be before the time represented by the exp Claim (possibly allowing for some small leeway to account for clock skew).
// id_token C8: The iat Claim can be used to reject tokens that were issued too far away from the current time, limiting the amount of time that nonces need to be stored to prevent attacks.The acceptable range is Client specific.
//// id_token C9: The value of the nonce Claim MUST be checked to verify that it is the same value as the one that was sent in the Authentication Request.The Client SHOULD check the nonce value for replay attacks.The precise method for detecting replay attacks is Client specific.
// id_token C10: If the acr Claim was requested, the Client SHOULD check that the asserted Claim Value is appropriate.The meaning and processing of acr Claim Values is out of scope for this document.
// id_token C11: When a max_age request is made, the Client SHOULD check the auth_time Claim value and request re- authentication if it determines too much time has elapsed since the last End- User authentication.
//// Access Token Validation
//// access_token C1: Hash the octets of the ASCII representation of the access_token with the hash algorithm specified in JWA[JWA] for the alg Header Parameter of the ID Token's JOSE Header. For instance, if the alg is RS256, the hash algorithm used is SHA-256.
//// access_token C2: Take the left- most half of the hash and base64url- encode it.
//// access_token C3: The value of at_hash in the ID Token MUST match the value produced in the previous step if at_hash is present in the ID Token.
var OidcSecurityValidationService = (function () {
    function OidcSecurityValidationService() {
    }
    // id_token C7: The current time MUST be before the time represented by the exp Claim (possibly allowing for some small leeway to account for clock skew).
    OidcSecurityValidationService.prototype.IsTokenExpired = function (token, offsetSeconds) {
        var decoded;
        decoded = this.GetPayloadFromToken(token, false);
        var tokenExpirationDate = this.getTokenExpirationDate(decoded);
        offsetSeconds = offsetSeconds || 0;
        if (tokenExpirationDate == null) {
            return false;
        }
        // Token expired?
        return !(tokenExpirationDate.valueOf() > (new Date().valueOf() + (offsetSeconds * 1000)));
    };
    // id_token C9: The value of the nonce Claim MUST be checked to verify that it is the same value as the one that was sent in the Authentication Request.The Client SHOULD check the nonce value for replay attacks.The precise method for detecting replay attacks is Client specific.
    OidcSecurityValidationService.prototype.Validate_id_token_nonce = function (dataIdToken, local_nonce) {
        if (dataIdToken.nonce !== local_nonce) {
            console.log('Validate_id_token_nonce failed');
            return false;
        }
        return true;
    };
    // id_token C1: The Issuer Identifier for the OpenID Provider (which is typically obtained during Discovery) MUST exactly match the value of the iss (issuer) Claim.
    OidcSecurityValidationService.prototype.Validate_id_token_iss = function (dataIdToken, client_id) {
        if (dataIdToken.iss !== client_id) {
            console.log('Validate_id_token_iss failed');
            return false;
        }
        return true;
    };
    // id_token C2: The Client MUST validate that the aud (audience) Claim contains its client_id value registered at the Issuer identified by the iss (issuer) Claim as an audience.
    // The ID Token MUST be rejected if the ID Token does not list the Client as a valid audience, or if it contains additional audiences not trusted by the Client.
    OidcSecurityValidationService.prototype.Validate_id_token_aud = function (dataIdToken, aud) {
        if (dataIdToken.aud !== aud) {
            console.log('Validate_id_token_aud failed');
            return false;
        }
        return true;
    };
    OidcSecurityValidationService.prototype.ValidateStateFromHashCallback = function (state, local_state) {
        if (state !== local_state) {
            console.log('ValidateStateFromHashCallback failed');
            return false;
        }
        return true;
    };
    OidcSecurityValidationService.prototype.GetPayloadFromToken = function (token, encode) {
        var data = {};
        if (typeof token !== 'undefined') {
            var encoded = token.split('.')[1];
            if (encode) {
                return encoded;
            }
            var urlBase64Var = this.urlBase64Decode(encoded);
            if (urlBase64Var !== null) {
                data = JSON.parse(urlBase64Var);
            }
            else {
                data = {};
            }
        }
        return data;
    };
    OidcSecurityValidationService.prototype.GetHeaderFromToken = function (token, encode) {
        var data = {};
        if (typeof token !== 'undefined') {
            var encoded = token.split('.')[0];
            if (encode) {
                return encoded;
            }
            data = JSON.parse(this.urlBase64Decode(encoded));
        }
        return data;
    };
    OidcSecurityValidationService.prototype.GetSignatureFromToken = function (token, encode) {
        var data = {};
        if (typeof token !== 'undefined') {
            var encoded = token.split('.')[2];
            if (encode) {
                return encoded;
            }
            data = JSON.parse(this.urlBase64Decode(encoded));
        }
        return data;
    };
    // id_token C5: The Client MUST validate the signature of the ID Token according to JWS [JWS] using the algorithm specified in the alg Header Parameter of the JOSE Header. The Client MUST use the keys provided by the Issuer.
    // id_token C6: The alg value SHOULD be RS256. Validation of tokens using other signing algorithms is described in the OpenID Connect Core 1.0 [OpenID.Core] specification.
    OidcSecurityValidationService.prototype.Validate_signature_id_token = function (id_token, jwtkeys) {
        if (!jwtkeys || !jwtkeys.keys) {
            return false;
        }
        var header_data = this.GetHeaderFromToken(id_token, false);
        var kid = header_data.kid;
        var alg = header_data.alg;
        if ('RS256' != alg) {
            console.log('Only RS256 supported');
            return false;
        }
        var isValid = false;
        for (var _i = 0, _a = jwtkeys.keys; _i < _a.length; _i++) {
            var key = _a[_i];
            if (key.kid === kid) {
                console.log("KEYUTIL", key);
                var publickey = KEYUTIL.getKey(key);
                isValid = KJUR.jws.JWS.verify(id_token, publickey, ['RS256']);
                return isValid;
            }
        }
        return isValid;
    };
    // Access Token Validation
    // access_token C1: Hash the octets of the ASCII representation of the access_token with the hash algorithm specified in JWA[JWA] for the alg Header Parameter of the ID Token's JOSE Header. For instance, if the alg is RS256, the hash algorithm used is SHA-256.
    // access_token C2: Take the left- most half of the hash and base64url- encode it.
    // access_token C3: The value of at_hash in the ID Token MUST match the value produced in the previous step if at_hash is present in the ID Token.
    OidcSecurityValidationService.prototype.Validate_id_token_at_hash = function (access_token, at_hash) {
        var hash = KJUR.crypto.Util.hashString(access_token, 'sha256');
        var first128bits = hash.substr(0, hash.length / 2);
        var testdata = hextob64u(first128bits);
        if (testdata === at_hash) {
            return true; // isValid;
        }
        return false;
    };
    OidcSecurityValidationService.prototype.getTokenExpirationDate = function (dataIdToken) {
        if (!dataIdToken.hasOwnProperty('exp')) {
            return null;
        }
        var date = new Date(0); // The 0 here is the key, which sets the date to the epoch
        date.setUTCSeconds(dataIdToken.exp);
        return date;
    };
    OidcSecurityValidationService.prototype.urlBase64Decode = function (str) {
        var output;
        if (str !== undefined) {
            output = str.replace('-', '+').replace('_', '/');
            switch (output.length % 4) {
                case 0:
                    break;
                case 2:
                    output += '==';
                    break;
                case 3:
                    output += '=';
                    break;
                default:
                    throw 'Illegal base64url string!';
            }
        }
        else {
            return null;
        }
        return window.atob(output);
    };
    return OidcSecurityValidationService;
}());
OidcSecurityValidationService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])()
], OidcSecurityValidationService);

//# sourceMappingURL=oidc-security-validation.service.js.map

/***/ }),

/***/ "../../../../../src/app/Services/oidc-security.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__Services_oidc_security_validation_service__ = __webpack_require__("../../../../../src/app/Services/oidc-security-validation.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__Services_auth_configuration_service__ = __webpack_require__("../../../../../src/app/Services/auth-configuration.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3_rxjs_Rx__ = __webpack_require__("../../../../rxjs/Rx.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3_rxjs_Rx___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_3_rxjs_Rx__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__angular_http__ = __webpack_require__("../../../http/@angular/http.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__Services_token_service__ = __webpack_require__("../../../../../src/app/Services/token.service.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return OidcSecurityService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};







var OidcSecurityService = (function () {
    function OidcSecurityService(_http, _configuration, _router) {
        var _this = this;
        this._http = _http;
        this._configuration = _configuration;
        this._router = _router;
        this.getUserData = function () {
            _this.setHeaders();
            return _this._http.get(_this._configuration.userinfo_url, {
                headers: _this.headers,
                body: ''
            }).map(function (res) { return res.json(); });
        };
        this.oidcSecurityValidation = new __WEBPACK_IMPORTED_MODULE_1__Services_oidc_security_validation_service__["a" /* OidcSecurityValidationService */]();
        this.headers = new __WEBPACK_IMPORTED_MODULE_4__angular_http__["Headers"]();
        this.headers.append('Content-Type', 'application/json');
        this.headers.append('Accept', 'application/json');
        this.storage = localStorage;
        this._tokenService = new __WEBPACK_IMPORTED_MODULE_6__Services_token_service__["a" /* TokenService */]();
        if (this.retrieve('_isAuthorize') !== '') {
            this._isAuthorized = this.retrieve('_isAuthorized');
        }
    }
    OidcSecurityService.prototype.IsAuthorized = function () {
        if (this._isAuthorized) {
            if (this.oidcSecurityValidation.IsTokenExpired(this.retrieve('authorizationDataIdToken'))) {
                this.ResetAuthorizationData();
                return false;
            }
            return true;
        }
        return false;
    };
    OidcSecurityService.prototype.AuthorizedCallback = function () {
        var _this = this;
        this.ResetAuthorizationData();
        var hash = window.location.hash.substr(1);
        var result = hash.split('&').reduce(function (result, item) {
            var parts = item.split('=');
            result[parts[0]] = parts[1];
            return result;
        }, {});
        var token = '';
        var id_token = '';
        var authResponseIsValid = false;
        this.getSigningKeys().subscribe(function (jwtkeys) {
            _this.jwtKeys = jwtkeys;
            if (!result.error) {
                // validate state
                if (_this.oidcSecurityValidation.ValidateStateFromHashCallback(result.state, _this.retrieve('authStateControl'))) {
                    token = result.access_token;
                    id_token = result.id_token;
                    var decoded = void 0;
                    var headerDecoded = void 0;
                    decoded = _this.oidcSecurityValidation.GetPayloadFromToken(id_token, false);
                    headerDecoded = _this.oidcSecurityValidation.GetHeaderFromToken(id_token, false);
                    // validate jwt signature
                    if (_this.oidcSecurityValidation.Validate_signature_id_token(id_token, _this.jwtKeys)) {
                        // validate nonce
                        if (_this.oidcSecurityValidation.Validate_id_token_nonce(decoded, _this.retrieve('authNonce'))) {
                            // validate iss
                            if (_this.oidcSecurityValidation.Validate_id_token_iss(decoded, _this._configuration.iss)) {
                                // validate aud
                                if (_this.oidcSecurityValidation.Validate_id_token_aud(decoded, _this._configuration.client_id)) {
                                    // valiadate at_hash and access_token
                                    if (_this.oidcSecurityValidation.Validate_id_token_at_hash(token, decoded.at_hash) || !token) {
                                        _this.store('authNonce', '');
                                        _this.store('authStateControl', '');
                                        authResponseIsValid = true;
                                    }
                                    else {
                                        console.log('AuthorizedCallback incorrect aud');
                                    }
                                }
                                else {
                                    console.log('AuthorizedCallback incorrect aud');
                                }
                            }
                            else {
                                console.log('AuthorizedCallback incorrect iss');
                            }
                        }
                        else {
                            console.log('AuthorizedCallback incorrect nonce');
                        }
                    }
                    else {
                        console.log('AuthorizedCallback incorrect Signature id_token');
                    }
                }
                else {
                    console.log('AuthorizedCallback incorrect state');
                }
            }
            if (authResponseIsValid) {
                _this.SetAuthorizationData(token, id_token);
                // router navigate to Users
                _this._returnUrl = _this._tokenService.retrieveItem("redirectUrl");
                console.log("Local Storage Variabl", localStorage.getItem("redirectUrl"));
                console.log("This URL from oidc security: ", _this._returnUrl);
                if (_this._returnUrl !== null) {
                    _this._router.navigateByUrl(_this._returnUrl);
                }
                else {
                    _this._router.navigate(['admin/home/dashboard']);
                }
            }
            else {
                _this.ResetAuthorizationData();
                //this._router.navigate(['/Unauthorize']);
            }
        });
    };
    OidcSecurityService.prototype.Logoff = function () {
        // /connect/endsession?id_token_hint=...&post_logout_redirect_uri=https://myapp.com
        var authorizationEndsessionUrl = this._configuration.logoutEndSession_url;
        var id_token_hint = this.retrieve('authorizationDataIdToken');
        var post_logout_redirect_uri = this._configuration.post_logout_redirect_uri;
        var url = authorizationEndsessionUrl + '?' +
            'id_token_hint=' + encodeURI(id_token_hint) + '&' +
            'post_logout_redirect_uri=' + encodeURI(post_logout_redirect_uri);
        this.store('_isAuthorized', false);
        this.ResetAuthorizationData();
        this._tokenService.removeItem("redirectUrl"); // Added By Kyam
        window.location.href = url;
        //window.open(url,"_blank")
    };
    OidcSecurityService.prototype.getSigningKeys = function () {
        return this._http.get(this._configuration.jwks_url)
            .map(this.extractData)
            .catch(this.handleError);
    };
    OidcSecurityService.prototype.runGetSigningKeys = function () {
        var _this = this;
        this.getSigningKeys()
            .subscribe(function (jwtKeys) { return _this.jwtKeys = jwtKeys; }, function (error) { return _this.errorMessage = error; });
    };
    OidcSecurityService.prototype.extractData = function (res) {
        var body = res.json();
        return body;
    };
    OidcSecurityService.prototype.handleError = function (error) {
        // In a real world app, you might use a remote logging infrastructure
        var errMsg;
        if (error instanceof __WEBPACK_IMPORTED_MODULE_4__angular_http__["Response"]) {
            var body = error.json() || '';
            var err = body.error || JSON.stringify(body);
            errMsg = error.status + " - " + (error.statusText || '') + " " + err;
        }
        else {
            errMsg = error.message ? error.message : error.toString();
        }
        console.error(errMsg);
        return __WEBPACK_IMPORTED_MODULE_3_rxjs_Rx__["Observable"].throw(errMsg);
    };
    OidcSecurityService.prototype.ResetAuthorizationData = function () {
        this.store('authorizationData', '');
        this.store('authorizationDataIdToken', '');
        this._isAuthorized = false;
    };
    OidcSecurityService.prototype.SetAuthorizationData = function (token, id_token) {
        if (this.retrieve('authorizationData') !== '') {
            this.store('authorizationData', '');
        }
        this.store('authorizationData', token);
        this.store('authorizationDataIdToken', id_token);
        this._isAuthorized = true;
        this.store('_isAuthorized', true);
    };
    OidcSecurityService.prototype.Authorize = function () {
        this.ResetAuthorizationData();
        console.log('BEGIN Authorize, no auth data');
        var authorizationUrl = this._configuration.server + '/connect/authorize';
        var client_id = this._configuration.client_id;
        var redirect_uri = this._configuration.redirect_url;
        var response_type = this._configuration.response_type;
        var scope = this._configuration.scope;
        var nonce = 'N' + Math.random() + '' + Date.now();
        var state = Date.now() + '' + Math.random();
        this.store('authStateControl', state);
        this.store('authNonce', nonce);
        console.log('AuthorizedController created. adding myautostate: ' + this.retrieve('authStateControl'));
        var url = authorizationUrl + '?' +
            'response_type=' + encodeURI(response_type) + '&' +
            'client_id=' + encodeURI(client_id) + '&' +
            'redirect_uri=' + encodeURI(redirect_uri) + '&' +
            'scope=' + encodeURI(scope) + '&' +
            'nonce=' + encodeURI(nonce) + '&' +
            'state=' + encodeURI(state);
        window.location.href = url;
    };
    OidcSecurityService.prototype.retrieve = function (key) {
        var item = this.storage.getItem(key);
        if (item && item !== 'undefined') {
            return JSON.parse(this.storage.getItem(key));
        }
        return;
    };
    OidcSecurityService.prototype.store = function (key, value) {
        this.storage.setItem(key, JSON.stringify(value));
    };
    OidcSecurityService.prototype.GetToken = function () {
        return this.retrieve('authorizationData');
    };
    OidcSecurityService.prototype.setHeaders = function () {
        this.headers = new __WEBPACK_IMPORTED_MODULE_4__angular_http__["Headers"]();
        this.headers.append('Content-type', 'application/json');
        this.headers.append('Accept', 'application/json');
        var token = this.GetToken();
        if (token !== "") {
            this.headers.append('Authorization', 'Bearer ' + token);
        }
    };
    return OidcSecurityService;
}());
OidcSecurityService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_4__angular_http__["Http"] !== "undefined" && __WEBPACK_IMPORTED_MODULE_4__angular_http__["Http"]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_2__Services_auth_configuration_service__["a" /* AuthConfigurationService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__Services_auth_configuration_service__["a" /* AuthConfigurationService */]) === "function" && _b || Object, typeof (_c = typeof __WEBPACK_IMPORTED_MODULE_5__angular_router__["b" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_5__angular_router__["b" /* Router */]) === "function" && _c || Object])
], OidcSecurityService);

var _a, _b, _c;
//# sourceMappingURL=oidc-security.service.js.map

/***/ }),

/***/ "../../../../../src/app/Services/progressbar.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_Rx__ = __webpack_require__("../../../../rxjs/Rx.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_Rx___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_1_rxjs_Rx__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ProgressbarService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var ProgressbarService = (function () {
    function ProgressbarService() {
        this.loaderSubject = new __WEBPACK_IMPORTED_MODULE_1_rxjs_Rx__["Subject"]();
        this.loaderState = this.loaderSubject.asObservable();
    }
    ProgressbarService.prototype.show = function () {
        this.loaderSubject.next({ show: true });
    };
    ProgressbarService.prototype.hide = function () {
        this.loaderSubject.next({ show: false });
    };
    return ProgressbarService;
}());
ProgressbarService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])(),
    __metadata("design:paramtypes", [])
], ProgressbarService);

//# sourceMappingURL=progressbar.service.js.map

/***/ }),

/***/ "../../../../../src/app/Services/toast.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_ng2_toasty__ = __webpack_require__("../../../../ng2-toasty/index.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__CommonConstants_toasttype_configuration_constant__ = __webpack_require__("../../../../../src/app/CommonConstants/toasttype-configuration.constant.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ToastService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var ToastService = (function () {
    function ToastService(_toastService) {
        this._toastService = _toastService;
        this.ToastType = new __WEBPACK_IMPORTED_MODULE_2__CommonConstants_toasttype_configuration_constant__["a" /* ToasttypeConfiguration */]();
    }
    ToastService.prototype.toastMessage = function (title, msg, showClose, timeOut, theme, toastType) {
        var options = {
            title: title,
            msg: msg,
            showClose: showClose,
            timeout: timeOut,
            theme: theme
        };
        if (toastType == this.ToastType.info)
            this._toastService.info(options);
        if (toastType == this.ToastType.error)
            this._toastService.error(options);
        if (toastType == this.ToastType.success)
            this._toastService.success(options);
        if (toastType == this.ToastType.wait)
            this._toastService.wait(options);
        if (toastType == this.ToastType.warning)
            this._toastService.warning(options);
    };
    return ToastService;
}());
ToastService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1_ng2_toasty__["b" /* ToastyService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1_ng2_toasty__["b" /* ToastyService */]) === "function" && _a || Object])
], ToastService);

var _a;
//# sourceMappingURL=toast.service.js.map

/***/ }),

/***/ "../../../../../src/app/Services/token.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_angular2_jwt__ = __webpack_require__("../../../../angular2-jwt/angular2-jwt.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_angular2_jwt___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_1_angular2_jwt__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return TokenService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var TokenService = (function () {
    function TokenService() {
        this._jwtHelper = new __WEBPACK_IMPORTED_MODULE_1_angular2_jwt__["JwtHelper"]();
    }
    TokenService.prototype.decodeToken = function (token) {
        if (token !== '' && token !== undefined) {
            return this._jwtHelper.decodeToken(token);
        }
    };
    TokenService.prototype.getTokenExpirationDate = function (token) {
        if (token !== '' && token !== undefined) {
            return this._jwtHelper.getTokenExpirationDate(token);
        }
    };
    TokenService.prototype.isTokenExpired = function (token, offsetNumber) {
        if (token !== '' && token !== undefined) {
            return this._jwtHelper.isTokenExpired(token);
        }
        return true;
    };
    TokenService.prototype.retriveToken = function (key) {
        var item = localStorage.getItem(key);
        if (item && item !== 'undefined') {
            return JSON.parse(localStorage.getItem(key));
        }
        return;
    };
    TokenService.prototype.setItemStorage = function (key, value) {
        if (localStorage.getItem(key) == null) {
            localStorage.setItem(key, value);
        }
    };
    TokenService.prototype.removeItem = function (key) {
        if (localStorage.getItem(key) !== null) {
            localStorage.removeItem(key);
        }
    };
    TokenService.prototype.retrieveItem = function (key) {
        console.log("Local Storage token service", localStorage.getItem(key));
        return localStorage.getItem(key) !== null ? localStorage.getItem(key) : null;
    };
    TokenService.prototype.retrieveEmailFromToken = function (key) {
        var itemToken = this.retriveToken(key);
        if (itemToken !== null && itemToken !== 'undefined') {
            var item = this.decodeToken(itemToken);
            if (item && item !== 'undefined') {
                return item.email;
            }
            return;
        }
        return;
    };
    return TokenService;
}());
TokenService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])(),
    __metadata("design:paramtypes", [])
], TokenService);

//# sourceMappingURL=token.service.js.map

/***/ }),

/***/ "../../../../../src/app/Services/users.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__http_service__ = __webpack_require__("../../../../../src/app/Services/http.service.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return UsersService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var UsersService = (function () {
    function UsersService(_http) {
        this._http = _http;
    }
    UsersService.prototype.extractData = function (res) {
    };
    UsersService.prototype.GetAll = function () {
        //var a = new Headers();
        //return this._http.get("/api/Test").map(this.extractData);
        return this._http.get("test").map(function (res) {
            var body = res.json();
            return body.data || {};
        })
            .subscribe(function (action) {
            //Test;
        });
    };
    return UsersService;
}());
UsersService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__http_service__["a" /* HttpService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__http_service__["a" /* HttpService */]) === "function" && _a || Object])
], UsersService);

var _a;
//# sourceMappingURL=users.service.js.map

/***/ }),

/***/ "../../../../../src/app/app-footer/app-footer.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_common__ = __webpack_require__("../../../common/@angular/common.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__footer_footer_component__ = __webpack_require__("../../../../../src/app/app-footer/footer/footer.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__shared_shared_module__ = __webpack_require__("../../../../../src/app/shared/shared.module.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppFooterModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};




var AppFooterModule = (function () {
    function AppFooterModule() {
    }
    return AppFooterModule;
}());
AppFooterModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["NgModule"])({
        imports: [
            __WEBPACK_IMPORTED_MODULE_1__angular_common__["a" /* CommonModule */],
            __WEBPACK_IMPORTED_MODULE_3__shared_shared_module__["a" /* SharedModule */]
        ],
        declarations: [__WEBPACK_IMPORTED_MODULE_2__footer_footer_component__["a" /* FooterComponent */]],
        exports: [__WEBPACK_IMPORTED_MODULE_2__footer_footer_component__["a" /* FooterComponent */]]
    })
], AppFooterModule);

//# sourceMappingURL=app-footer.module.js.map

/***/ }),

/***/ "../../../../../src/app/app-footer/footer/footer.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".docs-footer {\r\n  margin-top: 40px;\r\n  padding: 12px;\r\n  font-size: 12px;\r\n}\r\n.docs-footer {\r\n  background: rgba(27, 27, 27, 0.85);\r\n  color: rgba(255, 255, 255, 0.87);\r\n}\r\n\r\n.docs-footer-list {\r\n  -webkit-box-align: center;\r\n  -ms-flex-align: center;\r\n  align-items: center;\r\n  display: -webkit-box;\r\n  display: -ms-flexbox;\r\n  display: flex;\r\n  -webkit-box-orient: horizontal;\r\n  -webkit-box-direction: normal;\r\n  -ms-flex-flow: row wrap;\r\n  flex-flow: row wrap;\r\n  padding: 8px;\r\n}\r\n.docs-footer-copyright {\r\n  display: -webkit-box;\r\n  display: -ms-flexbox;\r\n  display: flex;\r\n  -webkit-box-flex: 1;\r\n  -ms-flex: 1;\r\n  flex: 1;\r\n  -webkit-box-pack: end;\r\n  -ms-flex-pack: end;\r\n  justify-content: flex-end;\r\n}\r\n.docs-footer-links ul {\r\n  list-style: none;\r\n  margin: 0 40px;\r\n  padding: 0;\r\n}\r\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/app-footer/footer/footer.component.html":
/***/ (function(module, exports) {

module.exports = "<footer class=\"docs-footer\">\r\n  <div class=\"docs-footer-list\">\r\n    <div class=\"docs-footer-links\">\r\n      <ul>\r\n        <li><a href=\"https://rentler.com\">Rentler Admin</a> </li>\r\n      </ul>\r\n    </div>\r\n    <div class=\"docs-footer-copyright\">\r\n      <p>Powered by Rentler. Copyright 2017</p>\r\n    </div>\r\n  </div>\r\n</footer>"

/***/ }),

/***/ "../../../../../src/app/app-footer/footer/footer.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return FooterComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var FooterComponent = (function () {
    function FooterComponent() {
    }
    FooterComponent.prototype.ngOnInit = function () {
    };
    return FooterComponent;
}());
FooterComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
        selector: 'app-footer',
        template: __webpack_require__("../../../../../src/app/app-footer/footer/footer.component.html"),
        styles: [__webpack_require__("../../../../../src/app/app-footer/footer/footer.component.css")]
    }),
    __metadata("design:paramtypes", [])
], FooterComponent);

//# sourceMappingURL=footer.component.js.map

/***/ }),

/***/ "../../../../../src/app/app-header/app-header.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_common__ = __webpack_require__("../../../common/@angular/common.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__header_header_component__ = __webpack_require__("../../../../../src/app/app-header/header/header.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__app_shared_shared_module__ = __webpack_require__("../../../../../src/app/shared/shared.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__user_profiles_user_profiles_component__ = __webpack_require__("../../../../../src/app/app-header/user-profiles/user-profiles.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppHeaderModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};






var AppHeaderModule = (function () {
    function AppHeaderModule() {
    }
    return AppHeaderModule;
}());
AppHeaderModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["NgModule"])({
        imports: [
            __WEBPACK_IMPORTED_MODULE_1__angular_common__["a" /* CommonModule */],
            __WEBPACK_IMPORTED_MODULE_3__app_shared_shared_module__["a" /* SharedModule */],
            __WEBPACK_IMPORTED_MODULE_5__angular_router__["a" /* RouterModule */]
        ],
        declarations: [__WEBPACK_IMPORTED_MODULE_2__header_header_component__["a" /* HeaderComponent */], __WEBPACK_IMPORTED_MODULE_4__user_profiles_user_profiles_component__["a" /* UserProfilesComponent */]],
        exports: [__WEBPACK_IMPORTED_MODULE_2__header_header_component__["a" /* HeaderComponent */], __WEBPACK_IMPORTED_MODULE_4__user_profiles_user_profiles_component__["a" /* UserProfilesComponent */]]
        /*providers: [
            ProgressbarService,
            {
                provide: HttpService,
                useFactory: httpServiceFactory,
                deps: [XHRBackend, RequestOptions, ProgressbarService]
            }
           
        ]*/
    })
], AppHeaderModule);

//# sourceMappingURL=app-header.module.js.map

/***/ }),

/***/ "../../../../../src/app/app-header/header/header.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".docs-navbar {\r\n  display: -webkit-box;\r\n  display: -ms-flexbox;\r\n  display: flex;\r\n  -ms-flex-wrap: wrap;\r\n  flex-wrap: wrap;\r\n  -webkit-box-align: center;\r\n  -ms-flex-align: center;\r\n  align-items: center;\r\n  padding: 8px 16px;\r\n}\r\n\r\n.mat-button, .mat-fab, .mat-icon-button, .mat-mini-fab, .mat-raised-button {\r\n  box-sizing: border-box;\r\n  position: relative;\r\n  -webkit-user-select: none;\r\n  -moz-user-select: none;\r\n  -ms-user-select: none;\r\n  user-select: none;\r\n  cursor: pointer;\r\n  outline: 0;\r\n  border: none;\r\n  -webkit-tap-highlight-color: transparent;\r\n  display: inline-block;\r\n  white-space: nowrap;\r\n  text-decoration: none;\r\n  vertical-align: baseline;\r\n  text-align: center;\r\n  margin: 0;\r\n  min-width: 88px;\r\n  line-height: 36px;\r\n  padding: 0 16px;\r\n  border-radius: 2px;\r\n}\r\n\r\n.mat-button, .mat-icon-button, .mat-raised-button {\r\n  font-family: Roboto,Helvetica Neue,sans-serif;\r\n  font-size: 14px;\r\n  font-weight: 500;\r\n}\r\n\r\n.docs-button[md-button], .docs-button[md-raised-button] {\r\n  text-transform: uppercase;\r\n}\r\n\r\n.mat-button, .mat-icon-button, .mat-raised-button {\r\n  color: white;\r\n}\r\n\r\n.mat-button, .mat-icon-button, .mat-raised-button {\r\n  font-family: Roboto,Helvetica Neue,sans-serif;\r\n  font-size: 14px;\r\n  font-weight: 500;\r\n}\r\n\r\n.mat-button-focus-overlay, .mat-button-ripple {\r\n  position: absolute;\r\n  top: 0;\r\n  left: 0;\r\n  bottom: 0;\r\n  right: 0;\r\n  pointer-events: none;\r\n}\r\n\r\n.mat-ripple {\r\n  overflow: hidden;\r\n}\r\n.flex-spacer[_ngcontent-c1] {\r\n  -webkit-box-flex: 1;\r\n  -ms-flex-positive: 1;\r\n      flex-grow: 1;\r\n}", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/app-header/header/header.component.html":
/***/ (function(module, exports) {

module.exports = "<app-loader></app-loader>\r\n<nav class=\"docs-navbar\">\r\n  <a _ngcontent-c1=\"\" aria-label=\"Angular Material\" class=\"docs-button mat-button\" md-button=\"\" routerlink=\"/\" aria-disabled=\"false\" tabindex=\"0\" href=\"/\">\r\n    <span class=\"mat-button-wrapper\">\r\n      <span _ngcontent-c1=\"\">Rentler Admin</span>\r\n    </span>\r\n    <div class=\"mat-button-ripple mat-ripple\" md-ripple=\"\"></div><div class=\"mat-button-focus-overlay\"></div>\r\n  </a>\r\n  <div _ngcontent-c1=\"\" class=\"flex-spacer\"></div>\r\n\r\n  <div *ngIf=\"_securityService.IsAuthorized()\">\r\n    <button md-button [mdMenuTriggerFor]=\"menu\" class=\"docs-button mat-button\">{{_tokenService.retrieveEmailFromToken('authorizationData')}}<i class=\"material-icons\">dashboard</i></button>\r\n    <md-menu #menu=\"mdMenu\" xPosition=\"before\" [overlapTrigger]=\"false\">\r\n      <a (click)=\"logout()\" md-menu-item><md-icon>radio_button_checked</md-icon><span>Logout</span></a>\r\n      <a (click)=\"profile()\" md-menu-item><md-icon>account_circle</md-icon><span>Profile</span></a>\r\n    </md-menu>\r\n  </div>\r\n  \r\n \r\n  <!--<a _ngcontent-c1=\"\" aria-label=\"Angular Material\" class=\"docs-button mat-button\" md-button=\"\" routerlink=\"/\" aria-disabled=\"false\" tabindex=\"0\" href=\"/\">\r\n    <span class=\"mat-button-wrapper\">\r\n      <span _ngcontent-c1=\"\">\r\n\r\n       \r\n\r\n\r\n      </span>\r\n    </span>\r\n    <div class=\"mat-button-ripple mat-ripple\" md-ripple=\"\"></div><div class=\"mat-button-focus-overlay\"></div>\r\n  </a>-->\r\n  <button md-button color=\"accent\" (click)=\"startProgress()\">Start Progress</button>\r\n\r\n</nav>\r\n\r\n<!--<router-outlet></router-outlet>!-->\r\n"

/***/ }),

/***/ "../../../../../src/app/app-header/header/header.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__Services_toast_service__ = __webpack_require__("../../../../../src/app/Services/toast.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__Services_token_service__ = __webpack_require__("../../../../../src/app/Services/token.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__Services_oidc_security_service__ = __webpack_require__("../../../../../src/app/Services/oidc-security.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__guard_authentication_guard__ = __webpack_require__("../../../../../src/app/guard/authentication.guard.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__Services_users_service__ = __webpack_require__("../../../../../src/app/Services/users.service.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return HeaderComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};






var HeaderComponent = (function () {
    function HeaderComponent(_toastService, _tokenService, _securityService, _guard, _user) {
        this._toastService = _toastService;
        this._tokenService = _tokenService;
        this._securityService = _securityService;
        this._guard = _guard;
        this._user = _user;
    }
    HeaderComponent.prototype.ngOnInit = function () {
    };
    HeaderComponent.prototype.ngOnDestroy = function () {
        this.subscription.unsubscribe();
    };
    HeaderComponent.prototype.startProgress = function () {
        this._user.GetAll();
    };
    HeaderComponent.prototype.logout = function () {
        this._securityService.Logoff();
    };
    return HeaderComponent;
}());
HeaderComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
        selector: 'app-header',
        template: __webpack_require__("../../../../../src/app/app-header/header/header.component.html"),
        styles: [__webpack_require__("../../../../../src/app/app-header/header/header.component.css")]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__Services_toast_service__["a" /* ToastService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__Services_toast_service__["a" /* ToastService */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_2__Services_token_service__["a" /* TokenService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__Services_token_service__["a" /* TokenService */]) === "function" && _b || Object, typeof (_c = typeof __WEBPACK_IMPORTED_MODULE_3__Services_oidc_security_service__["a" /* OidcSecurityService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_3__Services_oidc_security_service__["a" /* OidcSecurityService */]) === "function" && _c || Object, typeof (_d = typeof __WEBPACK_IMPORTED_MODULE_4__guard_authentication_guard__["a" /* AuthenticationGuard */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_4__guard_authentication_guard__["a" /* AuthenticationGuard */]) === "function" && _d || Object, typeof (_e = typeof __WEBPACK_IMPORTED_MODULE_5__Services_users_service__["a" /* UsersService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_5__Services_users_service__["a" /* UsersService */]) === "function" && _e || Object])
], HeaderComponent);

var _a, _b, _c, _d, _e;
//# sourceMappingURL=header.component.js.map

/***/ }),

/***/ "../../../../../src/app/app-header/loader/loader.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".loader-hidden {\r\n  visibility: hidden;\r\n}\r\n\r\n.loader-overlay {\r\n  position: absolute;\r\n  width: 100%;\r\n  top: 0;\r\n  left: 0;\r\n  opacity: 1;\r\n  z-index: 500000;\r\n}\r\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/app-header/loader/loader.component.html":
/***/ (function(module, exports) {

module.exports = "<div [class.loader-hidden]=\"!show\">\r\n  <div class=\"loader-overlay\">\r\n    <div>\r\n      <md-progress-bar mode=\"indeterminate\" *ngIf=\"show\"></md-progress-bar>\r\n    </div>\r\n  </div>\r\n</div>"

/***/ }),

/***/ "../../../../../src/app/app-header/loader/loader.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__Services_progressbar_service__ = __webpack_require__("../../../../../src/app/Services/progressbar.service.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return LoaderComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var LoaderComponent = (function () {
    function LoaderComponent(loaderService) {
        this.loaderService = loaderService;
        this.show = false;
    }
    LoaderComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.subscription = this.loaderService.loaderState
            .subscribe(function (state) {
            _this.show = state.show;
        });
    };
    LoaderComponent.prototype.ngOnDestroy = function () {
        this.subscription.unsubscribe();
    };
    return LoaderComponent;
}());
LoaderComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
        selector: 'app-loader',
        template: __webpack_require__("../../../../../src/app/app-header/loader/loader.component.html"),
        styles: [__webpack_require__("../../../../../src/app/app-header/loader/loader.component.css")]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__Services_progressbar_service__["a" /* ProgressbarService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__Services_progressbar_service__["a" /* ProgressbarService */]) === "function" && _a || Object])
], LoaderComponent);

var _a;
//# sourceMappingURL=loader.component.js.map

/***/ }),

/***/ "../../../../../src/app/app-header/user-profiles/user-profiles.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/app-header/user-profiles/user-profiles.component.html":
/***/ (function(module, exports) {

module.exports = "<p>\r\n  user-profiles works!\r\n</p>\r\n"

/***/ }),

/***/ "../../../../../src/app/app-header/user-profiles/user-profiles.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return UserProfilesComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var UserProfilesComponent = (function () {
    function UserProfilesComponent() {
    }
    UserProfilesComponent.prototype.ngOnInit = function () {
    };
    return UserProfilesComponent;
}());
UserProfilesComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
        selector: 'app-user-profiles',
        template: __webpack_require__("../../../../../src/app/app-header/user-profiles/user-profiles.component.html"),
        styles: [__webpack_require__("../../../../../src/app/app-header/user-profiles/user-profiles.component.css")]
    }),
    __metadata("design:paramtypes", [])
], UserProfilesComponent);

//# sourceMappingURL=user-profiles.component.js.map

/***/ }),

/***/ "../../../../../src/app/app.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "app-root {\r\n  position: absolute;\r\n  top: 0;\r\n  bottom: 0;\r\n  left: 0;\r\n  right: 0;\r\n  display: -webkit-box;\r\n  display: -ms-flexbox;\r\n  display: flex;\r\n  -webkit-box-orient: vertical;\r\n  -webkit-box-direction: normal;\r\n  -ms-flex-direction: column;\r\n  flex-direction: column;\r\n}\r\n\r\n.fill-remaining-space {\r\n  This fills the remaining space, by using flexbox.  \r\n  Every toolbar row uses a flexbox row layout. \r\n  flex: 1 1 auto;\r\n}\r\n\r\n\r\n\r\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/app.component.html":
/***/ (function(module, exports) {

module.exports = "<ng2-toasty></ng2-toasty>\r\n<app-header class=\"mat-elevation-z6\"></app-header>\r\n<router-outlet></router-outlet>\r\n\r\n\r\n\r\n\r\n<!--<md-toolbar color=\"primary\">Responsive SideNavs using Flex-Layout </md-toolbar>\r\n<md-sidenav-container>\r\n  <md-sidenav #sidenav\r\n              mode=\"{{mode}}\"\r\n              [opened]=\"isOpen\"\r\n              class=\"example-sidenav\">\r\n\r\n    <ng-content select=\"[sidenav-content]\"></ng-content>\r\n    dasdadasd\r\n  </md-sidenav>\r\n  <div class=\"main-content\"\r\n       (click)=\"toggleSideNav()\" fxLayout=\"row\">\r\n    <button md-button\r\n            style=\"margin-bottom:50px;\"\r\n            *ngIf=\"media.isActive('xs')\">\r\n      {{ isOpen ? 'Close' : 'Open' }} SideNav\r\n    </button>\r\n\r\n    <ng-content select=\"[main-content]\"></ng-content>\r\n\r\n    <span>\r\n      Current\r\n      '{{ mediaChange.mqAlias }}' = {{ mediaChange.mediaQuery }}\r\n    </span>\r\n  </div>\r\n</md-sidenav-container>!-->\r\n\r\n\r\n\r\n\r\n\r\n  <!--<md-toolbar color=\"primary\">\r\n\r\n    <button md-button routerLink=\"/\">\r\n      <md-icon>home</md-icon>\r\n      TEST\r\n    </button>\r\n\r\n    <span class=\"fill-remaining-space\"></span>\r\n    <div fxLayout=\"row\" fxShow=\"false\" fxShow.gt-sm>\r\n      <button md-button routerLink=\"/products\">Products</button>\r\n      <button md-button routerLink=\"/dashboard\">Dashboard</button>\r\n    </div>\r\n    <button md-button [md-menu-trigger-for]=\"menu\" fxHide=\"false\" fxHide.gt-sm>\r\n      <md-icon>menu</md-icon>\r\n    </button>\r\n\r\n  </md-toolbar>\r\n  <md-menu x-position=\"before\" #menu=\"mdMenu\">\r\n    <button md-menu-item routerLink=\"/products\">Products</button>\r\n    <button md-menu-item routerLink=\"/dashboard\">Dashboard</button>\r\n  </md-menu>-->\r\n\r\n\r\n\r\n"

/***/ }),

/***/ "../../../../../src/app/app.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_add_operator_filter__ = __webpack_require__("../../../../rxjs/add/operator/filter.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_add_operator_filter___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_1_rxjs_add_operator_filter__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__angular_flex_layout__ = __webpack_require__("../../../flex-layout/index.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var AppComponent = (function () {
    function AppComponent(media) {
        var _this = this;
        this.media = media;
        this.isOpen = true;
        this._subscription = media.subscribe(function (change) {
            _this.isOpen = (change.mqAlias !== 'xs');
            _this.mediaChange = change;
            (change.mqAlias == 'xs') ? _this.mode = "over" : _this.mode = "side";
        });
    }
    AppComponent.prototype.toggleSideNav = function () { this.isOpen = !this.isOpen; };
    AppComponent.prototype.ngOnDestroy = function () { this._subscription.unsubscribe(); };
    return AppComponent;
}());
AppComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
        selector: 'app-root',
        template: __webpack_require__("../../../../../src/app/app.component.html"),
        styles: [__webpack_require__("../../../../../src/app/app.component.css")]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_2__angular_flex_layout__["b" /* ObservableMedia */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__angular_flex_layout__["b" /* ObservableMedia */]) === "function" && _a || Object])
], AppComponent);

var _a;
//# sourceMappingURL=app.component.js.map

/***/ }),

/***/ "../../../../../src/app/app.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__ = __webpack_require__("../../../platform-browser/@angular/platform-browser.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__angular_http__ = __webpack_require__("../../../http/@angular/http.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__app_component__ = __webpack_require__("../../../../../src/app/app.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__angular_platform_browser_animations__ = __webpack_require__("../../../platform-browser/@angular/platform-browser/animations.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__shared_unknown_page_unknown_page_component__ = __webpack_require__("../../../../../src/app/shared/unknown-page/unknown-page.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7__app_app_header_app_header_module__ = __webpack_require__("../../../../../src/app/app-header/app-header.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_8__app_app_footer_app_footer_module__ = __webpack_require__("../../../../../src/app/app-footer/app-footer.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_9__app_shared_shared_module__ = __webpack_require__("../../../../../src/app/shared/shared.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_10_hammerjs__ = __webpack_require__("../../../../hammerjs/hammer.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_10_hammerjs___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_10_hammerjs__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_11__app_app_component_app_login_app_login_component__ = __webpack_require__("../../../../../src/app/app_component/app-login/app-login.component.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};







//import { ToastModule } from 'ng2-toastr';
//Guard for Auth Routes
//import { AuthenticationGuard } from '../app/guard/authentication.guard';
//import { LoginGuard } from '../app/guard/login.guard';
//Modules





var appRoutes = [
    {
        path: 'unauthorized', component: __WEBPACK_IMPORTED_MODULE_6__shared_unknown_page_unknown_page_component__["a" /* UnknownPageComponent */]
    },
    { path: '', redirectTo: 'login', pathMatch: 'prefix' },
    { path: 'login', component: __WEBPACK_IMPORTED_MODULE_11__app_app_component_app_login_app_login_component__["a" /* AppLoginComponent */] },
    { path: 'admin', loadChildren: '../app/app-sidenav/app-sidenav.module#AppSidenavModule' },
    { path: '**', redirectTo: "/unauthorized", pathMatch: 'full' },
];
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_1__angular_core__["NgModule"])({
        declarations: [
            __WEBPACK_IMPORTED_MODULE_4__app_component__["a" /* AppComponent */],
            __WEBPACK_IMPORTED_MODULE_11__app_app_component_app_login_app_login_component__["a" /* AppLoginComponent */]
        ],
        imports: [
            __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__["a" /* BrowserModule */],
            __WEBPACK_IMPORTED_MODULE_2__angular_http__["HttpModule"],
            __WEBPACK_IMPORTED_MODULE_5__angular_platform_browser_animations__["a" /* BrowserAnimationsModule */],
            __WEBPACK_IMPORTED_MODULE_7__app_app_header_app_header_module__["a" /* AppHeaderModule */],
            __WEBPACK_IMPORTED_MODULE_8__app_app_footer_app_footer_module__["a" /* AppFooterModule */],
            //AppSidenavModule,
            //ComponentHeaderModule,
            //ComponentViewerModule,
            __WEBPACK_IMPORTED_MODULE_3__angular_router__["a" /* RouterModule */].forRoot(appRoutes),
            __WEBPACK_IMPORTED_MODULE_9__app_shared_shared_module__["a" /* SharedModule */]
            //ToastModule.forRoot()
        ],
        providers: [],
        bootstrap: [__WEBPACK_IMPORTED_MODULE_4__app_component__["a" /* AppComponent */]],
        exports: []
    }),
    __metadata("design:paramtypes", [])
], AppModule);

//# sourceMappingURL=app.module.js.map

/***/ }),

/***/ "../../../../../src/app/app_component/app-login/app-login.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "\r\n.wrapper-container{\r\n padding:80px; \r\n\r\n}\r\n.md-headline {\r\n  font-size: 24px;\r\n  font-weight: 400;\r\n  line-height: 32px;\r\n}\r\n.login-submit {\r\n  width: 100%;\r\n  padding: 5px 0;\r\n  background-color: rgba(46,46,46,0.93);\r\n  text-transform: uppercase;\r\n}\r\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/app_component/app-login/app-login.component.html":
/***/ (function(module, exports) {

module.exports = "\r\n    <div fxLayout=\"row\" fxLayoutAlign=\"space-around none\">\r\n          <div class=\"wrapper-container\">\r\n            <h1 class=\"md-headline\">Login in your account in </h1>\r\n            <div>\r\n              <button md-raised-button color=\"warn\" class=\"login-submit\" (click)=\"login()\">Auth Server</button>\r\n              <!--<button md-raised-button color=\"warn\" class=\"login-submit\" (click)=\"showSuccess()\">Show</button>-->\r\n            </div>\r\n          </div>\r\n      </div>\r\n"

/***/ }),

/***/ "../../../../../src/app/app_component/app-login/app-login.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__Services_oidc_security_service__ = __webpack_require__("../../../../../src/app/Services/oidc-security.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__Services_toast_service__ = __webpack_require__("../../../../../src/app/Services/toast.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__CommonConstants_toasttype_configuration_constant__ = __webpack_require__("../../../../../src/app/CommonConstants/toasttype-configuration.constant.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__CommonConstants_toasttheme_configuration_constant__ = __webpack_require__("../../../../../src/app/CommonConstants/toasttheme-configuration.constant.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__Services_token_service__ = __webpack_require__("../../../../../src/app/Services/token.service.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppLoginComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};







var AppLoginComponent = (function () {
    function AppLoginComponent(securityService, router, _activatedRoute, toastyService, _tokenService) {
        this.securityService = securityService;
        this.router = router;
        this._activatedRoute = _activatedRoute;
        this.toastyService = toastyService;
        this._tokenService = _tokenService;
        console.log("Login");
        this._toastTheme = new __WEBPACK_IMPORTED_MODULE_5__CommonConstants_toasttheme_configuration_constant__["a" /* ToastthemeConfiguration */]();
        this._toastType = new __WEBPACK_IMPORTED_MODULE_4__CommonConstants_toasttype_configuration_constant__["a" /* ToasttypeConfiguration */]();
    }
    AppLoginComponent.prototype.ngOnInit = function () {
        if (window.location.hash) {
            this.securityService.AuthorizedCallback();
            //Logged in
            if (this.securityService.IsAuthorized) {
                this.toastyService.toastMessage("AUTHENTICATION", "Logged in Successful !", true, 5000, this._toastTheme.material, this._toastType.success);
            }
            else {
                console.log("Not Authorized");
            }
        }
        else {
            if (this.securityService.retrieve('authorizationData') !== '' && this.securityService.retrieve('authorizationData') !== undefined) {
                //Proceed to Dashboard
                console.log("TEST");
                this.router.navigate(['admin/home/dashboard']);
            }
            else {
                //Login
            }
        }
    };
    AppLoginComponent.prototype.showSuccess = function () {
        this.toastyService.toastMessage("AUTHENTICATED!", "Logged in Successful !", true, 5000, this._toastTheme.material, this._toastType.success);
    };
    AppLoginComponent.prototype.login = function () {
        console.log("Login");
        this.securityService.Authorize();
    };
    return AppLoginComponent;
}());
AppLoginComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
        selector: 'app-app-login',
        template: __webpack_require__("../../../../../src/app/app_component/app-login/app-login.component.html"),
        styles: [__webpack_require__("../../../../../src/app/app_component/app-login/app-login.component.css")]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__Services_oidc_security_service__["a" /* OidcSecurityService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__Services_oidc_security_service__["a" /* OidcSecurityService */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_2__angular_router__["b" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__angular_router__["b" /* Router */]) === "function" && _b || Object, typeof (_c = typeof __WEBPACK_IMPORTED_MODULE_2__angular_router__["c" /* ActivatedRoute */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__angular_router__["c" /* ActivatedRoute */]) === "function" && _c || Object, typeof (_d = typeof __WEBPACK_IMPORTED_MODULE_3__Services_toast_service__["a" /* ToastService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_3__Services_toast_service__["a" /* ToastService */]) === "function" && _d || Object, typeof (_e = typeof __WEBPACK_IMPORTED_MODULE_6__Services_token_service__["a" /* TokenService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_6__Services_token_service__["a" /* TokenService */]) === "function" && _e || Object])
], AppLoginComponent);

var _a, _b, _c, _d, _e;
//# sourceMappingURL=app-login.component.js.map

/***/ }),

/***/ "../../../../../src/app/factories/http-service.factories.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__Services_http_service__ = __webpack_require__("../../../../../src/app/Services/http.service.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return httpServiceFactory; });

function httpServiceFactory(backend, options, loaderService) {
    return new __WEBPACK_IMPORTED_MODULE_0__Services_http_service__["a" /* HttpService */](backend, options, loaderService);
}

//# sourceMappingURL=http-service.factories.js.map

/***/ }),

/***/ "../../../../../src/app/guard/authentication.guard.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__Services_token_service__ = __webpack_require__("../../../../../src/app/Services/token.service.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AuthenticationGuard; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var AuthenticationGuard = (function () {
    function AuthenticationGuard(_tokenService, _router) {
        this._tokenService = _tokenService;
        this._router = _router;
    }
    AuthenticationGuard.prototype.canActivate = function (next, state) {
        if (this._tokenService.retriveToken('authorizationData') !== '' && this._tokenService.retriveToken('authorizationData') !== undefined) {
            console.log("Normal", this._tokenService.retrieveItem("redirectUrl"));
            console.log("DECODE", this._tokenService.decodeToken(this._tokenService.retriveToken('authorizationDataIdToken')));
            console.log("Expiration Date", this._tokenService.getTokenExpirationDate(this._tokenService.retriveToken('authorizationDataIdToken')));
            return true;
        }
        this._tokenService.setItemStorage("redirectUrl", state.url);
        this._router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
        return false;
    };
    AuthenticationGuard.prototype.getEmail = function (key) {
        this._tokenService.retrieveEmailFromToken(key);
    };
    return AuthenticationGuard;
}());
AuthenticationGuard = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_2__Services_token_service__["a" /* TokenService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__Services_token_service__["a" /* TokenService */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* Router */]) === "function" && _b || Object])
], AuthenticationGuard);

var _a, _b;
//# sourceMappingURL=authentication.guard.js.map

/***/ }),

/***/ "../../../../../src/app/options/angular-redux-request.options.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_http__ = __webpack_require__("../../../http/@angular/http.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AngularReduxRequest; });
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();

var AngularReduxRequest = (function (_super) {
    __extends(AngularReduxRequest, _super);
    function AngularReduxRequest(angularReduxOptions) {
        var _this = _super.call(this) || this;
        _this.token = JSON.parse(localStorage.getItem("authorizationDataIdToken"));
        _this.headers.append('Content-Type', 'application/json');
        _this.headers.append('Authorization', 'Bearer ' + _this.token);
        if (angularReduxOptions != null) {
            for (var option in angularReduxOptions) {
                var optionValue = angularReduxOptions[option];
                _this[option] = optionValue;
            }
        }
        return _this;
    }
    return AngularReduxRequest;
}(__WEBPACK_IMPORTED_MODULE_0__angular_http__["BaseRequestOptions"]));

//# sourceMappingURL=angular-redux-request.options.js.map

/***/ }),

/***/ "../../../../../src/app/shared/shared.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_common__ = __webpack_require__("../../../common/@angular/common.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_ng2_toasty__ = __webpack_require__("../../../../ng2-toasty/index.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__angular_material__ = __webpack_require__("../../../material/@angular/material.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__angular_flex_layout__ = __webpack_require__("../../../flex-layout/index.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__angular_cdk__ = __webpack_require__("../../../cdk/@angular/cdk.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__Services_token_service__ = __webpack_require__("../../../../../src/app/Services/token.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7__Services_oidc_security_service__ = __webpack_require__("../../../../../src/app/Services/oidc-security.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_8__Services_oidc_security_validation_service__ = __webpack_require__("../../../../../src/app/Services/oidc-security-validation.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_9__Services_auth_configuration_service__ = __webpack_require__("../../../../../src/app/Services/auth-configuration.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_10__Services_toast_service__ = __webpack_require__("../../../../../src/app/Services/toast.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_11__Services_users_service__ = __webpack_require__("../../../../../src/app/Services/users.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_12__Services_progressbar_service__ = __webpack_require__("../../../../../src/app/Services/progressbar.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_13__angular_http__ = __webpack_require__("../../../http/@angular/http.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_14__Services_http_service__ = __webpack_require__("../../../../../src/app/Services/http.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_15__factories_http_service_factories__ = __webpack_require__("../../../../../src/app/factories/http-service.factories.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_16__guard_authentication_guard__ = __webpack_require__("../../../../../src/app/guard/authentication.guard.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_17__shared_unknown_page_unknown_page_component__ = __webpack_require__("../../../../../src/app/shared/unknown-page/unknown-page.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_18__app_header_loader_loader_component__ = __webpack_require__("../../../../../src/app/app-header/loader/loader.component.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return SharedModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};






//Services






//Testing




//Guard

//Component


var SharedModule = (function () {
    function SharedModule() {
    }
    return SharedModule;
}());
SharedModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["NgModule"])({
        imports: [
            __WEBPACK_IMPORTED_MODULE_1__angular_common__["a" /* CommonModule */],
            __WEBPACK_IMPORTED_MODULE_2_ng2_toasty__["a" /* ToastyModule */].forRoot(),
            __WEBPACK_IMPORTED_MODULE_3__angular_material__["a" /* MaterialModule */],
            __WEBPACK_IMPORTED_MODULE_4__angular_flex_layout__["a" /* FlexLayoutModule */],
            __WEBPACK_IMPORTED_MODULE_3__angular_material__["b" /* MdTableModule */],
            __WEBPACK_IMPORTED_MODULE_5__angular_cdk__["a" /* CdkTableModule */]
        ],
        exports: [__WEBPACK_IMPORTED_MODULE_1__angular_common__["a" /* CommonModule */], __WEBPACK_IMPORTED_MODULE_2_ng2_toasty__["a" /* ToastyModule */], __WEBPACK_IMPORTED_MODULE_3__angular_material__["a" /* MaterialModule */], __WEBPACK_IMPORTED_MODULE_4__angular_flex_layout__["a" /* FlexLayoutModule */], __WEBPACK_IMPORTED_MODULE_17__shared_unknown_page_unknown_page_component__["a" /* UnknownPageComponent */], __WEBPACK_IMPORTED_MODULE_3__angular_material__["b" /* MdTableModule */], __WEBPACK_IMPORTED_MODULE_5__angular_cdk__["a" /* CdkTableModule */], __WEBPACK_IMPORTED_MODULE_18__app_header_loader_loader_component__["a" /* LoaderComponent */]],
        providers: [__WEBPACK_IMPORTED_MODULE_6__Services_token_service__["a" /* TokenService */], __WEBPACK_IMPORTED_MODULE_7__Services_oidc_security_service__["a" /* OidcSecurityService */], __WEBPACK_IMPORTED_MODULE_8__Services_oidc_security_validation_service__["a" /* OidcSecurityValidationService */], __WEBPACK_IMPORTED_MODULE_9__Services_auth_configuration_service__["a" /* AuthConfigurationService */], __WEBPACK_IMPORTED_MODULE_10__Services_toast_service__["a" /* ToastService */], __WEBPACK_IMPORTED_MODULE_16__guard_authentication_guard__["a" /* AuthenticationGuard */], __WEBPACK_IMPORTED_MODULE_11__Services_users_service__["a" /* UsersService */],
            __WEBPACK_IMPORTED_MODULE_12__Services_progressbar_service__["a" /* ProgressbarService */], {
                provide: __WEBPACK_IMPORTED_MODULE_14__Services_http_service__["a" /* HttpService */],
                useFactory: __WEBPACK_IMPORTED_MODULE_15__factories_http_service_factories__["a" /* httpServiceFactory */],
                deps: [__WEBPACK_IMPORTED_MODULE_13__angular_http__["XHRBackend"], __WEBPACK_IMPORTED_MODULE_13__angular_http__["RequestOptions"], __WEBPACK_IMPORTED_MODULE_12__Services_progressbar_service__["a" /* ProgressbarService */]]
            }],
        declarations: [__WEBPACK_IMPORTED_MODULE_17__shared_unknown_page_unknown_page_component__["a" /* UnknownPageComponent */], __WEBPACK_IMPORTED_MODULE_18__app_header_loader_loader_component__["a" /* LoaderComponent */]]
    })
], SharedModule);

//# sourceMappingURL=shared.module.js.map

/***/ }),

/***/ "../../../../../src/app/shared/unknown-page/unknown-page.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/shared/unknown-page/unknown-page.component.html":
/***/ (function(module, exports) {

module.exports = "<p>\r\n  unknown-page works!\r\n</p>\r\n"

/***/ }),

/***/ "../../../../../src/app/shared/unknown-page/unknown-page.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return UnknownPageComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var UnknownPageComponent = (function () {
    function UnknownPageComponent() {
    }
    UnknownPageComponent.prototype.ngOnInit = function () {
    };
    return UnknownPageComponent;
}());
UnknownPageComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
        selector: 'app-unknown-page',
        template: __webpack_require__("../../../../../src/app/shared/unknown-page/unknown-page.component.html"),
        styles: [__webpack_require__("../../../../../src/app/shared/unknown-page/unknown-page.component.css")]
    }),
    __metadata("design:paramtypes", [])
], UnknownPageComponent);

//# sourceMappingURL=unknown-page.component.js.map

/***/ }),

/***/ "../../../../../src/environments/environment.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return environment; });
// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.
// The file contents for the current environment will overwrite these during build.
var environment = {
    production: false
};
//# sourceMappingURL=environment.js.map

/***/ }),

/***/ "../../../../../src/main.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
Object.defineProperty(__webpack_exports__, "__esModule", { value: true });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__ = __webpack_require__("../../../platform-browser-dynamic/@angular/platform-browser-dynamic.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__app_app_module__ = __webpack_require__("../../../../../src/app/app.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__environments_environment__ = __webpack_require__("../../../../../src/environments/environment.ts");




if (__WEBPACK_IMPORTED_MODULE_3__environments_environment__["a" /* environment */].production) {
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["enableProdMode"])();
}
__webpack_require__.i(__WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__["a" /* platformBrowserDynamic */])().bootstrapModule(__WEBPACK_IMPORTED_MODULE_2__app_app_module__["a" /* AppModule */]);
//# sourceMappingURL=main.js.map

/***/ }),

/***/ 0:
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__("../../../../../src/main.ts");


/***/ })

},[0]);
//# sourceMappingURL=main.bundle.js.map