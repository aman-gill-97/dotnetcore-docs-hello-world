using dotnetcoresample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace dotnetcoresample.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly dotnetcoresample.Models.ContosoHRContext _context;

        public IndexModel(dotnetcoresample.Models.ContosoHRContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get; set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
