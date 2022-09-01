using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using SkyCars.Core;
using SkyCars.Core.DomainEntity.User;
using SkyCars.Core.DomainEntity.Grid;
using SkyCars.Data;
using SkyCars.Services.Users;

namespace SkyCars.Services.Users
{
    public partial class UserService : IUserService
    {
        #region Fields

        private readonly IRepository<User1> _UserRepository;

        #endregion

        #region Ctor

        public UserService(IRepository<User1> UserRepository)
        {
            _UserRepository = UserRepository;
        }

        #endregion

        #region Methods
        public virtual async Task<IPagedList<User1>> GetAllAsync(GridRequestModel objGrid)
        {
            var query = from d in _UserRepository.Table
                        where !d.IsDelete
                        select new User1()
                        {
                            Id = d.Id,
                            Name = d.Name,
                            Email = d.Email,
                            Phone = d.Phone,
                            ProfilePhoto = d.ProfilePhoto,
                            Gender = d.Gender,
                            CityId = d.CityId,
                            CarId = d.CarId,
                            IsActive = d.IsActive,
                            RoleId = d.RoleId,
                            GoogleId = d.GoogleId,
                            FacebookId = d.FacebookId,
                             Channel = d.Channel,
                            CreatedDate = d.CreatedDate
                        };

            return await _UserRepository.GetAllPagedAsync(objGrid, query);

            //return await _UserRepository.GetAllPagedAsync(objGrid);
        }

        public virtual async Task<User1> GetByIdAsync(int Id)
        {
            return await _UserRepository.GetByIdAsync(Id);
        }
        public virtual async Task<IList<User1>> GetByIdsAsync(IList<int> ids)
        {
            return await _UserRepository.GetByIdsAsync(ids);
        }

        public virtual async Task InsertAsync(User1 User, int UserId, string Username)
        {
            User.CreatedDate = System.DateTime.Now;
            await _UserRepository.InsertAsync(User);
        }
        public virtual async Task UpdateAsync(User1 User, int UserId, string Username)
        {
            User.UpdatedDate = System.DateTime.Now;
            await _UserRepository.UpdateAsync(User);
        }

        public virtual async Task UpdateAsync(IList<User1> UserList, int UserId, string Username)
        {
            if (UserList.Count == 0)
                throw new ArgumentNullException(nameof(UserList));

            await _UserRepository.UpdateAsync(UserList);
        }

        public virtual async Task<bool> IsNameExist(string UserName, int Id)
        {
            var result = await _UserRepository.GetAllAsync(query =>
            {
                return query.Where(x => x.Name == UserName && x.Id != Id);
            });
            return result.Count > 0;
        }
        #endregion
    }
}