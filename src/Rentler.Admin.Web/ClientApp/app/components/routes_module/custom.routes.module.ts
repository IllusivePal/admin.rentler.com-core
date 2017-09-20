import { NgModule } from '@angular/core';
import { RouterModule,Routes } from '@angular/router';
import { AppComponent } from '../import_pages/custom_import_pages';
import { NavMenuComponent } from '../import_pages/custom_import_pages';
import { HomeComponent } from '../import_pages/custom_import_pages';
import { FetchDataComponent } from '../import_pages/custom_import_pages';
import { CounterComponent } from '../import_pages/custom_import_pages';
import { HeaderComponent } from '../import_pages/custom_import_pages';
import { NotificationsComponent } from '../import_pages/custom_import_pages';
import { LoginComponent } from '../import_pages/custom_import_pages';
import { ErrorPageComponent } from '../import_pages/custom_import_pages';
import { DashboardComponent } from '../import_pages/custom_import_pages';
import { ReportSubscriptionComponent } from '../import_pages/custom_import_pages';

//Routes Configuration
const componentRoutes: Routes = [
    { path: '', redirectTo: 'account/login', pathMatch: 'full' },
    { path: 'account/login', component: LoginComponent },
    { path: 'home', component: HomeComponent },
    { path: 'dashboard', component: DashboardComponent },
    { path: 'dashboard/subscriptions', component: ReportSubscriptionComponent },
    { path: 'counter', component: CounterComponent },
    { path: 'fetch-data', component: FetchDataComponent },
    { path: '404', component: ErrorPageComponent },
    { path: '**', component: ErrorPageComponent }
];



@NgModule({
    imports: [RouterModule.forRoot(componentRoutes)],
    exports: [RouterModule],
})

export class CustomRoutesModule { }

export const routingComponents = [
     AppComponent
    , LoginComponent
    , HomeComponent
    , CounterComponent
    , FetchDataComponent
    , HeaderComponent
    , NotificationsComponent
    , NavMenuComponent
    , ErrorPageComponent
    , DashboardComponent
    , ReportSubscriptionComponent];