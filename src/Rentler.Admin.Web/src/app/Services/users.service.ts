import { Injectable } from '@angular/core';
import { Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Store } from '@ngrx/store';
import { HttpService  } from './http.service';

@Injectable()
export class UsersService {
    constructor(private _http: HttpService) {
        
    }

    extractData(res: Response)
    {

    }

    GetAll()
    {
        //var a = new Headers();
        //return this._http.get("/api/Test").map(this.extractData);
        return this._http.get("test").map((res: Response) => {
            let body = res.json();
            return body.data || {};
        })
            .subscribe((action) => {
                //Test;
            });
    }

}
