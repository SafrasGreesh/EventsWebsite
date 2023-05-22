using EventsWebsite.Models;
using EventsWebsite.Services;
//using EventsWebsite.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventsWebsites.New
{
    public interface IUserService
    {
        IEnumerable<ApplicationUser> GetAll();
        ApplicationUser GetById(string id);
        //IEnumerable<ApplicationUser> Swipe(string id_y);
        //Task<bool> UpdateOptions(Options optModel, string? id);
        //Options GetOptionsById(string id);
        //Task<bool> Like(int? id1, int? id2, bool like_u);
        //IEnumerable<int> Matches(string id_y);
        //Task<object> UpdateInformation(UserModel userModel, int? idUs);
    }
}
