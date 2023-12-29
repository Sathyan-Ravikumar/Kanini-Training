using System;
using System.Collections.Generic;

namespace TableResevationforRestaurant.Models;

public partial class Product
{
    public int Productid { get; set; }

    public int Categoryid { get; set; }

    public string Dishname { get; set; } = null!;

    public decimal? Cost { get; set; }

    public string? Images { get; set; }

    public virtual FoodCategory Category { get; set; } = null!;
}
