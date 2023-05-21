using EventsWebsite.Data;
using EventsWebsite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventsWebsites.New
{
    public interface IEfRepository<T>
    {
        List<T> GetAll();
        T GetById(string id);
        Task<string?> Add(T entity);
        Task UserUpdate(int id, T entity);
        Task OptionsUpdate(int id, T entity);
    }
}
