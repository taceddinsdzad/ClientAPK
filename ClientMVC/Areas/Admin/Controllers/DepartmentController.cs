using ClientMVC.Areas.Admin.ViewModel;
using ClientMVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClientMVC.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            List<DepartmentItemVM> departments = await _context.Departments
               .Select(d => new DepartmentItemVM
               {

                   Name = d.Name
               })
               .ToListAsync();
                
            return View(departments);
        }
    }
}
