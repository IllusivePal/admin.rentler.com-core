import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ComponentViewerComponent } from './component-viewer/component-viewer.component';
import { MaterialModule } from '@angular/material';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SidenavComponent } from '../app-sidenav/sidenav/sidenav.component';
import { SubscriptionComponent } from './subscription/subscription.component';
import { ApplicationsComponent } from './applications/applications.component';
import { CommunitiesComponent } from './communities/communities.component';
import { ScreeningComponent } from './screening/screening.component';
import { IdverifyComponent } from './idverify/idverify.component';
import { AllUsersComponent } from './all-users/all-users.component';
import { WatchListComponent } from './watch-list/watch-list.component';
import { RolesComponent } from './roles/roles.component';
import { BuildingComponent } from './building/building.component';
import { ReportedComponent } from './reported/reported.component';
import { PremierComponent } from './premier/premier.component';
import { NonupgradedComponent } from './nonupgraded/nonupgraded.component';
import { CategoryComponent } from './category/category.component';
import { ProviderComponent } from './provider/provider.component';
import { PaymentInvitesComponent } from './payment-invites/payment-invites.component';
import { PaymentComponent } from './payment/payment.component';
import { BankAccountsComponent } from './bank-accounts/bank-accounts.component';
import { PaymentSeriesComponent } from './payment-series/payment-series.component';
import { TransactionsComponent } from './transactions/transactions.component';
import { LegalEntitiesComponent } from './legal-entities/legal-entities.component';
import { MerchantAccountsComponent } from './merchant-accounts/merchant-accounts.component';
import { PaymentCapsComponent } from './payment-caps/payment-caps.component';
import { OrderComponent } from './order/order.component';
import { PromoComponent } from './promo/promo.component';
import { PageComponent } from './page/page.component';
import { BlogComponent } from './blog/blog.component';
import { CommunityComponent } from './community/community.component';

/*const appRoutes: Routes = [
    {
        path: 'dashboard', component: ComponentViewerComponent,
        children: [{
            path: 'overview',
            component: DashboardComponent
          }]
    }
];*/

@NgModule({
  imports: [
      CommonModule,
      MaterialModule,
      RouterModule
  ],
  declarations: [ComponentViewerComponent, DashboardComponent, SubscriptionComponent, ApplicationsComponent, CommunitiesComponent, ScreeningComponent, IdverifyComponent, AllUsersComponent, WatchListComponent, RolesComponent, BuildingComponent, ReportedComponent, PremierComponent, NonupgradedComponent, CategoryComponent, ProviderComponent, PaymentInvitesComponent, PaymentComponent, BankAccountsComponent, PaymentSeriesComponent, TransactionsComponent, LegalEntitiesComponent, MerchantAccountsComponent, PaymentCapsComponent, OrderComponent, PromoComponent, PageComponent, BlogComponent, CommunityComponent],
  exports: [ComponentViewerComponent]
})
export class ComponentViewerModule {
    constructor() {
        console.log("ComponentViewerModule");
    }
}
