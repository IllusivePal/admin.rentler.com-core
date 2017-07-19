import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { HeaderComponent } from './header/header.component';
import { SharedModule } from '../../app/shared/shared.module';
import { UserProfilesComponent } from './user-profiles/user-profiles.component';
import { Routes, RouterModule } from '@angular/router';
import { LoaderComponent } from '../app-header/loader/loader.component';



import { ProgressbarService } from '../Services/progressbar.service';
import { XHRBackend, RequestOptions } from '@angular/http';
import { HttpService } from '../Services/http.service';
import { httpServiceFactory } from '../factories/http-service.factories'


@NgModule({
    
    imports: [
        CommonModule,
        SharedModule,
        RouterModule
     
    ],
    declarations: [HeaderComponent, UserProfilesComponent],
    exports: [HeaderComponent, UserProfilesComponent]
    /*providers: [
        ProgressbarService,
        {
            provide: HttpService,
            useFactory: httpServiceFactory,
            deps: [XHRBackend, RequestOptions, ProgressbarService]
        }
       
    ]*/
})
export class AppHeaderModule { }
