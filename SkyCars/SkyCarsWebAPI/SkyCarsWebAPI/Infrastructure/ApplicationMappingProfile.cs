using AutoMapper;
using System.Linq;

using SkyCars.Core.DomainEntity.User;
using SkyCarsWebAPI.Models;

namespace SkyCarsWebAPI.Infrastructure
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {

            //#region :: Settings ::           
            //CreateMap<SystemMessageModel, SystemMessage>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
            //CreateMap<SystemSettingModel, Settings>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
            //#endregion

            #region :: Settings ::      
            CreateMap<UserModel, User>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
            #endregion
        }
    }
}
