import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-user-welcome',
    templateUrl: './user-welcome.component.html',
    styleUrls: ['./user-welcome.component.css']
})
export class UserWelcomeComponent implements OnInit {
    username: string = '';

    ngOnInit(): void {
        this.username = localStorage.getItem('username') || 'User';
    }
}
