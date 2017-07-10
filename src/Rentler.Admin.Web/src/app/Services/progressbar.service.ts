import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs/Rx';

@Injectable()
export class ProgressbarService {

    mode: any;
    modeChange: Subject<string> = new Subject<string>();
    private testChange = new Subject<string>();
    testChange$ = this.testChange.asObservable();
    isProgressStart: any;
    isProgressChange: Subject<boolean> = new Subject<boolean>();
    color: any;
    colorChange: Subject<string> = new Subject<string>();
    constructor() {

        this.testChange.next('test');
    }

    start(mode:string,color:string)
    {
        

        this.mode = mode;
        //this.modeChange$ = this.modeChange.asObservable();
        this.modeChange.next(this.mode);
        
        this.color = color;
        this.colorChange.next(this.color);
        this.isProgressStart = true;
        this.isProgressChange.next(this.isProgressStart);
        console.log("THIS mode", this.mode);
        console.log("This color", this.color);
        console.log("This Progress", this.isProgressStart)
        console.log("THIS modechange", this.modeChange);
        console.log("This colorchange", this.colorChange);
        console.log("This progresschange", this.isProgressChange);

    }

}
