using System;
using System.Collections.Generic;

namespace Day28DatabaseFirst.Models;

public partial class MonthTran
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public decimal? Total { get; set; }

    public decimal? Gtotal { get; set; }
}
