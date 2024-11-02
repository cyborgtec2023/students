using System;
using System.Collections.Generic;

namespace StudentApi.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Course { get; set; } = null!;
}
