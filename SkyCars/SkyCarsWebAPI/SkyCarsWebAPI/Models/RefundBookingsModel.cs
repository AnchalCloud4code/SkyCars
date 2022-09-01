namespace SkyCarsWebAPI.Models
{
    public class RefundBookingsModel: BaseModel
    {
        //public int BookingID { get; set; }
        //public int TransactionId { get; set; }

        public decimal ChargesPaid { get; set; }

        public decimal RefundAmount { get; set; }
        public bool RefundStatus { get; set; }

        public bool IsDelete { get; set; }
    }
}
