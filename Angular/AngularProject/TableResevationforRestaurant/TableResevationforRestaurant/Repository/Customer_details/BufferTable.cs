namespace TableResevationforRestaurant.Repository.Customer_details
{
    public class BufferTable
    {
        public string CustomerName { get; set; } = null!;

        public int MobileNumber { get; set; }
        public int NumberOfPeople { get; set; }

    public string Slot { get; set; } = null!;

    public DateTime ReserveDate { get; set; }
    }
}
