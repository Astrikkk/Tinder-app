﻿using Data.Entities.User;
using System;
using System.ComponentModel.DataAnnotations;

public class RegisterDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public DateTime BirthDay { get; set; }

    [Required]
    public Gender Gender { get; set; }
}