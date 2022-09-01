using SkyCars.Core;
using SkyCars.Core.DomainEntity.BookingRefund;
using SkyCars.Core.DomainEntity.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyCars.Service.BOOKINGREFUNDS
{
   
        public partial interface IRefundService
        {
            #region Methods
            Task<IPagedList<Refund>> GetAllAsync(GridRequestModel objGrid);
            Task<IList<Refund>> GetByIdsAsync(IList<int> ids);
            Task<Refund> GetByIdAsync(int Id);
            Task InsertAsync(Refund User, int UserId, string Username);
            Task UpdateAsync(Refund User, int UserId, string Username);
            Task UpdateAsync(IList<Refund> UserList, int UserId, string Username);
            Task<bool> IsNameExist(string UserName, int Id);
            #endregion
        }
    
}
