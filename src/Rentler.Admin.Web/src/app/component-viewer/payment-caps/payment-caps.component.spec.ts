import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PaymentCapsComponent } from './payment-caps.component';

describe('PaymentCapsComponent', () => {
  let component: PaymentCapsComponent;
  let fixture: ComponentFixture<PaymentCapsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PaymentCapsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PaymentCapsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
