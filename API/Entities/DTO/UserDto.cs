﻿namespace API.Entities.DTO;

public class UserDto
{
    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public string PasswordConfirmation { get; set; }
    
    public string Email { get; set; }
}