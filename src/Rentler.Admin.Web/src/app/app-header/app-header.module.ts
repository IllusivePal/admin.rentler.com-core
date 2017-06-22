import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { HeaderComponent } from './header/header.component';
import { AppComponent } from '../app.component';
import { MaterialModule } from '@angular/material';

@NgModule({
    imports: [
        CommonModule,
        MaterialModule
     
  ],
  declarations: [HeaderComponent],
  exports: [HeaderComponent]
})
export class AppHeaderModule { }
