import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-admin-welcome',
    templateUrl: './admin-welcome.component.html',
    styleUrls: ['./admin-welcome.component.css']
})
export class AdminWelcomeComponent implements OnInit {
    username: string = '';

    ngOnInit(): void {
        this.username = localStorage.getItem('username') || 'Admin';
    }
}
