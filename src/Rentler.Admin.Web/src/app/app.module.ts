import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

//import { ToastModule } from 'ng2-toastr';

//Guard for Auth Routes
import { AuthenticationGuard } from '../app/guard/authentication.guard';
import { LoginGuard } from '../app/guard/login.guard';


//Modules
import { AppHeaderModule } from '../app/app-header/app-header.module';
import { AppFooterModule } from '../app/app-footer/app-footer.module';
import { AppSidenavModule } from '../app/app-sidenav/app-sidenav.module';
import { ComponentHeaderModule } from '../app/component-header/component-header.module';
import { ComponentViewerModule } from '../app/component-viewer/component-viewer.module';
import { SidenavComponent } from '../app/app-sidenav/sidenav/sidenav.component';
import { SharedModule } from '../app/shared/shared.module';


import 'hammerjs';
import { AppLoginComponent } from '../app/app_component/app-login/app-login.component';

const appRoutes: Routes = [
    { path: '', redirectTo: 'login', pathMatch: 'prefix' },
    { path: 'login', component: AppLoginComponent, canActivate: [LoginGuard] },
   
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
      AppHeaderModule,
      AppFooterModule,
      AppSidenavModule,
      ComponentHeaderModule,
      ComponentViewerModule,
      RouterModule.forRoot(appRoutes),
      SharedModule
      //ToastModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent],
  exports: []
})
export class AppModule {
    constructor() {
        console.log("App Module");
    }
}
