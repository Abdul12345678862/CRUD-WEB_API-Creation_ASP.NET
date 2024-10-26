using System;
using System.Collections.Generic;

namespace WebAPICRUD.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public string? Grade { get; set; }
}
