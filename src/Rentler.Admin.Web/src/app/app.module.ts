import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from '@angular/material';

import { AppHeaderModule } from '../app/app-header/app-header.module';
import { AppFooterModule } from '../app/app-footer/app-footer.module';

import 'hammerjs';

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
      AppFooterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
