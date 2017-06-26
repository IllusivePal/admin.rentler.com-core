import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IdverifyComponent } from './idverify.component';

describe('IdverifyComponent', () => {
  let component: IdverifyComponent;
  let fixture: ComponentFixture<IdverifyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IdverifyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IdverifyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
