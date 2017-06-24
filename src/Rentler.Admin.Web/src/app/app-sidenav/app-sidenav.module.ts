import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidenavComponent } from './sidenav/sidenav.component';
import { MaterialModule } from '@angular/material';
import { AppFooterModule } from '../app-footer/app-footer.module';
import { ComponentHeaderModule } from '../component-header/component-header.module';
import { ComponentViewerModule } from '../component-viewer/component-viewer.module';
import { Routes, RouterModule } from '@angular/router';

import { FlexLayoutModule } from '@angular/flex-layout';
import { ComponentHeaderComponent } from '../component-header/component-header/component-header.component';
import { DashboardComponent } from '../component-viewer/dashboard/dashboard.component';
import { SubscriptionComponent } from '../component-viewer/subscription/subscription.component';
import { ComponentViewerComponent } from '../component-viewer/component-viewer/component-viewer.component';


const appRoutes: Routes = [
    {
        path: 'admin', redirectTo: '/admin/home/dashboard', pathMatch:'full'
    },
    {
        path: 'admin/home', redirectTo: '/admin/home/dashboard', pathMatch: 'full'
    }
    ,
    {
        path: 'admin', component: SidenavComponent,
        children: [{
            path: 'home',
            component: ComponentViewerComponent,
            children: [{
                path: 'dashboard',
                component: DashboardComponent
            }, {
                    path: 'subscription',
                    component: SubscriptionComponent
                }]
        }]
    }
];

@NgModule({
  imports: [
      CommonModule,
      MaterialModule,
      AppFooterModule,
      ComponentHeaderModule,
      ComponentViewerModule,
      RouterModule.forChild(appRoutes),
      FlexLayoutModule
  ],
  declarations: [SidenavComponent],
  exports: [SidenavComponent]
})
export class AppSidenavModule {
    constructor() { console.log("Side Nav Module"); }
}
