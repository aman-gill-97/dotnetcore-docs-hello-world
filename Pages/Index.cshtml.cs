﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnetcoresample.Models;

namespace dotnetcoresample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly dotnetcoresample.Models.ContosoHRContext _context;

        public IndexModel(dotnetcoresample.Models.ContosoHRContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employees != null)
            {
                Employee = await _context.Employees.ToListAsync();
            }
        }
    }
}
