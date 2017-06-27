import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidenavComponent } from './sidenav/sidenav.component';
import { MaterialModule } from '@angular/material';
import { AppFooterModule } from '../app-footer/app-footer.module';
import { ComponentHeaderModule } from '../component-header/component-header.module';
import { ComponentViewerModule } from '../component-viewer/component-viewer.module';
import { Routes, RouterModule } from '@angular/router';
import { FlexLayoutModule } from '@angular/flex-layout';

//Components
import { DashboardComponent } from '../component-viewer/dashboard/dashboard.component';
import { SubscriptionComponent } from '../component-viewer/subscription/subscription.component';
import { ApplicationsComponent } from '../component-viewer/applications/applications.component';
import { ComponentViewerComponent } from '../component-viewer/component-viewer/component-viewer.component';
import { CommunitiesComponent } from '../component-viewer/communities/communities.component';
import { ScreeningComponent } from '../component-viewer/screening/screening.component';
import { IdverifyComponent } from '../component-viewer/idverify/idverify.component';
import { AllUsersComponent } from '../component-viewer/all-users/all-users.component';
import { WatchListComponent } from '../component-viewer/watch-list/watch-list.component';
import { RolesComponent } from '../component-viewer/roles/roles.component';
import { BuildingComponent } from '../component-viewer/building/building.component';
import { ReportedComponent } from '../component-viewer/reported/reported.component';
import { PremierComponent } from '../component-viewer/premier/premier.component';
import { NonupgradedComponent } from '../component-viewer/nonupgraded/nonupgraded.component';
import { CategoryComponent } from '../component-viewer/category/category.component';
import { ProviderComponent } from '../component-viewer/provider/provider.component';
import { PaymentInvitesComponent } from '../component-viewer/payment-invites/payment-invites.component';
import { PaymentComponent } from '../component-viewer/payment/payment.component';
import { BankAccountsComponent } from '../component-viewer/bank-accounts/bank-accounts.component';
import { PaymentSeriesComponent } from '../component-viewer/payment-series/payment-series.component';
import { TransactionsComponent } from '../component-viewer/transactions/transactions.component';
import { PaymentCapsComponent } from '../component-viewer/payment-caps/payment-caps.component';
import { LegalEntitiesComponent } from '../component-viewer/legal-entities/legal-entities.component';
import { MerchantAccountsComponent } from '../component-viewer/merchant-accounts/merchant-accounts.component';
import { OrderComponent } from '../component-viewer/order/order.component';
import { PromoComponent } from '../component-viewer/promo/promo.component';
import { PageComponent } from '../component-viewer/page/page.component';
import { BlogComponent } from '../component-viewer/blog/blog.component';
import { CommunityComponent } from '../component-viewer/community/community.component';



const appRoutes: Routes = [
    {
        path: 'admin', redirectTo: '/admin/home/dashboard', pathMatch:'full'
    },
    {
        path: 'admin/home', redirectTo: '/admin/home/dashboard', pathMatch: 'full'
    }
    ,
    {
        path: 'admin', component: SidenavComponent,
        children:
        [{
             path: 'home',
             component: ComponentViewerComponent,
             children:
                      [
                              {
                                  path: 'dashboard',
                                  component: DashboardComponent
                              },
                              {
                                  path: 'subscription',
                                  component: SubscriptionComponent
                              },
                              {
                                  path: 'applications',
                                  component: ApplicationsComponent
                              },
                              {
                                  path: 'community', // Apartment
                                  component: CommunitiesComponent
                              },
                              {
                                  path: 'screening',
                                  component: ScreeningComponent
                              },
                              {
                                  path: 'idverify',
                                  component: IdverifyComponent
                              },
                              {
                                  path: 'user',
                                  component: AllUsersComponent
                              },
                              {
                                  path: 'scammer',
                                  component: WatchListComponent
                              },
                              {
                                  path: 'role',
                                  component: RolesComponent

                              },
                              {
                                  path: 'building',
                                  component: BuildingComponent
                              },
                              {
                                  path: 'reported',
                                  component: ReportedComponent
                              },
                              {
                                  path: 'premier',
                                  component: PremierComponent
                              },
                              {
                                  path: 'nonupgraded',
                                  component: NonupgradedComponent
                              },
                              {
                                  path: 'form/category',
                                  component: CategoryComponent
                              },
                              {
                                  path: 'form',
                                  component: ProviderComponent
                              },
                              {
                                  path: 'paymentinvites',
                                  component: PaymentInvitesComponent
                              },
                              {
                                  path: 'payments',
                                  component: PaymentComponent
                              },
                              {
                                  path: 'bankaccounts',
                                  component: BankAccountsComponent
                              },
                              {
                                  path: 'paymentseries',
                                  component: PaymentSeriesComponent
                              },
                              {
                                  path: 'transactions',
                                  component: TransactionsComponent
                              },
                              {
                                  path: 'legalentities',
                                  component: LegalEntitiesComponent
                              },
                              {
                                  path: 'merchantaccounts',
                                  component: MerchantAccountsComponent
                              },
                              {
                                  path: 'paymentcaps',
                                  component: PaymentCapsComponent
                              },
                              {
                                  path: 'order',
                                  component: OrderComponent
                              },
                              {
                                  path: 'promo',
                                  component: PromoComponent
                              },
                              {
                                  path: 'page',
                                  component: PageComponent
                              },
                              {
                                  path: 'blog',
                                  component: BlogComponent
                              },
                              {
                                  path: 'cleanup/community',
                                  component: CommunityComponent
                              }
                      ]
        }]
    }
];

@NgModule({
  imports: [
      CommonModule,
      MaterialModule,
      AppFooterModule,
      ComponentHeaderModule,
      ComponentViewerModule,
      RouterModule.forChild(appRoutes),
      FlexLayoutModule
  ],
  declarations: [SidenavComponent],
  exports: [SidenavComponent]
})
export class AppSidenavModule {
    constructor() { console.log("Side Nav Module"); }
}
