using SkyCars.Core;
using SkyCars.Core.DomainEntity.BookingTracking;
using SkyCars.Core.DomainEntity.Grid;
using SkyCars.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyCars.Service.TrackingServices
{
    public class TrackingServices : ITrackingService
    {
        #region Fields

        private readonly IRepository<Tracking> _TrackingRepository;

        #endregion

        #region Ctor

        public TrackingServices(IRepository<Tracking> TrackingRepository)
        {
            _TrackingRepository =TrackingRepository;
        }

        #endregion

        #region Methods
        public virtual async Task<IPagedList<Tracking>> GetAllAsync(GridRequestModel objGrid)
        {
            var query = from d in _TrackingRepository.Table
                        where !d.IsDelete
                        select new Tracking()
                        {
                            Id = d.Id,
                            LocationName = d.LocationName,
                            
                        };

            return await _TrackingRepository.GetAllPagedAsync(objGrid, query);

            //return await _UserRepository.GetAllPagedAsync(objGrid);
        }

        public virtual async Task<Tracking> GetByIdAsync(int Id)
        {
            return await _TrackingRepository.GetByIdAsync(Id);
        }
        public virtual async Task<IList<Tracking>> GetByIdsAsync(IList<int> ids)
        {
            return await _TrackingRepository.GetByIdsAsync(ids);
        }

        public virtual async Task InsertAsync(Tracking Tracking, int UserId, string LocationName)
        {
            //Tracking.CreatedDate = System.DateTime.Now;
            await _TrackingRepository.InsertAsync(Tracking);
        }
        public virtual async Task UpdateAsync(Tracking Tracking, int UserId, string LocationName)
        {
            //Tracking.UpdatedDate = System.DateTime.Now;
            await _TrackingRepository.UpdateAsync(Tracking);
        }

        public virtual async Task UpdateAsync(IList<Tracking> UserList, int UserId, string LocationName)
        {
            if (UserList.Count == 0)
                throw new ArgumentNullException(nameof(UserList));

            await _TrackingRepository.UpdateAsync(UserList);
        }

        public virtual async Task<bool> IsNameExist(string LocationName, int Id)
        {
            var result = await _TrackingRepository.GetAllAsync(query =>
            {
                return query.Where(x => x.LocationName == LocationName && x.Id != Id);
            });
            return result.Count > 0;
        }
        #endregion
    }
}
