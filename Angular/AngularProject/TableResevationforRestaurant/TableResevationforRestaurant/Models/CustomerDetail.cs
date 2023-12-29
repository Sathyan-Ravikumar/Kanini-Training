using System;
using System.Collections.Generic;

namespace TableResevationforRestaurant.Models;

public partial class CustomerDetail
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public int MobileNumber { get; set; }

    public int? Userid { get; set; }

    public virtual ICollection<ReservationDetail> ReservationDetails { get; set; } = new List<ReservationDetail>();

    public virtual User? User { get; set; }
}
