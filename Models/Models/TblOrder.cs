﻿using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class TblOrder
{
    public string OrderId { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public decimal TotalPrice { get; set; }

    public int ItemQuantity { get; set; }

    public string UserId { get; set; } = null!;

    public virtual ICollection<TblItem> TblItems { get; set; } = new List<TblItem>();

    public virtual TblUser User { get; set; } = null!;
}
