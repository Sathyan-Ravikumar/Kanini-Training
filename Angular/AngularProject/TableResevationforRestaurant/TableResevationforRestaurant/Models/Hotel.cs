using System;
using System.Collections.Generic;

namespace TableResevationforRestaurant.Models;

public partial class Hotel
{
    public int Hotelid { get; set; }

    public string HotelName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int Hotelnumber { get; set; }

    public string? Instalink { get; set; }

    public string? Facebook { get; set; }

    public string? Youtube { get; set; }

    public virtual ICollection<FoodCategory> FoodCategories { get; set; } = new List<FoodCategory>();

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
