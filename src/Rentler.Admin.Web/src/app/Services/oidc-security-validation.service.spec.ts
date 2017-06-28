import { TestBed, inject } from '@angular/core/testing';

import { OidcSecurityValidationService } from './oidc-security-validation.service';

describe('OidcSecurityValidationService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [OidcSecurityValidationService]
    });
  });

  it('should be created', inject([OidcSecurityValidationService], (service: OidcSecurityValidationService) => {
    expect(service).toBeTruthy();
  }));
});
