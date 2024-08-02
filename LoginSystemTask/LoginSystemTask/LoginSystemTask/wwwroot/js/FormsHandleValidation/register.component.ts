import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../auth.service';

@Component({
    selector: 'app-register',
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.css']
})
export class RegisterComponent {
    username: string = '';
    password: string = '';
    confirmPassword: string = '';
    email: string = '';
    role: string = 'Normal';

    constructor(private authService: AuthService, private router: Router) { }

    onSubmit() {
        if (this.password !== this.confirmPassword) {
            alert('Passwords do not match');
            return;
        }

        this.authService.register(this.username, this.password, this.email, this.role).subscribe(
            response => {
                alert('Registration successful');
                this.router.navigate(['/login']);
            },
            error => {
                alert('Registration failed');
            }
        );
    }

    onReset() {
        this.username = '';
        this.password = '';
        this.confirmPassword = '';
        this.email = '';
        this.role = 'Normal';
    }
}
    