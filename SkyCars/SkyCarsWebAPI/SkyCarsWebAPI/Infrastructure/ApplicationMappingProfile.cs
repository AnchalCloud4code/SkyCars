using AutoMapper;
using System.Linq;

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

        }
    }
}
