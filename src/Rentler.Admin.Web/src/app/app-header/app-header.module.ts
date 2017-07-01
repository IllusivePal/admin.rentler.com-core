import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { HeaderComponent } from './header/header.component';
import { SharedModule } from '../../app/shared/shared.module';



@NgModule({
    
    imports: [
        CommonModule,
        SharedModule
     
    ],
    declarations: [HeaderComponent],
  exports: [HeaderComponent]
})
export class AppHeaderModule { }
