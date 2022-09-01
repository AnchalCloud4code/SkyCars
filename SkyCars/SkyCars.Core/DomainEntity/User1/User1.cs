using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyCars.Core.DomainEntity.User
{
    public class User1 : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        public string ProfilePhoto { get; set; }
        public string Gender { get; set; }
       
        public string CityId { get; set; }

        public string CarId { get; set; }
        public bool IsActive { get; set; }
        public string RoleId { get; set; }
        public string  GoogleId { get; set; }
        public string FacebookId { get; set; }  
        public string Channel { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
