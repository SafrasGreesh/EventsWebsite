using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EventsWebsite.Pages
{
    [Authorize]
    public class LikeModel : PageModel
    {
        private readonly ILogger<LikeModel> _logger;

        public LikeModel(ILogger<LikeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}