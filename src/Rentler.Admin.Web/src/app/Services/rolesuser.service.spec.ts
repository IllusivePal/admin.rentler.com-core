import { TestBed, inject } from '@angular/core/testing';

import { RolesuserService } from './rolesuser.service';

describe('RolesuserService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RolesuserService]
    });
  });

  it('should be created', inject([RolesuserService], (service: RolesuserService) => {
    expect(service).toBeTruthy();
  }));
});
