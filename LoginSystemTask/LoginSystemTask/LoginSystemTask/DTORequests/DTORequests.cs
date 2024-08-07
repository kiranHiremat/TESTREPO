﻿namespace LoginSystemTask.DTORequests
{
    public class DTORequests
    {
        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class RegisterRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }
        }

        public class ForgotPasswordRequest
        {
            public string Email { get; set; }
        }

    }
}
