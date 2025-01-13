using HospitalManagement.BL.Services.Interfaces;
using HospitalManagement.BL.ViewModels.Doctors;
using HospitalManagement.Core.Entities;
using HospitalManagement.DAL.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class ExperienceController(IWebHostEnvironment _env, IDoctorService _service, HospitalManagementDbContext _context) : Controller
{
    public async Task<IActionResult> Index()
    {
        var doctors = await _context.Doctors.ToListAsync();
        return View(doctors);
    }
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(DoctorVM vm)
    {
        var productImagePath = Path.Combine(_env.WebRootPath, "imgs", "doctors");
        if (!Directory.Exists(productImagePath))
        {
            Directory.CreateDirectory(productImagePath);
        }
        ViewBag.Categories = await _context.Departments.Where(x => !x.IsDeleted).ToListAsync();

        Doctor dc = new Doctor
        {
            Name = vm.Name,
            Surname = vm.Surname,
            ImageUrl = productImagePath,
        };
        await _context.Doctors.AddAsync(dc);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
