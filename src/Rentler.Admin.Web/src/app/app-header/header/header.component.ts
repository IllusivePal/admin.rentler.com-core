import { Component, OnInit } from '@angular/core';
import { ToastService } from '../../Services/toast.service';
import { TokenService } from '../../Services/token.service';
import { OidcSecurityService } from '../../Services/oidc-security.service';
import { AuthenticationGuard } from '../../guard/authentication.guard';
import { ProgressbarService } from '../../Services/progressbar.service';
import { Subscription  } from 'rxjs/Subscription';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
    private mode:string;
    private color: string;
    private isProgressstart: boolean;
    subscription: Subscription;
    constructor(private _toastService: ToastService
        , private _tokenService: TokenService
        , private _securityService: OidcSecurityService
        , private _guard: AuthenticationGuard
        , private _progressBar: ProgressbarService) {
        console.log("THIS IS APP HEADER");
        this.mode = this._progressBar.mode;

        console.log("IS TOKEN EXPIRED", this._tokenService.isTokenExpired(this._tokenService.retriveToken('authorizationDataIdToken')));
     
            
        

       
    }

    ngOnInit() {
      
    }

    ngOnDestroy()
    {
        this.subscription.unsubscribe();
    }

  logout()
  {
      

      this._securityService.Logoff();
  }

}
