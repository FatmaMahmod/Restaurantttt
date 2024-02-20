using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YUMMY.Models;
using Yummy.Data;

namespace Yummy.Controllers.User
{
    public class ChefsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChefsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Chefs
        public async Task<IActionResult> Index()
        {
              return _context.Chefs != null ? 
                          View(await _context.Chefs.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Chefs'  is null.");
        }

        // GET: Chefs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Chefs == null)
            {
                return NotFound();
            }

            var chef = await _context.Chefs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (chef == null)
            {
                return NotFound();
            }

            return View(chef);
        }

       
    }
}
