import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from '@angular/material';

import { AppHeaderModule } from '../app/app-header/app-header.module';
import { AppFooterModule } from '../app/app-footer/app-footer.module';
import { AppSidenavModule } from '../app/app-sidenav/app-sidenav.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { ComponentHeaderModule } from '../app/component-header/component-header.module';
import { ComponentViewerModule } from '../app/component-viewer/component-viewer.module';
import { SidenavComponent } from '../app/app-sidenav/sidenav/sidenav.component';

//Services
import { OidcSecurityService } from '../app/Services/oidc-security.service';
import { OidcSecurityValidationService } from '../app/Services/oidc-security-validation.service';
import { AuthConfigurationService } from '../app/Services/auth-configuration.service';

import 'hammerjs';
import { AppLoginComponent } from '../app/app_component/app-login/app-login.component';

const appRoutes: Routes = [
    { path: '', redirectTo: '/login', pathMatch: 'full' },
    { path: 'login', component: AppLoginComponent },
   
];

@NgModule({
  declarations: [
      AppComponent,
      AppLoginComponent
  ],
  imports: [
      BrowserModule,
      HttpModule,
      BrowserAnimationsModule,
      MaterialModule,
      AppHeaderModule,
      AppFooterModule,
      AppSidenavModule,
      ComponentHeaderModule,
      ComponentViewerModule,
      FlexLayoutModule,
      RouterModule.forRoot(appRoutes)
  ],
  providers: [OidcSecurityService, OidcSecurityValidationService, AuthConfigurationService],
  bootstrap: [AppComponent]
})
export class AppModule {
    constructor() {
        console.log("App Module");
    }
}
