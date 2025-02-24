using System;
using System.Collections.Generic;

namespace Day28DatabaseFirst.Models;

public partial class DayTran
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public decimal? Total { get; set; }

    public bool? IsActive { get; set; }
}
