using System;
using System.Collections.Generic;

namespace Day28DatabaseFirst.Models;

public partial class VwShowEmployee
{
    public int EmployeeId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? Country { get; set; }
}
