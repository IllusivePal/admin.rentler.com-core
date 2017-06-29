import { Component, OnInit } from '@angular/core';
import { OidcSecurityService } from '../../Services/oidc-security.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-app-login',
  templateUrl: './app-login.component.html',
  styleUrls: ['./app-login.component.css']
})
export class AppLoginComponent implements OnInit {

    constructor(private securityService: OidcSecurityService, private router: Router) {
        console.log("Login");
    }

    ngOnInit() {
        if (window.location.hash) {
            console.log("NGONINIT")
            this.securityService.AuthorizedCallback();
        } else
        {
            console.log("No Hash");
        }

        
    }

  login() {

      console.log("Login");
      this.securityService.Authorize();
  }

}
