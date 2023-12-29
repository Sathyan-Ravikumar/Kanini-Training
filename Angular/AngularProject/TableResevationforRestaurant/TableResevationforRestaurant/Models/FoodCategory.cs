using System;
using System.Collections.Generic;

namespace TableResevationforRestaurant.Models;

public partial class FoodCategory
{
    public int Categoryid { get; set; }

    public string? CategoryTypes { get; set; }

    public int? Hotelid { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
