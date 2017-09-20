import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Route } from '@angular/router';
import { MaterialModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { CustomRoutesModule, routingComponents } from './components/import_pages/custom_import_module';
import { AngularSharedModule } from './components/import_pages/custom_import_module';
import { UsersModule } from './components/import_pages/custom_import_module';

@NgModule({
    declarations: [
        routingComponents
    ],
    imports: [
        AngularSharedModule,
        UsersModule,
        CustomRoutesModule
    ]
})
export class AppModuleShared {
}
