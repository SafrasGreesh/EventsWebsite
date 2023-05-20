using AutoMapper;
using EventsWebsite.Models;
using EventsWebsite.ViewModels;

namespace EventsWebsite.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>()
                .ForMember(dst => dst.UserName, opt => opt.MapFrom(x => x.UserName));

            CreateMap<UserViewModel, ApplicationUser>();
        }
    }
}
