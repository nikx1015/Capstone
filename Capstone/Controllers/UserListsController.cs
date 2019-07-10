using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Capstone.Data;
using Capstone.Models;
using Microsoft.AspNetCore.Identity;

namespace Capstone.Controllers
{
    public class UserListsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserListsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
          private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: UserLists
        public async Task<IActionResult> Index()
        {
            ApplicationUser user = await GetCurrentUserAsync();
            var applicationDbContext = _context.UserList.Include(u => u.game)
                .Where(userList=> userList.UserId == user.Id);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: UserLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userList = await _context.UserList
                .Include(u => u.game)
                .FirstOrDefaultAsync(m => m.UserListId == id);
            if (userList == null)
            {
                return NotFound();
            }

            return View(userList);
        }

        // GET: UserLists/Create
        public IActionResult Create()
        {
            ViewData["GameId"] = new SelectList(_context.Game, "GameId", "Title");
            return View();
        }

        // POST: UserLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserListId,GameId,UserId")] UserList userList)
        {
          ModelState.Remove("User");
          ModelState.Remove("UserId");

            if (ModelState.IsValid)
            {
                var currentUser = await GetCurrentUserAsync();
                userList.UserId = currentUser.Id;
                _context.Add(userList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           
            ViewData["GameId"] = new SelectList(_context.Game, "GameId", "Title", userList.GameId);
            return View(userList);
        }

        // GET: UserLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userList = await _context.UserList.FindAsync(id);
            if (userList == null)
            {
                return NotFound();
            }
            ViewData["GameId"] = new SelectList(_context.Game, "GameId", "Description", userList.GameId);
            return View(userList);
        }

        // POST: UserLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserListId,GameId")] UserList userList)
        {
            if (id != userList.UserListId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserListExists(userList.UserListId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Game, "GameId", "Description", userList.GameId);
            return View(userList);
        }

        // GET: UserLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userList = await _context.UserList
                .Include(u => u.game)
                .FirstOrDefaultAsync(m => m.UserListId == id);
            if (userList == null)
            {
                return NotFound();
            }

            return View(userList);
        }

        // POST: UserLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userList = await _context.UserList.FindAsync(id);
            _context.UserList.Remove(userList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserListExists(int id)
        {
            return _context.UserList.Any(e => e.UserListId == id);
        }
    }
}
