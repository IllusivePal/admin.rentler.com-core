import { Component, OnInit,OnDestroy,Inject } from '@angular/core';
import { Http } from '@angular/http';

import { Subscription } from "rxjs";
import 'rxjs/add/operator/filter';

import {
    MediaChange,
    ObservableMedia,
    BreakPointRegistry
} from "@angular/flex-layout";

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent implements OnDestroy {
    /*constructor(private _httpService: Http) { }
    apiValues: string[] = [];
    ngOnInit() {
        this._httpService.get('/api/Test').subscribe(values => {
            this.apiValues = values.json() as string[];
            console.log("Result from API", this.apiValues);
        });
    }*/
    private _subscription;
    public isOpen = true;
    public mediaChange;
    public mode: string;
    constructor(public media: ObservableMedia) {
        console.log(this.mode);
        this._subscription = media.subscribe((change: MediaChange) => {
            this.isOpen = (change.mqAlias !== 'xs');
            this.mediaChange = change;
            (change.mqAlias == 'xs') ? this.mode = "over" : this.mode = "side";
           
        })
        
       
    }
   
    toggleSideNav() { this.isOpen = !this.isOpen; }
    ngOnDestroy() { this._subscription.unsubscribe(); }
}