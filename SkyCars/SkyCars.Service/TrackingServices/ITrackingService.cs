using SkyCars.Core;
using SkyCars.Core.DomainEntity.BookingTracking;
using SkyCars.Core.DomainEntity.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyCars.Service.TrackingServices
{
    public interface ITrackingService
    {
        Task<IPagedList<Tracking>>GetAllAsync(GridRequestModel objGrid);
        Task<IList<Tracking>> GetByIdsAsync(IList<int> ids);
        Task<Tracking> GetByIdAsync(int Id);
        Task InsertAsync(Tracking User, int UserId, string Username);
        Task UpdateAsync(Tracking User, int UserId, string Username);
        Task UpdateAsync(IList<Tracking> UserList, int UserId, string Username);
        Task<bool> IsNameExist(string UserName, int Id);
    }
}
