using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyCars.Core.DomainEntity.BookingTracking
{
    public class Tracking: BaseEntity
    {
        //public int BookingId { get; set; }
        public string LocationName { get; set; }

        public bool IsDelete { get; set; }
    }
}
