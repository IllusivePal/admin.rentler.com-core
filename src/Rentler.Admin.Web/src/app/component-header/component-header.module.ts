import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ComponentHeaderComponent } from './component-header/component-header.component';
import { MaterialModule } from '@angular/material';

@NgModule({
  imports: [
      CommonModule,
      MaterialModule
  ],
  declarations: [ComponentHeaderComponent],
  exports: [ComponentHeaderComponent]
})
export class ComponentHeaderModule { }
