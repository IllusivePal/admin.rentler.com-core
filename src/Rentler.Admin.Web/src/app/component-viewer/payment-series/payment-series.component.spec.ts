import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PaymentSeriesComponent } from './payment-series.component';

describe('PaymentSeriesComponent', () => {
  let component: PaymentSeriesComponent;
  let fixture: ComponentFixture<PaymentSeriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PaymentSeriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PaymentSeriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
