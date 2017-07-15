import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs/Rx';
import { LoaderState} from '../app-header/loader/loader';

@Injectable()
export class ProgressbarService {

    private loaderSubject = new Subject<LoaderState>();

    loaderState = this.loaderSubject.asObservable();
    constructor() {
    }

    show() {
        this.loaderSubject.next(<LoaderState>{ show: true });
    }

    hide()
    {
        this.loaderSubject.next(<LoaderState>{ show: false });
    }

   

}
