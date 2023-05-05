using System;
using System.Collections.Generic;

namespace DBManager.Models.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? RegistrationDate { get; set; }
}
