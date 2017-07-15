import { XHRBackend } from '@angular/http';
import { AngularReduxRequest } from '../options/angular-redux-request.options';
import { HttpService } from '../Services/http.service';
import { ProgressbarService } from '../Services/progressbar.service';
function httpServiceFactory(backend: XHRBackend, options: AngularReduxRequest, loaderService: ProgressbarService) {
    return new HttpService(backend, options, loaderService);
}
export {
    httpServiceFactory
};
