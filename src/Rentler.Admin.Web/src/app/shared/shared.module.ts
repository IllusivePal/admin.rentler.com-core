import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { ToastyModule } from 'ng2-toasty';
import { MaterialModule, MdTableModule } from '@angular/material';
import { FlexLayoutModule } from '@angular/flex-layout';
import { CdkTableModule } from '@angular/cdk';


//Services
import { TokenService } from '../Services/token.service';
import { OidcSecurityService } from '../Services/oidc-security.service';
import { OidcSecurityValidationService } from '../Services/oidc-security-validation.service';
import { AuthConfigurationService } from '../Services/auth-configuration.service';
import { ToastService } from '../Services/toast.service';
import { UsersService } from '../Services/users.service';

//Testing
import { ProgressbarService } from '../Services/progressbar.service';
import { XHRBackend, RequestOptions } from '@angular/http';
import { HttpService } from '../Services/http.service';
import { httpServiceFactory } from '../factories/http-service.factories';
//Guard
import { AuthenticationGuard } from '../guard/authentication.guard';
import { LoginGuard } from '../guard/login.guard';

//Component
import { UnknownPageComponent } from '../shared/unknown-page/unknown-page.component';
import { LoaderComponent } from '../app-header/loader/loader.component';

@NgModule({
  imports: [
      CommonModule,
      ToastyModule.forRoot(),
      MaterialModule,
      FlexLayoutModule,
      MdTableModule,
      CdkTableModule
    ],
  exports: [CommonModule, ToastyModule, MaterialModule, FlexLayoutModule, UnknownPageComponent, MdTableModule, CdkTableModule, LoaderComponent],
  providers: [TokenService, OidcSecurityService, OidcSecurityValidationService, AuthConfigurationService, ToastService, AuthenticationGuard, UsersService,
      ProgressbarService, {
      provide: HttpService,
      useFactory: httpServiceFactory,
      deps: [XHRBackend, RequestOptions, ProgressbarService]
  }],
  declarations: [UnknownPageComponent, LoaderComponent]
})
export class SharedModule { }
