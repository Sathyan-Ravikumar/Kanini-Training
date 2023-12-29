using System;
using System.Collections.Generic;

namespace TableResevationforRestaurant.Models;

public partial class Table
{
    public int TableId { get; set; }

    public int? Hotelid { get; set; }

    public int TableNumber { get; set; }

    public int SeatingCapacity { get; set; }

    public string? Slot { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual ICollection<ReservationDetail> ReservationDetails { get; set; } = new List<ReservationDetail>();

    public virtual ICollection<TableAvailability> TableAvailabilities { get; set; } = new List<TableAvailability>();
}
