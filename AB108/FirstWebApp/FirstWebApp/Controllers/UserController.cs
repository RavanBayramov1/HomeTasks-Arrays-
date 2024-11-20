using FirstWebApp.Data;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (AB108MVCContext _context = new AB108MVCContext())
            {
                return View(await _context.Users.ToListAsync());
            }
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User data)
        {
            using (AB108MVCContext context = new())
            {
                await context.AddAsync(data);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
