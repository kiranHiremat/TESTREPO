import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../auth.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent {
    username: string = '';
    password: string = '';

    constructor(private authService: AuthService, private router: Router) { }

    onSubmit() {
        this.authService.login(this.username, this.password).subscribe(
            response => {
                localStorage.setItem('token', response.token);
                if (response.role === 'Admin') {
                    this.router.navigate(['/admin-welcome']);
                } else {
                    this.router.navigate(['/user-welcome']);
                }
            },
            error => {
                alert('Invalid credentials');
            }
        );
    }
}
