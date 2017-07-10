import { Component, OnInit } from '@angular/core';
import { UsersService } from '../../Services/users.service';
import { ProgressbarService } from '../../Services/progressbar.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css'],
  providers: [UsersService]
})
export class DashboardComponent implements OnInit {

    constructor(private _userService: UsersService,
        private _progressBar: ProgressbarService) { }

    ngOnInit() {

        this._userService.GetAll().subscribe((res) => {
            console.log("THIS IS AWESOME SUBSCRIBE", res);
        });
    }

    startProgress()
    {
        console.log("TEST Progress");
        this._progressBar.start("indeterminate","primary");
    }

}
