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
        console.log("Hello Auth Guard", state.url);
        if (this._tokenService.retriveToken('authorizationData') !== '' && this._tokenService.retriveToken('authorizationData') !== undefined)
        {
            if (this._tokenService.retrieveItem("redirectUrl") !== null)
            {
                this._tokenService.removeItem("redirectUrl");
            }

            console.log("Redirect in auth guard", this._tokenService.retrieveItem("redirectUrl"));

            
            
            return true;
        }
        this._tokenService.setItemStorage("redirectUrl", state.url);
        this._router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
        return false;
    }

    getEmail(key:string)
    {
        this._tokenService.retrieveEmailFromToken(key);
    }
}
