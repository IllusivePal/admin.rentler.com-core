import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidenavComponent } from './sidenav/sidenav.component';
import { MaterialModule } from '@angular/material';
import { AppFooterModule } from '../app-footer/app-footer.module';
import { ComponentHeaderModule } from '../component-header/component-header.module';
import { ComponentViewerModule } from '../component-viewer/component-viewer.module';
import { Routes, RouterModule } from '@angular/router';
import { ComponentHeaderComponent } from '../component-header/component-header/component-header.component';


const appRoutes: Routes = [
    {
        path: 'admin', component: SidenavComponent,
        children: [{
            path: 'dashboard',
            component: ComponentHeaderComponent
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
      RouterModule.forChild(appRoutes)
  ],
  declarations: [SidenavComponent],
  exports: [SidenavComponent]
})
export class AppSidenavModule { }
