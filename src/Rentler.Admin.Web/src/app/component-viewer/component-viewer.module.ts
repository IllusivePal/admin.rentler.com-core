import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ComponentViewerComponent } from './component-viewer/component-viewer.component';
import { MaterialModule } from '@angular/material';

@NgModule({
  imports: [
      CommonModule,
      MaterialModule
  ],
  declarations: [ComponentViewerComponent],
  exports: [ComponentViewerComponent]
})
export class ComponentViewerModule { }
