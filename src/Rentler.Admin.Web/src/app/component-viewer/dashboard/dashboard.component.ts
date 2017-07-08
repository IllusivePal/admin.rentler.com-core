import { Component, OnInit } from '@angular/core';
import { UsersService } from '../../Services/users.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css'],
  providers: [UsersService]
})
export class DashboardComponent implements OnInit {

    constructor(private _userService: UsersService) { }

    ngOnInit() {

        this._userService.GetAll().subscribe((res) => {
            console.log("THIS IS AWESOME SUBSCRIBE", res);
        });
  }

}
