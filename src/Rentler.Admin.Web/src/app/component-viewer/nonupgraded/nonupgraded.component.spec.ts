import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NonupgradedComponent } from './nonupgraded.component';

describe('NonupgradedComponent', () => {
  let component: NonupgradedComponent;
  let fixture: ComponentFixture<NonupgradedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NonupgradedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NonupgradedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
