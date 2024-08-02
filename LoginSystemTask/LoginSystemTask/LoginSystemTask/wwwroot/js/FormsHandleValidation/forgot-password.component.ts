import { Component } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
    selector: 'app-forgot-password',
    templateUrl: './forgot-password.component.html',
    styleUrls: ['./forgot-password.component.css']
})
export class ForgotPasswordComponent {
    email: string = '';

    constructor(private authService: AuthService) { }

    onSubmit() {
        this.authService.forgotPassword(this.email).subscribe(
            response => {
                alert('Password reset link sent to your email');
            },
            error => {
                alert('Email not found');
            }
        );
    }
}
