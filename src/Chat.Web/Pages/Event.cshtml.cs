﻿using System;
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
    public class EventModel : PageModel
    {
        private readonly ILogger<EventModel> _logger;

        public EventModel(ILogger<EventModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}