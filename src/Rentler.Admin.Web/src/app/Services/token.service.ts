import { Injectable } from '@angular/core';
import { JwtHelper } from 'angular2-jwt';
import { Observable, Subject } from 'rxjs/Rx';


@Injectable()
export class TokenService {
    private _jwtHelper: JwtHelper;


    constructor() {
        this._jwtHelper = new JwtHelper();
    }

    public decodeToken(token:string)
    {
        if (token !== '' && token !== undefined)
        {
            return this._jwtHelper.decodeToken(token);
        }
    }
    public getTokenExpirationDate(token:string)
    {
        if (token !== '' && token !== undefined) {
            return this._jwtHelper.getTokenExpirationDate(token);
        }

    }
    public isTokenExpired(token: string, offsetNumber?: number)
    {
       
        if (token !== '' && token !== undefined) {
            console.log("Token Service", this._jwtHelper.isTokenExpired(token));
            return this._jwtHelper.isTokenExpired(token);
        }

        return true;

    }

    public retriveToken(key: string): any {
        var item = localStorage.getItem(key);

        if (item && item !== 'undefined') {
            return JSON.parse(localStorage.getItem(key));
        }

        return;

    }
    public setItemStorage(key: string, value: string)
    {
        if (localStorage.getItem(key) == null)
        {
            localStorage.setItem(key, value);
        }
    }
    public removeItem(key:string)
    {
        if (localStorage.getItem(key) !== null)
        {
            localStorage.removeItem(key);
        }
    }
    public retrieveItem(key:string)
    {
        console.log("Local Storage token service",localStorage.getItem(key));
        return localStorage.getItem(key) !== null ? localStorage.getItem(key) : null;

    }
    public retrieveEmailFromToken(key:string)
    {
        var itemToken = this.retriveToken(key);
        if (itemToken !== null && itemToken !== 'undefined')
        {
    
            var item = this.decodeToken(itemToken);
       
            if (item && item !== 'undefined')
            {
                return item.email;
            }

            return;
           
        }

        return;

    }

}
