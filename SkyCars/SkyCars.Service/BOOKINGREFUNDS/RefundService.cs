using SkyCars.Core;
using SkyCars.Core.DomainEntity.BookingRefund;
using SkyCars.Core.DomainEntity.Grid;
using SkyCars.Core.DomainEntity.User;
using SkyCars.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyCars.Service.BOOKINGREFUNDS
{
    public class RefundService : IRefundService
    {
        #region Fields

        private readonly IRepository<Refund>_RefundRepository;

        #endregion

        #region Ctor

        public RefundService(IRepository<Refund> RefundRepository)
        {
            _RefundRepository = RefundRepository;
        }

        public virtual async Task<IPagedList<Refund>> GetAllAsync(GridRequestModel objGrid)
        {
            var query = from d in _RefundRepository.Table
                        where !d.IsDelete
                        select new Refund()
                        {
                            Id = d.Id,
                            //BookingID = d.BookingID,
                            //TransactionId = d.TransactionId,
                            ChargesPaid = d.ChargesPaid,
                            RefundAmount = d.RefundAmount,
                            RefundStatus = d.RefundStatus,
                        };
            return await _RefundRepository.GetAllPagedAsync(objGrid, query);
        }

        public virtual async Task<Refund> GetByIdAsync(int Id)
        {
            return await _RefundRepository.GetByIdAsync(Id);
        }

        public virtual async Task<IList<Refund>> GetByIdsAsync(IList<int> ids)
        {
            return await _RefundRepository.GetByIdsAsync(ids);
        }

        public virtual async Task InsertAsync(Refund User, int UserId, string Username)
        {
           
            await _RefundRepository.InsertAsync(User);
        }

        public Task<bool> IsNameExist(string UserName, int Id)
        {
            throw new NotImplementedException();
        }

        

        public virtual async Task UpdateAsync(Refund User, int UserId, string Username)
        {
         
            await _RefundRepository.UpdateAsync(User);
        }

        public virtual async Task UpdateAsync(IList<Refund> UserList, int UserId, string Username)
        {
            if (UserList.Count == 0)
                throw new ArgumentNullException(nameof(UserList));

            await _RefundRepository.UpdateAsync(UserList);
        }
        #endregion
    }

}

