import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidenavComponent } from './sidenav/sidenav.component';
import { MaterialModule } from '@angular/material';
import { AppFooterModule } from '../app-footer/app-footer.module';
import { ComponentHeaderModule } from '../component-header/component-header.module';
import { ComponentViewerModule } from '../component-viewer/component-viewer.module';
import { Routes, RouterModule } from '@angular/router';
import { FlexLayoutModule } from '@angular/flex-layout';

//Components
import { DashboardComponent } from '../component-viewer/dashboard/dashboard.component';
import { SubscriptionComponent } from '../component-viewer/subscription/subscription.component';
import { ApplicationsComponent } from '../component-viewer/applications/applications.component';
import { ComponentViewerComponent } from '../component-viewer/component-viewer/component-viewer.component';
import { CommunitiesComponent } from '../component-viewer/communities/communities.component';
import { ScreeningComponent } from '../component-viewer/screening/screening.component';
import { IdverifyComponent } from '../component-viewer/idverify/idverify.component';


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
        children:
        [{
             path: 'home',
             component: ComponentViewerComponent,
             children:
                      [
                              {
                                  path: 'dashboard',
                                  component: DashboardComponent
                              },
                              {
                                  path: 'subscription',
                                  component: SubscriptionComponent
                              },
                              {
                                  path: 'applications',
                                  component: ApplicationsComponent
                              },
                              {
                                  path: 'community',
                                  component: CommunitiesComponent
                              },
                              {
                                  path: 'screening',
                                  component: ScreeningComponent
                              },
                              {
                                  path: 'idverify',
                                  component: IdverifyComponent
                              }
                      ]
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
