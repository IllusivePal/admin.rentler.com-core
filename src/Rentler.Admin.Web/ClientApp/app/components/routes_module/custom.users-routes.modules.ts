import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UsersComponent } from '../import_pages/custom_import_pages';
import { ListScammerComponent } from '../import_pages/custom_import_pages';
import { RolesComponent } from '../import_pages/custom_import_pages';

const userAppRoutes: Routes = [
    { path: 'dashboard/users', component: UsersComponent },
    { path: 'dashboard/scammer', component: ListScammerComponent },
    { path: 'dashboard/role', component: RolesComponent}
   
];
@NgModule({
    imports: [RouterModule.forChild(userAppRoutes)],
    exports: [RouterModule]
})

export class CustomUsersRoutesModule { }

export const routingUsersComponents = [
      UsersComponent
    , ListScammerComponent
    , RolesComponent
    ];