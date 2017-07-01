import { Component, OnInit } from '@angular/core';
import { ToastService } from '../../Services/toast.service';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

    constructor(private _toastService: ToastService) {
       
        console.log("HEADER! Component Module");
    }

  ngOnInit() {
  }

}
