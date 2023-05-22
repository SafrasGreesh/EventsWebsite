using AutoMapper;
using EventsWebsite.Services;
//using EventsWebsites.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using EventsWebsite.Models;
using System.Linq;

namespace EventsWebsites.New
{
    public class UserService : IUserService
    {
        private readonly IEfRepository<ApplicationUser> _userRepository;
        //private readonly IEfRepository<Options> _optionsRepository;
        //private readonly IEfRepository<Likes> _likesRepository;
        //private readonly IEfRepository<Matches> _matchesRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;


    //public async Task<int> GetMaxLikesId()
    //{
    //    var events = await Task.Run(() => _likesRepository.GetAll());

    //    var maxId = events.Max(x => x.Id);

    //    maxId++;

    //    return maxId ?? 0;
    //}
    //public async Task<int> GetMaxMathesId()
    //{
    //    var events = await Task.Run(() => _matchesRepository.GetAll());

    //    var maxId = events.Max(x => x.Id);

    //    maxId++;

    //    return maxId ?? 0;
    //}
    //public int CalculateAge(DateTime birthDate)
    //{
    //    DateTime currentDate = DateTime.Today;
    //    int age = currentDate.Year - birthDate.Year;

    //    if (birthDate > currentDate.AddYears(-age))
    //    {
    //        age--;
    //    }

    //    return age;
    //}
    public UserService(IEfRepository<ApplicationUser> userRepository, IConfiguration configuration, IMapper mapper)
    {
        //_optionsRepository = optionsRepository;
        _userRepository = userRepository;
        //_likesRepository = likesRepository;
        //_matchesRepository = matchesRepository;
        _configuration = configuration;
        _mapper = mapper;
    }
   
    
    public IEnumerable<ApplicationUser> GetAll()
    {
        return _userRepository.GetAll(); //возвращает репозиторий юзеров
    }
    public ApplicationUser GetById(string id)
    {
        return _userRepository.GetById(id); //вовзаращет репозиторий
    }
    //public bool UnlickedUser(int id1, int id2)
    //{
    //    // Проверяем наличие лайка пользователя id1 для пользователя id2
    //    var events = _likesRepository.GetAll().Where(u => u.UserId == id1 && u.LikeUserId == id2);

    //    // Если есть хотя бы одно совпадение, возвращаем false (попадался)
    //    if (events.Any())
    //    {
    //        return false;
    //    }

    //    // В противном случае, возвращаем true (не попадался)
    //    return true;
    //}
    //public IEnumerable<ApplicationUser> Swipe(string id_y)
    //{
    //    var options = GetOptionsById(id_y);
    //    if (options.Gender == "A")
    //    {
    //        var UsersSwipe = _userRepository.GetAll()
    //            .Where(u => UnlickedUser(Convert.ToInt32(id_y), u.Id != null ? Convert.ToInt32(u.Id) : 0))
    //            .Where(u => !Equals(u.Id, id_y) && options.City == u.City && options.AgeMin < CalculateAge(u.BirthDate) && options.AgeMax > CalculateAge(u.BirthDate));
    //        return UsersSwipe;
    //    }
    //    else
    //    {
    //        var UsersSwipe = _userRepository.GetAll()
    //            .Where(u => UnlickedUser(Convert.ToInt32(id_y), u.Id != null ? Convert.ToInt32(u.Id) : 0))
    //            .Where(u => u.Id != id_y && options.Gender == u.Gender && options.City == u.City && options.AgeMin < CalculateAge(u.BirthDate) && options.AgeMax > CalculateAge(u.BirthDate));
    //        return UsersSwipe;
    //    }

    //}
   
    //public async Task<bool> UpdateOptions(Options optModel, string? id)
    //{

    //    var options = _optionsRepository.GetById(id); // Найти пользователя по идентификатору

    //    if (options == null)
    //    {

    //        optModel.Id = id;
    //        optModel.AgeMin = optModel.AgeMin;
    //        optModel.AgeMax = optModel.AgeMax;
    //        optModel.Gender = optModel.Gender;
    //        optModel.City = optModel.City;
    //        var addedUser = await _optionsRepository.Add(optModel);

    //        return true;
    //        //throw new DllNotFoundException("User not found");
    //    }

    //    options.AgeMin = optModel.AgeMin;
    //    options.AgeMax = optModel.AgeMax;
    //    options.Gender = optModel.Gender;
    //    options.City = optModel.City;

    //    await _optionsRepository.OptionsUpdate(Convert.ToInt32(id), options); // Сохранить изменения в базе данных

    //    return true;
    //}
    //public Options GetOptionsById(string id)
    //{
    //    var options = _optionsRepository.GetById(id);

    //    if (options == null)
    //    {
    //        var optModel = new Options();
    //        optModel.Id = id;
    //        optModel.AgeMin = 18;
    //        optModel.AgeMax = 100;
    //        optModel.Gender = "A";
    //        optModel.City = "";
    //        options = optModel;
    //    }
    //    return options; //вовзаращет репозиторий
    //}
    //public async Task<bool> Like(int? id1, int? id2, bool like_u)
    //{
    //    var likeModel = new Likes();
    //    likeModel.Id = await GetMaxLikesId();
    //    likeModel.UserId = id1;
    //    likeModel.LikeUserId = id2;
    //    likeModel.CreatedAt = DateTime.Now;
    //    likeModel.Like = like_u;

    //    if (like_u == true)
    //    {
    //        var UsersMatches = _likesRepository.GetAll().Where(u => u.UserId == id2 && Equals(u.LikeUserId, id1) && u.Like == true);
    //        if (UsersMatches.Any())
    //        {
    //            var matchesModel = new Matches();
    //            matchesModel.Id = await GetMaxMathesId();
    //            matchesModel.UserId1 = id1;
    //            matchesModel.UserId2 = id2;
    //            matchesModel.CreatedAt = DateTime.Now;

    //            var match = _mapper.Map<Matches>(matchesModel); //создает объект юзера
    //            var addedMatch = await _matchesRepository.Add(match);
    //        }
    //    }

    //    var like_user = _mapper.Map<Likes>(likeModel); //создает объект юзера

    //    var addedLikes = await _likesRepository.Add(like_user);



    //    var options = _likesRepository.GetById(id1.ToString()); // Найти пользователя по идентификатору

    //    return true;
    //}
    //public IEnumerable<int> Matches(string id_y)
    //{
    //    var options = GetOptionsById(id_y);
    //    var UsersMatches = _matchesRepository.GetAll().Where(u => Equals(u.UserId1, id_y) || Equals(u.UserId2, id_y));

    //    // Проекция каждого элемента в id второго человека взаимного лайка и исключение значений null
    //    var secondUserIds = UsersMatches.Select(u => Equals(u.UserId1, id_y) ? u.UserId2 : u.UserId1)
    //                                    .Where(id => id.HasValue)
    //                                    .Select(id => id.Value)
    //                                    .Distinct();

    //    return secondUserIds;
    //}

    //public Task<object> UpdateInformation(UserModel userModel, int? idUs)
    //{
    //    throw new NotImplementedException();
    //}
    }
}
