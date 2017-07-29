import { Injectable } from '@angular/core';
import { Response, Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Store } from '@ngrx/store';
import { HttpService  } from './http.service';

@Injectable()
export class UsersService {
    constructor(private _http: HttpService, private _http2: Http) {
        
    }

    extractData(res: Response)
    {

    }

    GetAll()
    {
        var a = new Headers();
        return this._http2.get("/api/Test").map((res: Response) => res.json());
        /*return this._http.get("test").map((res: Response) => {
            let body = res.json();
            return body.data || {};
        })
            .subscribe((action) => {
                //Test;
            });*/
    }

}
