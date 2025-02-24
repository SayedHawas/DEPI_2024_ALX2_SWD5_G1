using System;
using System.Collections.Generic;

namespace Day28DatabaseFirst.Models;

public partial class VwShowOrder
{
    public int OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string FullName { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public short Quantity { get; set; }

    public decimal UnitPrice { get; set; }
}
