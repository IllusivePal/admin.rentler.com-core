import { Injectable } from '@angular/core';
import { Http, Headers, Response } from '@angular/http';

@Injectable()
export class UsersService {
    constructor(private _http: Http) {
        
    }

    extractData(res: Response)
    {

    }

    GetAll()
    {
        var a = new Headers();
        return this._http.get("/api/Test").map(this.extractData);
    }

}
