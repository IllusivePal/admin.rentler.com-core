import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { MaterialModule } from '@angular/material';


@NgModule({
    declarations:[],
    imports: [CommonModule],
    exports: [CommonModule,HttpModule, MaterialModule, RouterModule, FormsModule]

})

export class AngularSharedModule{}