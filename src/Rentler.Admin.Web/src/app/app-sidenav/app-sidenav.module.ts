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
import { UserProfilesComponent } from '../app-header/user-profiles/user-profiles.component';

//Service
//import { AuthenticationGuard } from '../guard/authentication.guard';

//Module
import { SharedModule } from '../shared/shared.module';


const appRoutes: Routes = [
    /*{
        path: 'admin', redirectTo: '/admin/home/dashboard', pathMatch: 'full'
    },*/
    /*{
        path: 'admin/home', redirectTo: '/admin/home/dashboard', pathMatch: 'full'
    }
    ,*/
    {
        path: '', component: SidenavComponent,
        children:
        [
           
            {
                path: '', redirectTo: 'home', pathMatch:'prefix'
            },
          
            {
             path: 'home', loadChildren: '../component-viewer/component-viewer.module#ComponentViewerModule'
            }
        ]
    }
  
    /*{

        path: '', component: SidenavComponent,
        children: [{
            path: 'admin', loadChildren: '../component-viewer/component-viewer.module#ComponentViewerModule'
        }]
        
    }*/
   
    /*{
        path: 'admin', component: SidenavComponent,
        children:
        [{
             path: 'home',
             component: ComponentViewerComponent,
             children:
                      [
                              {
                                  path: 'dashboard',
                                  component: DashboardComponent,
                                  canActivate: [AuthenticationGuard]
                                
                              },
                              {
                                  path: 'subscription',
                                  component: SubscriptionComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'applications',
                                  component: ApplicationsComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'community', // Apartment
                                  component: CommunitiesComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'screening',
                                  component: ScreeningComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'idverify',
                                  component: IdverifyComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'user',
                                  component: AllUsersComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'scammer',
                                  component: WatchListComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'role',
                                  component: RolesComponent,
                                  canActivate: [AuthenticationGuard]

                              },
                              {
                                  path: 'building',
                                  component: BuildingComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'reported',
                                  component: ReportedComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'premier',
                                  component: PremierComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'nonupgraded',
                                  component: NonupgradedComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'form/category',
                                  component: CategoryComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'form',
                                  component: ProviderComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'paymentinvites',
                                  component: PaymentInvitesComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'payments',
                                  component: PaymentComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'bankaccounts',
                                  component: BankAccountsComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'paymentseries',
                                  component: PaymentSeriesComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'transactions',
                                  component: TransactionsComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'legalentities',
                                  component: LegalEntitiesComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'merchantaccounts',
                                  component: MerchantAccountsComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'paymentcaps',
                                  component: PaymentCapsComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'order',
                                  component: OrderComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'promo',
                                  component: PromoComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'page',
                                  component: PageComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'blog',
                                  component: BlogComponent,
                                  canActivate: [AuthenticationGuard]
                              },
                              {
                                  path: 'cleanup/community',
                                  component: CommunityComponent,
                                  canActivate: [AuthenticationGuard]
                              }
                      ]
        }]
    }*/
];

@NgModule({
  imports: [
      CommonModule,
      SharedModule,
      AppFooterModule,
      ComponentHeaderModule,
      //ComponentViewerModule,
      RouterModule.forChild(appRoutes),
  ],
  declarations: [SidenavComponent],
  exports: [SidenavComponent]
})
export class AppSidenavModule {
    constructor() { console.log("Side Nav Module"); }
}
