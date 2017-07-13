import { Injectable } from '@angular/core';
import { Router,CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { TokenService } from '../Services/token.service';

@Injectable()
export class AuthenticationGuard implements CanActivate {
    constructor(private _tokenService: TokenService, private _router: Router) {
    }
    canActivate(
      next: ActivatedRouteSnapshot,
      state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
        if (this._tokenService.retriveToken('authorizationData') !== '' && this._tokenService.retriveToken('authorizationData') !== undefined)
        {
            console.log("Normal", this._tokenService.retrieveItem("redirectUrl"));
            console.log("DECODE", this._tokenService.decodeToken(this._tokenService.retriveToken('authorizationDataIdToken')))
            console.log("Expiration Date", this._tokenService.getTokenExpirationDate(this._tokenService.retriveToken('authorizationDataIdToken')))
            return true;
        }
        console.log("Auth Guard is Token Expired!", this._tokenService.isTokenExpired(this._tokenService.retriveToken('authorizationData')));
        this._tokenService.setItemStorage("redirectUrl", state.url);
        console.log("RETRIEVE REDIRECT URL FROM AUTH GUARD", this._tokenService.retrieveItem('redirectUrl'))
        this._router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
        return false;
    }

    getEmail(key:string)
    {
        this._tokenService.retrieveEmailFromToken(key);
    }
}
