using EventsWebsite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
//using EventsWebsite.Entity;

namespace EventsWebsite.Services
{
    public interface IEfRepository<T> where T : ApplicationUser
    {
        List<T> GetAll();
        T GetById(int? id);
        Task<int?> Add(T entity);
        Task UserUpdate(int id, T entity);
        Task OptionsUpdate(int id, T entity);
    }
}