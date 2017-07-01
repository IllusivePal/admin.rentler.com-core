import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './footer/footer.component';
import { MaterialModule } from '@angular/material';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  imports: [
      CommonModule,
      SharedModule
  ],
  declarations: [FooterComponent],
  exports: [FooterComponent]
})
export class AppFooterModule { }
