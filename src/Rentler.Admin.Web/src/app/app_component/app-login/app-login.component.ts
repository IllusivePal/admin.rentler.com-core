import { Component, OnInit } from '@angular/core';
import { OidcSecurityService } from '../../Services/oidc-security.service';
import { Router, ActivatedRoute } from '@angular/router';

import { ToastService } from '../../Services/toast.service';
import { ToasttypeConfiguration } from '../../CommonConstants/toasttype-configuration.constant';
import { ToastthemeConfiguration } from '../../CommonConstants/toasttheme-configuration.constant';
import { TokenService } from '../../Services/token.service';

@Component({
  selector: 'app-app-login',
  templateUrl: './app-login.component.html',
  styleUrls: ['./app-login.component.css']
})
export class AppLoginComponent implements OnInit {
    private _toastTheme: ToastthemeConfiguration;
    private _toastType: ToasttypeConfiguration;
    constructor(private securityService: OidcSecurityService, private router: Router, private _activatedRoute: ActivatedRoute,
        private toastyService: ToastService, private _tokenService: TokenService) {
        console.log("Login");
        this._toastTheme = new ToastthemeConfiguration();
        this._toastType = new ToasttypeConfiguration();
       
    }

    ngOnInit() {
        if (window.location.hash) {
            this.securityService.AuthorizedCallback();
            //Logged in
            if (this.securityService.IsAuthorized)
            {
                this.toastyService.toastMessage("AUTHENTICATION", "Logged in Successful !", true, 5000, this._toastTheme.material, this._toastType.success);
            } else
            {
                console.log("Not Authorized");
            }
        }else
        {
            if (this.securityService.retrieve('authorizationData') !== '' && this.securityService.retrieve('authorizationData') !== undefined)
            {
                //Proceed to Dashboard
                console.log("TEST");
                this.router.navigate(['admin/home/dashboard']);
            } else
            {
                //Login
            }
        }

        
    }
    showSuccess()
    {

        this.toastyService.toastMessage("AUTHENTICATED!", "Logged in Successful !", true, 5000, this._toastTheme.material, this._toastType.success);


    }
    
    login() {

      console.log("Login");
      this.securityService.Authorize();
    }

}
