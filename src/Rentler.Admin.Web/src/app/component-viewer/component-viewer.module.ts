import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ComponentViewerComponent } from './component-viewer/component-viewer.component';
import { SharedModule } from '../shared/shared.module';

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
import { AppLoginComponent } from '../app_component/app-login/app-login.component';

//Service
import { AuthenticationGuard } from '../guard/authentication.guard';

const appRoutes: Routes =
    [
        {
            path: '', component: ComponentViewerComponent,
            children:
            [
                {
                    path: '', redirectTo: 'dashboard', pathMatch: 'prefix'
                },
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
           
        }


        /*{
            path: 'admin', redirectTo: '/admin/dashboard', pathMatch: 'full'
        },
        {
            path: 'dashboard', redirectTo: '/admin/dashboard', pathMatch: 'full'
        },*/
        /*{
            path: '', component: ComponentViewerComponent,
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
        }*/
    ];

@NgModule({
  imports: [
      CommonModule,
      SharedModule,
      RouterModule.forChild(appRoutes)
  ],
  declarations: [ComponentViewerComponent, DashboardComponent, SubscriptionComponent, ApplicationsComponent, CommunitiesComponent, ScreeningComponent, IdverifyComponent, AllUsersComponent, WatchListComponent, RolesComponent, BuildingComponent, ReportedComponent, PremierComponent, NonupgradedComponent, CategoryComponent, ProviderComponent, PaymentInvitesComponent, PaymentComponent, BankAccountsComponent, PaymentSeriesComponent, TransactionsComponent, LegalEntitiesComponent, MerchantAccountsComponent, PaymentCapsComponent, OrderComponent, PromoComponent, PageComponent, BlogComponent, CommunityComponent],
  exports: [ComponentViewerComponent]
})
export class ComponentViewerModule {
    constructor() {
        console.log("ComponentViewerModule");
    }
}
