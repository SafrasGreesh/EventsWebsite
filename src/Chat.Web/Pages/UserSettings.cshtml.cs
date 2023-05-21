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
    public class UserSettingsModel : PageModel
    {
        private readonly ILogger<UserSettingsModel> _logger;

        public UserSettingsModel(ILogger<UserSettingsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}