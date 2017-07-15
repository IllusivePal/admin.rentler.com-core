webpackJsonp([1],{

/***/ "../../../../../src/app/app-sidenav/app-sidenav.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
Object.defineProperty(__webpack_exports__, "__esModule", { value: true });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_common__ = __webpack_require__("../../../common/@angular/common.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__sidenav_sidenav_component__ = __webpack_require__("../../../../../src/app/app-sidenav/sidenav/sidenav.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__app_footer_app_footer_module__ = __webpack_require__("../../../../../src/app/app-footer/app-footer.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__component_header_component_header_module__ = __webpack_require__("../../../../../src/app/component-header/component-header.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__shared_shared_module__ = __webpack_require__("../../../../../src/app/shared/shared.module.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppSidenavModule", function() { return AppSidenavModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};






//Service
//import { AuthenticationGuard } from '../guard/authentication.guard';
//Module

var appRoutes = [
    /*{
        path: 'admin', redirectTo: '/admin/home/dashboard', pathMatch: 'full'
    },*/
    /*{
        path: 'admin/home', redirectTo: '/admin/home/dashboard', pathMatch: 'full'
    }
    ,*/
    {
        path: '', component: __WEBPACK_IMPORTED_MODULE_2__sidenav_sidenav_component__["a" /* SidenavComponent */],
        children: [
            {
                path: '', redirectTo: 'home', pathMatch: 'prefix'
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
var AppSidenavModule = (function () {
    function AppSidenavModule() {
        console.log("Side Nav Module");
    }
    return AppSidenavModule;
}());
AppSidenavModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["NgModule"])({
        imports: [
            __WEBPACK_IMPORTED_MODULE_1__angular_common__["a" /* CommonModule */],
            __WEBPACK_IMPORTED_MODULE_6__shared_shared_module__["a" /* SharedModule */],
            __WEBPACK_IMPORTED_MODULE_3__app_footer_app_footer_module__["a" /* AppFooterModule */],
            __WEBPACK_IMPORTED_MODULE_4__component_header_component_header_module__["a" /* ComponentHeaderModule */],
            //ComponentViewerModule,
            __WEBPACK_IMPORTED_MODULE_5__angular_router__["a" /* RouterModule */].forChild(appRoutes),
        ],
        declarations: [__WEBPACK_IMPORTED_MODULE_2__sidenav_sidenav_component__["a" /* SidenavComponent */]],
        exports: [__WEBPACK_IMPORTED_MODULE_2__sidenav_sidenav_component__["a" /* SidenavComponent */]]
    }),
    __metadata("design:paramtypes", [])
], AppSidenavModule);

//# sourceMappingURL=app-sidenav.module.js.map

/***/ }),

/***/ "../../../../../src/app/app-sidenav/sidenav/sidenav.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "\r\n.docs-component-viewer-sidenav-container {\r\n  width: 100%;\r\n}\r\n\r\n\r\n\r\n.docs-component-viewer-sidenav, .docs-component-viewer-sidenav.mat-sidenav-opened {\r\n  box-shadow: 3px 0 6px rgba(0,0,0,.24);\r\n}\r\n\r\n\r\n.docs-component-viewer-sidenav {\r\n  padding-bottom: 72px;\r\n  width: 280px;\r\n  bottom: 0;\r\n  overflow: auto;\r\n  height: 100%;\r\n}\r\n\r\n\r\n  .docs-component-viewer-sidenav h3 {\r\n    border: none;\r\n    font-size: 10px;\r\n    letter-spacing: 1px;\r\n    line-height: 24px;\r\n    text-transform: uppercase;\r\n    font-weight: 400;\r\n    margin: 0;\r\n    padding: 0 16px;\r\n    height:65px;\r\n  }\r\n  .docs-component-viewer-sidenav h3 {\r\n    background: rgba(27, 27, 27, 0.85);\r\n    color: hsla(0,0%,100%,.87);\r\n  }\r\n\r\n  .docs-component-viewer-sidenav ul {\r\n    list-style-type: none;\r\n    margin: 0;\r\n    padding: 0;\r\n  }\r\n  .docs-component-viewer-sidenav li {\r\n    border-bottom-width: 1px;\r\n    border-bottom-style: solid;\r\n    margin: 0;\r\n    padding: 0;\r\n  }\r\n  .docs-component-viewer-sidenav li {\r\n    border-color: rgba(0,0,0,.06);\r\n    color: rgba(0,0,0,.54);\r\n  }\r\n  .docs-component-viewer-sidenav li > a {\r\n    box-sizing: border-box;\r\n    display: block;\r\n    font-size: 14px;\r\n    font-weight: 400;\r\n    line-height: 47px;\r\n    text-decoration: none;\r\n    transition: all .3s;\r\n    padding: 0 60px;\r\n    position: relative;\r\n  }\r\n  .docs-component-viewer-sidenav li > a {\r\n    color: rgba(0,0,0,.54);\r\n  }\r\n  .docs-component-viewer-sidenav li > a.docs-component-viewer-sidenav-item-selected {\r\n    font-weight: 600;\r\n    background-color: rgba(224, 224, 224, 0.68);\r\n    color: #3f51b5;\r\n  }\r\n  .docs-component-viewer-sidenav li>a:hover {\r\n    background-color: rgba(0,0,0,.04);\r\n    color: #3f51b5;\r\n  }\r\n.mt-icn {\r\n  position: absolute;\r\n  left: 0;\r\n  right: 0;\r\n  top: 10px;\r\n  bottom: 0;\r\n  padding: 0 28px;\r\n}\r\n\r\n.docs-component-sidenav-content {\r\n  min-height: 100%;\r\n  display: -webkit-box;\r\n  display: -ms-flexbox;\r\n  display: flex;\r\n  -webkit-box-orient: vertical;\r\n  -webkit-box-direction: normal;\r\n  -ms-flex-direction: column;\r\n  flex-direction: column;\r\n}\r\n\r\n/* Temporary Added*/\r\n.component-page-header{\r\n  display: -webkit-box;\r\n  display: -ms-flexbox;\r\n  display: flex;\r\n  -webkit-box-align: center;\r\n  -ms-flex-align: center;\r\n  align-items: center;\r\n}\r\n\r\n.docs-primary-header {\r\n  background: #3f3b46;\r\n  height: 65px;\r\n}\r\n\r\n.docs-primary-header {\r\n  padding-left: 20px;\r\n}\r\n\r\n\r\n/*END*/\r\n\r\n\r\n\r\n\r\n\r\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/app-sidenav/sidenav/sidenav.component.html":
/***/ (function(module, exports) {

module.exports = "<md-sidenav-container class=\"docs-component-viewer-sidenav-container\">\r\n  <!--<div class=\"mat-sidenav-backdrop\"></div>-->\r\n  <!--<div tabindex=\"-1\" class=\"cdk-visually-hidden cdk-focus-trap-anchor\"></div>\r\n  <md-sidenav mode=\"side\" opened=\"true\" class=\"docs-component-viewer-sidenav mat-sidenav mat-sidenav-side mat-sidenav-opened\" tabindex=\"-1\">\r\n    <nav>\r\n      sdasdasda\r\n    </nav>\r\n  </md-sidenav>\r\n  <div tabindex=\"-1\" class=\"cdk-visually-hidden cdk-focus-trap-anchor\"></div>\r\n  <div cdk-scrollable=\"\" class=\"mat-sidenav-content\" style=\"margin-left: 240px; margin-right: 0px; transform: translate3d(0px, 0px, 0px);\">\r\n      <div class=\"docs-component-sidenav-content\">\r\n        TEESTTTTT\r\n      </div>\r\n  </div>-->\r\n  <md-sidenav #sidenav mode=\"{{mode}}\"\r\n              [opened]=\"isOpen\" class=\"docs-component-viewer-sidenav\">\r\n    <ng-content select=\"[sidenav-content]\"></ng-content>\r\n    <nav>\r\n      <!--<h3></h3>-->\r\n      <ul>\r\n        <li>\r\n            <a [routerLink]=\"['/admin/home/dashboard']\" routerLinkActive=\"docs-component-viewer-sidenav-item-selected\" >\r\n             <span><md-icon class=\"mt-icn\">dashboard</md-icon></span> Dashboard\r\n            </a>\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n          <a [routerLink]=\"['/admin/home/subscription']\" routerLinkActive=\"docs-component-viewer-sidenav-item-selected\">\r\n            <span><md-icon class=\"mt-icn\">group</md-icon></span>Subscription\r\n          </a>\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n            <a [routerLink]=\"\" [mdMenuTriggerFor]=\"menu\">\r\n              <span><md-icon class=\"mt-icn\">account_box</md-icon></span>Users\r\n            </a>\r\n            <md-menu #menu=\"mdMenu\" xPosition=\"after\" [overlapTrigger]=\"false\">\r\n               <a [routerLink]=\"['/admin/home/user']\" md-menu-item ><md-icon>list</md-icon><span>All Users</span></a>\r\n               <a [routerLink]=\"['/admin/home/scammer']\" md-menu-item ><md-icon>not_interested</md-icon><span>Watch List</span></a>\r\n               <a [routerLink]=\"['/admin/home/role']\" md-menu-item ><md-icon>remove_red_eye</md-icon><span>Roles</span></a>\r\n            </md-menu>\r\n         \r\n        </li>\r\n      </ul>\r\n     \r\n      <ul>\r\n        <li>\r\n          <a [routerLink]=\"['/admin/home/applications']\" routerLinkActive=\"docs-component-viewer-sidenav-item-selected\">\r\n            <span><md-icon class=\"mt-icn\">folder_shared</md-icon></span>Applications\r\n          </a>\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n          <a [routerLink]=\"['/admin/home/community']\" routerLinkActive=\"docs-component-viewer-sidenav-item-selected\">\r\n            <span><md-icon class=\"mt-icn\">account_balance</md-icon></span>Communities\r\n          </a>\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n\r\n          <a [routerLink]=\"\" [mdMenuTriggerFor]=\"menubuilding\">\r\n            <span><md-icon class=\"mt-icn\">account_balance</md-icon></span>Buildings\r\n          </a>\r\n          <md-menu #menubuilding=\"mdMenu\" xPosition=\"after\" [overlapTrigger]=\"false\">\r\n            <a [routerLink]=\"['/admin/home/building']\" md-menu-item ><md-icon>list</md-icon><span>All Buildings</span></a>\r\n            <a [routerLink]=\"['/admin/home/reported']\" md-menu-item ><md-icon>flag</md-icon><span>Reported</span></a>\r\n            <a [routerLink]=\"['/admin/home/premier']\" md-menu-item ><md-icon>redeem</md-icon><span>Premier</span></a>\r\n            <a [routerLink]=\"['/admin/home/nonupgraded']\" md-menu-item ><md-icon>flag</md-icon><span>Non Upgraded apt.</span></a>\r\n\r\n          </md-menu>\r\n\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n          <a [routerLink]=\"\" [mdMenuTriggerFor]=\"menuforms\">\r\n            <span><md-icon class=\"mt-icn\">insert_drive_file</md-icon></span>Forms\r\n          </a>\r\n          <md-menu #menuforms=\"mdMenu\" xPosition=\"after\" [overlapTrigger]=\"false\">\r\n            <a [routerLink]=\"['/admin/home/form/category']\" md-menu-item ><md-icon>folder_open</md-icon><span>Categories</span></a>\r\n            <a [routerLink]=\"['/admin/home/form']\" md-menu-item ><md-icon>assignment</md-icon><span>Providers</span></a>\r\n            \r\n          </md-menu>\r\n\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n          <a [routerLink]=\"['/admin/home/screening']\" routerLinkActive=\"docs-component-viewer-sidenav-item-selected\">\r\n            <span><md-icon class=\"mt-icn\">card_membership</md-icon></span>Credit / Background\r\n          </a>\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n          <a [routerLink]=\"['/admin/home/idverify']\" routerLinkActive=\"docs-component-viewer-sidenav-item-selected\">\r\n            <span><md-icon class=\"mt-icn\">perm_identity</md-icon></span>ID Verify\r\n          </a>\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n\r\n\r\n          <a [routerLink]=\"\" [mdMenuTriggerFor]=\"menupayments\">\r\n            <span><md-icon class=\"mt-icn\">attach_money</md-icon></span>Payments\r\n          </a>\r\n          <md-menu #menupayments=\"mdMenu\" yPosition=\"below\" [overlapTrigger]=\"false\">\r\n            <a [routerLink]=\"['/admin/home/paymentinvites']\" md-menu-item><md-icon>credit_card</md-icon><span>Payment Invites</span></a>\r\n            <a [routerLink]=\"['/admin/home/payments']\" md-menu-item><md-icon>perm_contact_calendar</md-icon><span>Recurring Payments</span></a>\r\n            <a [routerLink]=\"['/admin/home/bankaccounts']\" md-menu-item><md-icon>monetization_on</md-icon><span>Bank Accounts</span></a>\r\n            <a [routerLink]=\"['/admin/home/paymentseries']\" md-menu-item><md-icon>monetization_on</md-icon><span>Payment Series</span></a>\r\n            <a [routerLink]=\"['/admin/home/transactions']\" md-menu-item><md-icon>monetization_on</md-icon><span>Transactions</span></a>\r\n            <a [routerLink]=\"['/admin/home/legalentities']\" md-menu-item><md-icon>monetization_on</md-icon><span>Legal Entities</span></a>\r\n            <a [routerLink]=\"['/admin/home/merchantaccounts']\" md-menu-item><md-icon>monetization_on</md-icon><span>Merchant Accounts</span></a>\r\n            <a [routerLink]=\"['/admin/home/paymentcaps']\" md-menu-item><md-icon>monetization_on</md-icon><span>Payment Caps</span></a>\r\n          </md-menu>\r\n\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n          <a  [routerLink]=\"\" [mdMenuTriggerFor]=\"menusales\">\r\n            <span><md-icon class=\"mt-icn\">add_shopping_cart</md-icon></span>Sales\r\n          </a>\r\n          <md-menu #menusales=\"mdMenu\" yPosition=\"below\" [overlapTrigger]=\"false\">\r\n            <a [routerLink]=\"['/admin/home/order']\" md-menu-item><md-icon>shopping_cart</md-icon><span>Orders</span></a>\r\n            <a [routerLink]=\"['/admin/home/promo']\" md-menu-item><md-icon>line_weight</md-icon><span>Promo Codes</span></a>\r\n          </md-menu>\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n          <a [routerLink]=\"\" [mdMenuTriggerFor]=\"menucontent\">\r\n            <span><md-icon class=\"mt-icn\">font_download</md-icon></span>Content\r\n          </a>\r\n          <md-menu #menucontent=\"mdMenu\" yPosition=\"below\" [overlapTrigger]=\"false\">\r\n            <a [routerLink]=\"['/admin/home/page']\" md-menu-item><md-icon>insert_drive_file</md-icon><span>Pages</span></a>\r\n            <a [routerLink]=\"['/admin/home/blog']\" md-menu-item><md-icon>comment</md-icon><span>Blogs</span></a>\r\n          </md-menu>\r\n        </li>\r\n      </ul>\r\n      <ul>\r\n        <li>\r\n          <a [routerLink]=\"\" [mdMenuTriggerFor]=\"menucleanup\">\r\n            <span><md-icon class=\"mt-icn\">add_alert</md-icon></span>Cleanup\r\n          </a>\r\n          <md-menu #menucleanup=\"mdMenu\" yPosition=\"below\" [overlapTrigger]=\"false\">\r\n            <a [routerLink]=\"['/admin/home/cleanup/community']\" md-menu-item><md-icon>people</md-icon><span>Communities</span></a>\r\n          \r\n          </md-menu>\r\n        </li>\r\n        <li>\r\n          <a [routerLink]=\"['/login']\">\r\n            <span><md-icon class=\"mt-icn\">account_circle</md-icon></span>Login\r\n          </a>\r\n        </li>\r\n      </ul>\r\n    </nav>\r\n   \r\n  </md-sidenav>\r\n  \r\n  <div class=\"docs-component-sidenav-content\">\r\n      <div class=\"docs-primary-header component-page-header\">\r\n        <div class=\"main-content\"\r\n             (click)=\"toggleSideNav()\" fxLayout=\"row\">\r\n          <button md-button\r\n                  style=\"margin-bottom:50px;\"\r\n                  *ngIf=\"media.isActive('xs')\">\r\n            <!--{{ isOpen ? 'Close' : 'Open' }} SideNav!-->\r\n            SideNav\r\n          </button>\r\n\r\n          <ng-content select=\"[main-content]\"></ng-content>\r\n\r\n\r\n        </div>\r\n          <app-component-header></app-component-header>\r\n      </div>\r\n      <!--<app-component-viewer></app-component-viewer>-->\r\n      <!--<app-component-viewer></app-component-viewer>-->\r\n      <router-outlet></router-outlet>\r\n      <app-footer></app-footer>\r\n\r\n    </div>\r\n  \r\n</md-sidenav-container>\r\n<!--<app-footer></app-footer>-->"

/***/ }),

/***/ "../../../../../src/app/app-sidenav/sidenav/sidenav.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_add_operator_filter__ = __webpack_require__("../../../../rxjs/add/operator/filter.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_add_operator_filter___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_1_rxjs_add_operator_filter__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__angular_flex_layout__ = __webpack_require__("../../../flex-layout/index.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return SidenavComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var SidenavComponent = (function () {
    function SidenavComponent(media) {
        var _this = this;
        this.media = media;
        this.isOpen = true;
        this.mode = "side";
        console.log("This is side nav");
        console.log("this.mode", this.mode);
        console.log("Is Open", this.isOpen);
        console.log("change", this.mediaChange);
        console.log("media", media);
        this._subscription = media.subscribe(function (change) {
            _this.isOpen = (change.mqAlias !== 'xs');
            _this.mediaChange = change;
            console.log("is open when refresh", _this.isOpen);
            console.log("Subscription", _this._subscription);
            (change.mqAlias !== 'xs') ? _this.mode = "side" : _this.mode = "over";
        });
    }
    SidenavComponent.prototype.toggleSideNav = function () {
        console.log("watch mode", this.isOpen);
        this.isOpen = !this.isOpen;
        this.mode = "over";
    };
    SidenavComponent.prototype.ngOnDestroy = function () { console.log("TEST"); /*this._subscription.unsubscribe(); console.log("Destroy");*/ };
    return SidenavComponent;
}());
SidenavComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
        selector: 'app-sidenav',
        template: __webpack_require__("../../../../../src/app/app-sidenav/sidenav/sidenav.component.html"),
        styles: [__webpack_require__("../../../../../src/app/app-sidenav/sidenav/sidenav.component.css")]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_2__angular_flex_layout__["b" /* ObservableMedia */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__angular_flex_layout__["b" /* ObservableMedia */]) === "function" && _a || Object])
], SidenavComponent);

var _a;
//# sourceMappingURL=sidenav.component.js.map

/***/ }),

/***/ "../../../../../src/app/component-header/component-header.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_common__ = __webpack_require__("../../../common/@angular/common.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__component_header_component_header_component__ = __webpack_require__("../../../../../src/app/component-header/component-header/component-header.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__shared_shared_module__ = __webpack_require__("../../../../../src/app/shared/shared.module.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ComponentHeaderModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};




var ComponentHeaderModule = (function () {
    function ComponentHeaderModule() {
    }
    return ComponentHeaderModule;
}());
ComponentHeaderModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["NgModule"])({
        imports: [
            __WEBPACK_IMPORTED_MODULE_1__angular_common__["a" /* CommonModule */],
            __WEBPACK_IMPORTED_MODULE_3__shared_shared_module__["a" /* SharedModule */]
        ],
        declarations: [__WEBPACK_IMPORTED_MODULE_2__component_header_component_header_component__["a" /* ComponentHeaderComponent */]],
        exports: [__WEBPACK_IMPORTED_MODULE_2__component_header_component_header_component__["a" /* ComponentHeaderComponent */]]
    })
], ComponentHeaderModule);

//# sourceMappingURL=component-header.module.js.map

/***/ }),

/***/ "../../../../../src/app/component-header/component-header/component-header.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "/*\r\n.component-page-header{\r\n  display: -webkit-box;\r\n  display: -ms-flexbox;\r\n  display: flex;\r\n  -webkit-box-align: center;\r\n  -ms-flex-align: center;\r\n  align-items: center;\r\n}\r\n\r\n.docs-primary-header {\r\n  background: #3f3b46;\r\n  height: 65px;\r\n}\r\n\r\n.docs-primary-header {\r\n  padding-left: 20px;\r\n}\r\n.docs-primary-header h1 {\r\n    color: rgba(255, 255, 255, 0.87);\r\n    font-size: 16px;\r\n    font-weight: 100;\r\n    margin: 0;\r\n    padding: 10px;\r\n    text-transform:uppercase;\r\n}\r\n\r\n  */\r\nh1 {\r\n  color: rgba(255, 255, 255, 0.87);\r\n  font-size: 16px;\r\n  font-weight: 100;\r\n  margin: 0;\r\n  padding: 10px;\r\n  text-transform: uppercase;\r\n}\r\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/component-header/component-header/component-header.component.html":
/***/ (function(module, exports) {

module.exports = "<!--<div class=\"docs-primary-header component-page-header\">-->\r\n  <!--<button md-button class=\"sidenav-toggle\">\r\n\r\n      <md-icon>menu</md-icon>\r\n  </button>-->\r\n  <h1>Dashboard </h1>\r\n\r\n<!--</div>-->"

/***/ }),

/***/ "../../../../../src/app/component-header/component-header/component-header.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ComponentHeaderComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var ComponentHeaderComponent = (function () {
    function ComponentHeaderComponent() {
    }
    ComponentHeaderComponent.prototype.ngOnInit = function () {
    };
    return ComponentHeaderComponent;
}());
ComponentHeaderComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
        selector: 'app-component-header',
        template: __webpack_require__("../../../../../src/app/component-header/component-header/component-header.component.html"),
        styles: [__webpack_require__("../../../../../src/app/component-header/component-header/component-header.component.css")]
    }),
    __metadata("design:paramtypes", [])
], ComponentHeaderComponent);

//# sourceMappingURL=component-header.component.js.map

/***/ })

});
//# sourceMappingURL=1.chunk.js.map