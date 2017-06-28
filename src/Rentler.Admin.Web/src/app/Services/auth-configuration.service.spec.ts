import { TestBed, inject } from '@angular/core/testing';

import { AuthConfigurationService } from './auth-configuration.service';

describe('AuthConfigurationService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AuthConfigurationService]
    });
  });

  it('should be created', inject([AuthConfigurationService], (service: AuthConfigurationService) => {
    expect(service).toBeTruthy();
  }));
});
