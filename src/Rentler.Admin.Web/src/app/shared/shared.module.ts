import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { ToastyModule } from 'ng2-toasty';
import { MaterialModule } from '@angular/material';
import { FlexLayoutModule } from '@angular/flex-layout';

//Services
import { TokenService } from '../Services/token.service';
import { OidcSecurityService } from '../Services/oidc-security.service';
import { OidcSecurityValidationService } from '../Services/oidc-security-validation.service';
import { AuthConfigurationService } from '../Services/auth-configuration.service';
import { ToastService } from '../Services/toast.service';

//Guard
import { AuthenticationGuard } from '../guard/authentication.guard';
import { LoginGuard } from '../guard/login.guard';

@NgModule({
  imports: [
      CommonModule,
      ToastyModule.forRoot(),
      MaterialModule,
      FlexLayoutModule
    ],
  exports: [CommonModule, ToastyModule, MaterialModule, FlexLayoutModule],
  providers: [TokenService, OidcSecurityService, OidcSecurityValidationService, AuthConfigurationService, ToastService, AuthenticationGuard, LoginGuard],
  declarations: []
})
export class SharedModule { }
