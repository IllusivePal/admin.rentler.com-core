import { Component, OnInit } from '@angular/core'

@Component({
    selector: 'login-comp',
    moduleId: 'module.id',
    templateUrl: 'login.component.html',
    styleUrls: ['login.component.css']
})

export class LoginComponent {
    private isShowAuthenticationLogin: boolean;
    private isShowLogin: boolean;
    constructor() { }

    ngOnInit(): void {
        this.isShowLogin = true;
        this.isShowAuthenticationLogin = false;
        console.log("TEST IF FIRST");
    }

    showLoginForm()
    {
        this.isShowAuthenticationLogin = true;
        this.isShowLogin = false;
        console.log("TEST Showlogin form");
    }
    hideLoginForm()
    {
        this.isShowAuthenticationLogin = false;
        this.isShowLogin = true;
        console.log("TEST hideLoginForm form");

    }
}