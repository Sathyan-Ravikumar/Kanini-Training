using System;
using System.Collections.Generic;

namespace TableResevationforRestaurant.Models;

public partial class ReservationDetail
{
    public int Reserveid { get; set; }

    public int? CustomerId { get; set; }

    public int? TableId { get; set; }

    public int NumberOfPeople { get; set; }

    public string Slot { get; set; } = null!;

    public DateTime ReserveDate { get; set; }

    public virtual CustomerDetail? Customer { get; set; }

    public virtual Table? Table { get; set; }
}
