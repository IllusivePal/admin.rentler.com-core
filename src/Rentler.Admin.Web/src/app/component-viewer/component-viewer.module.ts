﻿import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ComponentViewerComponent } from './component-viewer/component-viewer.component';
import { MaterialModule } from '@angular/material';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SidenavComponent } from '../app-sidenav/sidenav/sidenav.component';
import { SubscriptionComponent } from './subscription/subscription.component';

/*const appRoutes: Routes = [
    {
        path: 'dashboard', component: ComponentViewerComponent,
        children: [{
            path: 'overview',
            component: DashboardComponent
          }]
    }
];*/

@NgModule({
  imports: [
      CommonModule,
      MaterialModule,
      RouterModule
  ],
  declarations: [ComponentViewerComponent, DashboardComponent, SubscriptionComponent],
  exports: [ComponentViewerComponent]
})
export class ComponentViewerModule {
    constructor() {
        console.log("ComponentViewerModule");
    }
}
