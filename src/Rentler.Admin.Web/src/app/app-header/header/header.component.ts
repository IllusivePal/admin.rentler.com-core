import { Component, OnInit } from '@angular/core';
import { ToastService } from '../../Services/toast.service';
import { TokenService } from '../../Services/token.service';
import { OidcSecurityService } from '../../Services/oidc-security.service';
import { AuthenticationGuard } from '../../guard/authentication.guard';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
    private userEmail:string
    constructor(private _toastService: ToastService
        , private _tokenService: TokenService
        , private _securityService: OidcSecurityService
        , private _guard: AuthenticationGuard) {
        
        console.log("HEADER! Component Module");
        console.log("Is Authorized", this._securityService.IsAuthorized());
        this.userEmail = this._tokenService.retrieveEmailFromToken('authorizationData');
    }

  ngOnInit() {
    }

  logout()
  {
      

      this._securityService.Logoff();
  }

}
