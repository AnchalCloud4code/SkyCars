using AutoMapper;
using System.Linq;

using SkyCars.Core.DomainEntity.User;
using SkyCarsWebAPI.Models;
using SkyCars.Core.DomainEntity.BookingRefund;
using SkyCars.Core.DomainEntity.BookingTracking;

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
            CreateMap<UserModel, User1>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<RefundBookingsModel, Refund>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<TrackingBookingModel, Tracking>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
            #endregion
        }
    }
}
