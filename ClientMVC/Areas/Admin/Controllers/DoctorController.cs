using ClientMVC.Areas.Admin.ViewModel;
using ClientMVC.DAL;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClientMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<DoctorItemVM>doctors=await _context.Doctors
                .Select(
                d=>new DoctorItemVM 
                {
                    DepartmentName=d.Department.Name,
                    Name=d.Name,
                    Surname=d.Surname,
                    Image=d.Image,
                })
                .ToListAsync();
            return View(doctors);
        }
    }
}
