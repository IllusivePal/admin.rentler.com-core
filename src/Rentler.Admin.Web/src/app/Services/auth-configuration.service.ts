import { Injectable } from '@angular/core';

@Injectable()
export class AuthConfigurationService {

    // The Issuer Identifier for the OpenID Provider (which is typically obtained during Discovery) MUST exactly match the value of the iss (issuer) Claim.
    public iss = 'http://localhost:3000';

    public server = 'http://localhost:3000';

    public redirect_url = 'http://localhost:4200';

    // This is required to get the signing keys so that the signiture of the Jwt can be validated.
    public jwks_url = 'http://localhost:3000/.well-known/openid-configuration/jwks';

    public userinfo_url = 'http://localhost:3000/connect/userinfo';

    // The Client MUST validate that the aud (audience) Claim contains its client_id value registered at the Issuer identified by the iss (issuer) Claim as an audience.
    // The ID Token MUST be rejected if the ID Token does not list the Client as a valid audience, or if it contains additional audiences not trusted by the Client.
    public client_id = 'Rentler.Admin.ID';

    public response_type = 'id_token token';

    public scope = 'openid profile admin.rentler.com-core.api';

    public post_logout_redirect_uri = 'http://localhost:4200/login';

    public logoutEndSession_url = 'http://localhost:3000/connect/endsession';
 

}
