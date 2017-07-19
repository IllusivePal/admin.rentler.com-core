import { Component, OnInit } from '@angular/core';
import { ToastService } from '../../Services/toast.service';
import { TokenService } from '../../Services/token.service';
import { OidcSecurityService } from '../../Services/oidc-security.service';
import { AuthenticationGuard } from '../../guard/authentication.guard';
import { Subscription } from 'rxjs/Subscription';
import { UsersService } from '../../Services/users.service';


@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
    private mode:string;
    private color: string;
    subscription: Subscription;
    constructor(private _toastService: ToastService
        , private _tokenService: TokenService
        , private _securityService: OidcSecurityService
        , private _guard: AuthenticationGuard
        , private _user: UsersService) {

       
    }

    ngOnInit() {
      
    }

    ngOnDestroy()
    {
        this.subscription.unsubscribe();
    }
    startProgress()
    {
        this._user.GetAll();
    }

  logout()
  {
      

      this._securityService.Logoff();
  }

}
