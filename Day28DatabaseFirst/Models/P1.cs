using System;
using System.Collections.Generic;

namespace Day28DatabaseFirst.Models;

public partial class P1
{
    public string CategoryName { get; set; } = null!;

    public short Quantity { get; set; }

    public int? OrderYear { get; set; }
}
