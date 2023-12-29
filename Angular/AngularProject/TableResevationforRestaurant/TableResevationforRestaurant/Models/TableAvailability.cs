using System;
using System.Collections.Generic;

namespace TableResevationforRestaurant.Models;

public partial class TableAvailability
{
    public int? TableId { get; set; }

    public DateTime? AvailableDate { get; set; }

    public string? LunchSlot { get; set; }

    public string? DinnerSlot { get; set; }

    public int AvailabilityId { get; set; }

    public virtual Table? Table { get; set; }
}
