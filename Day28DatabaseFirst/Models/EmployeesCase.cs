using System;
using System.Collections.Generic;

namespace Day28DatabaseFirst.Models;

public partial class EmployeesCase
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Salary { get; set; }

    public bool? Attend { get; set; }
}
