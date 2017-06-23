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

import 'hammerjs';

const appRoutes: Routes = [
    { path: '', redirectTo: '/admin', pathMatch: 'full' },
    { path: 'admin', component: SidenavComponent },
];

@NgModule({
  declarations: [
      AppComponent
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
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
