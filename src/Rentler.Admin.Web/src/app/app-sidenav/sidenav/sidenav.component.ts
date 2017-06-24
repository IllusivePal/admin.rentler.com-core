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
    public isOpen = true;
    public mediaChange;
    public mode: string;
    constructor(public media: ObservableMedia) {
        console.log("this.mode", this.mode);
        this.mode = "side";
        this._subscription = media.subscribe((change: MediaChange) => {
            this.isOpen = (change.mqAlias !== 'xs');
            this.mediaChange = change;
            
            (change.mqAlias != 'xs') ? this.mode = "side" : this.mode = "over";
     

        })


    }

    toggleSideNav() {

        this.isOpen = !this.isOpen;
        this.mode = "over";
        console.log("is open", this.isOpen);

    }
    ngOnDestroy() { this._subscription.unsubscribe(); console.log("Destroy"); }

}
