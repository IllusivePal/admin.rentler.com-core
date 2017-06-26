import { Component, OnInit,OnDestroy } from '@angular/core';
import { Subscription } from "rxjs";
import 'rxjs/add/operator/filter';
import {
    MediaChange,
    ObservableMedia,
    BreakPointRegistry
} from "@angular/flex-layout";

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent implements OnDestroy {

    private _subscription;
    public isOpen;
    public mediaChange;
    public mode: string;
    constructor(public media: ObservableMedia) {
    
        console.log("this.mode", this.mode);
        console.log("Is Open", this.isOpen);
        console.log("change", this.mediaChange);
        console.log("media", media);
     
        this._subscription = media.subscribe((change: MediaChange) => {
            this.isOpen = (change.mqAlias !== 'xs');
            this.mediaChange = change;
            console.log("is open when refresh", this.isOpen);
            console.log("Subscription", this._subscription);
            (change.mqAlias !== 'xs') ? this.mode = "side" : this.mode = "over";


        });


    }

    toggleSideNav() {

        console.log("watch mode",this.isOpen);
        this.isOpen = !this.isOpen;
        this.mode = "over";
    }
    ngOnDestroy() { console.log("TEST")/*this._subscription.unsubscribe(); console.log("Destroy");*/ }

}
