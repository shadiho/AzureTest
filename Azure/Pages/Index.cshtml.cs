﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Azure.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public readonly IConfiguration _config;
        public IndexModel(ILogger<IndexModel> logger,IConfiguration configuration)
        {
            _logger = logger;
            _config = configuration;
        }

        public void OnGet()
        {

        }
    }
}
