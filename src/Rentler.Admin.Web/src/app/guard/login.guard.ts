import { Injectable } from '@angular/core';
import { Router,CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { TokenService } from '../Services/token.service';


@Injectable()
export class LoginGuard implements CanActivate {
    constructor(private _tokenService: TokenService, private _router: Router)
    {

    }
    canActivate(
        next: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
        if (this._tokenService.retriveToken('authorizationData') !== '' && this._tokenService.retriveToken('authorizationData') !== undefined) 
        {
            console.log("HEY RETURN FALSE");
            this._router.navigate(['/admin/dashboard']);
            return false;

        } else
        {
            return true;
        }
  }
}
