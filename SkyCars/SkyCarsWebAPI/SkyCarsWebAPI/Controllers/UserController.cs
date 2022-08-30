﻿using Microsoft.AspNetCore.Mvc;
using SkyCarsWebAPI.Extensions;
using SkyCarsWebAPI.Models.Common;
using SkyCars.Core.Domain.Grid;
using SkyCarsWebAPI.Models.Common;
using SkyCarsWebAPI.Infrastructure;
using SkyCars.Services.Users;
using SkyCarsWebAPI.Models;
using System.Threading.Tasks;
using SkyCars.Core.Domain.User;

namespace SkyCarsWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1")]
    public class UserController : BaseController
    {
        #region Fields

        private readonly IUserService _UserService;

        #endregion

        #region Ctor

        public UserController(IUserService UserService)
        {
            _UserService = UserService;
        }

        #endregion

        [HttpPost]
        [Route("[action]")]
        public async Task<ApiResponse> FiltersData(GridRequestModel objGrid)
        {
            var DocList = await _UserService.GetAllAsync(objGrid);
            return ApiResponseHelper.GenerateResponse(ApiStatusCode.Status200OK, "User", DocList.ToGrid());
        }

        [HttpGet("{id?}")]
        public async Task<ApiResponse> Get(int id)
        {
            if (id == 0)
                return ApiResponseHelper.GenerateResponse(ApiStatusCode.Status400BadRequest, "No Data Found");

            var data = await _UserService.GetByIdAsync(id);
            return ApiResponseHelper.GenerateResponse(data.GetApiResponseStatusCodeByData(),data is null ? "NoDataFound" : string.Format("User"),data);
        }
        [HttpPost]
        public async Task<ApiResponse> Post(UserModel model)
        {
            if (await _UserService.IsNameExist(model.UserName, model.Id))
                return ApiResponseHelper.GenerateResponse(ApiStatusCode.Status400BadRequest, "User name already exists.");

            if (model.Id == 0)
            {
                await _UserService.InsertAsync(model.MapTo<User>(), CurrentUserId, CurrentUserName);
            }
            else
            {
                await _UserService.UpdateAsync(model.MapTo<User>(), CurrentUserId, CurrentUserName);
            }
            return ApiResponseHelper.GenerateResponse(ApiStatusCode.Status200OK, model.Id == 0 ? "User saved successfully." : "User updated successfully.");
        }


    }
}
