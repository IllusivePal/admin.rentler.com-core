import { Injectable, OnInit } from '@angular/core';
import { ToastyService, ToastyConfig, ToastyComponent, ToastOptions, ToastData } from 'ng2-toasty';
import { ToasttypeConfiguration } from '../CommonConstants/toasttype-configuration.constant';


@Injectable()
export class ToastService {
    private ToastType: ToasttypeConfiguration;
    constructor(private _toastService: ToastyService) {
        this.ToastType = new ToasttypeConfiguration();
    }

    toastMessage(title: string, msg: string, showClose: boolean, timeOut: number, theme: string, toastType: string)
    {
        var options: ToastOptions = {
            title: title,
            msg: msg,
            showClose: showClose,
            timeout: timeOut,
            theme: theme
        }
        if (toastType == this.ToastType.info)
            this._toastService.info(options);

        if (toastType == this.ToastType.error)
            this._toastService.error(options);

        if (toastType == this.ToastType.success)
            this._toastService.success(options);

        if (toastType == this.ToastType.wait)
            this._toastService.wait(options);

        if (toastType == this.ToastType.warning)
            this._toastService.warning(options);
        

    }

}
