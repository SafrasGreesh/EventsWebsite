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
    public class EventsListModel : PageModel
    {
        private readonly ILogger<EventsListModel> _logger;

        public EventsListModel(ILogger<EventsListModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}