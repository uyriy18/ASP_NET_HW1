﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
   
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public char Message { get; set; }
        public void OnGet()
        {
            Message = getRand();
        }
        private char getRand()
        {
            Random rand = new Random();
            return (char)rand.Next(65, 90);
        }
    }
}
