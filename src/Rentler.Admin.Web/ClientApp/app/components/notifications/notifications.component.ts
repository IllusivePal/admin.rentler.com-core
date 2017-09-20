import { Component,OnInit } from '@angular/core';

@Component({
    selector: 'notification-comp',
    moduleId: 'module.id',
    templateUrl: 'notifications.component.html',
    styleUrls: ['notifications.component.css']
})

export class NotificationsComponent {

    showNotComponent: boolean = false;
    constructor() { }

    ngOnInit(): void {

    }
}