using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Yummy.Data;

namespace Yummy.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var claimIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim == null)
            {
                return Redirect("/Identity/Account/Login");
            }

            var cartlist = _context.carts.Include(x => x.Meal).
                Where(x => x.ApplicationUserId == claim.Value).
                ToList();
            foreach (var cart in cartlist)
            {

            }
            return View(cartlist);
        }
        public async Task<IActionResult>plus(int id)
        {
            var cart = await _context.carts.FirstOrDefaultAsync(x => x.Id == id);
            cart.Count += 1;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> minus(int id)
        {
            var cart = await _context.carts.FirstOrDefaultAsync(x => x.Id == id);
            if (cart.Count == 1)
            {
                _context.carts.Remove(cart);
                _context.SaveChanges();
            }
            else
            {
                cart.Count -= 1;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> detete(int id)
        {
            var cart = await _context.carts.FirstOrDefaultAsync(x => x.Id == id);
           
                _context.carts.Remove(cart);
                _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}
