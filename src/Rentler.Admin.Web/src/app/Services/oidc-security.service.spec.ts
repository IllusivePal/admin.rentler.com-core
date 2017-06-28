import { TestBed, inject } from '@angular/core/testing';

import { OidcSecurityService } from './oidc-security.service';

describe('OidcSecurityService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [OidcSecurityService]
    });
  });

  it('should be created', inject([OidcSecurityService], (service: OidcSecurityService) => {
    expect(service).toBeTruthy();
  }));
});
