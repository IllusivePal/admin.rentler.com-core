import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { HeaderComponent } from './header/header.component';
import { SharedModule } from '../../app/shared/shared.module';
import { UserProfilesComponent } from './user-profiles/user-profiles.component';
import { Routes, RouterModule } from '@angular/router';



@NgModule({
    
    imports: [
        CommonModule,
        SharedModule,
        RouterModule
     
    ],
    declarations: [HeaderComponent, UserProfilesComponent],
  exports: [HeaderComponent]
})
export class AppHeaderModule { }
