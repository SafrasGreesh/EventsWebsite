using Microsoft.AspNetCore.Http;

namespace EventsWebsite.Helpers
{
    public interface IFileValidator
    {
        bool IsValid(IFormFile file);
    }
}
