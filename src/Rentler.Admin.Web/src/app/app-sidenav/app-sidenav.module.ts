import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidenavComponent } from './sidenav/sidenav.component';
import { MaterialModule } from '@angular/material';
import { AppFooterModule } from '../app-footer/app-footer.module';
@NgModule({
  imports: [
      CommonModule,
      MaterialModule,
      AppFooterModule
  ],
  declarations: [SidenavComponent],
  exports: [SidenavComponent]
})
export class AppSidenavModule { }
