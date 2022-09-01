using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyCars.Core.DomainEntity.BookingRefund
{
    public class Refund : BaseEntity
    {
        //public int BookingID { get; set; }

        //public int TransactionId { get; set; }

        public decimal ChargesPaid { get; set; }

        public decimal RefundAmount { get; set; }
        public bool RefundStatus { get; set; }

        public bool IsDelete { get; set; }
    }
}
