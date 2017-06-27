import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MerchantAccountsComponent } from './merchant-accounts.component';

describe('MerchantAccountsComponent', () => {
  let component: MerchantAccountsComponent;
  let fixture: ComponentFixture<MerchantAccountsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MerchantAccountsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MerchantAccountsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
