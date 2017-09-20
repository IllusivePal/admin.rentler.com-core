import { NgModule } from '@angular/core';
import { AngularSharedModule } from '../import_pages/custom_import_module';
import { CustomUsersRoutesModule, routingUsersComponents } from '../import_pages/custom_import_module';

@NgModule({
    imports: [AngularSharedModule, CustomUsersRoutesModule],
    declarations: [routingUsersComponents],
    providers:[]
})

export class UsersModule{}