import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PaymentInvitesComponent } from './payment-invites.component';

describe('PaymentInvitesComponent', () => {
  let component: PaymentInvitesComponent;
  let fixture: ComponentFixture<PaymentInvitesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PaymentInvitesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PaymentInvitesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
