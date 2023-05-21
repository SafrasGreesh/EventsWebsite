//using EventsWebsite.Entity;
//using EventsWebsite.Models;

using System.Collections.Generic;
using System.Threading.Tasks;
//using EventsWebsite.Entity;
using EventsWebsite.Models;

namespace EventsWebsite.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Task<AuthenticateResponse> Register(UserModel userModel);
        IEnumerable<Users> GetAll();
        Users GetById(int id);
        Task<AuthenticateResponse> UpdateInformation(UserModel userModel, int? id);
        IEnumerable<Users> Swipe(int id_y);
        Task<bool> UpdateOptions(Options optModel, int? id);
        Options GetOptionsById(int id);
        Task<bool> Like(int? id1, int? id2, Boolean like_u);
        IEnumerable<int> Matches(int id_y);

    }
}
