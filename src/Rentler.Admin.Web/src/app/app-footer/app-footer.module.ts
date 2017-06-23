import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './footer/footer.component';
import { MaterialModule } from '@angular/material';

@NgModule({
  imports: [
      CommonModule,
      MaterialModule
  ],
  declarations: [FooterComponent],
  exports: [FooterComponent]
})
export class AppFooterModule { }
