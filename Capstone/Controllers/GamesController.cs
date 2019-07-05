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
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public GamesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Games
        public async Task<IActionResult> Index(string searchQuery, string gameGenre, string gamePlatform, string gamePlayers)
        {

            //adding filter for genre in dropdown list
            var genreList = new List<string>();
            var genreQuery = from g in _context.Game.Include(g => g.User) select g.Genre;
            genreList.AddRange(genreQuery.Distinct());
            ViewBag.gameGenre = new SelectList(genreList);

            //adding filter for platform in dropdown list
            var platformList = new List<string>();
            var platformQuery = from g in _context.Game.Include(g => g.User) select g.Platform;
            platformList.AddRange(platformQuery.Distinct());
            ViewBag.gamePlatform = new SelectList(platformList);

            //adding filter for number of players in dropdown list
            var numberPlayersList = new List<string>();
            var playerQuery = from g in _context.Game.Include(g => g.User) select g.NumberOfPlayers;
            numberPlayersList.AddRange(playerQuery.Distinct());
            ViewBag.gamePlayers = new SelectList(numberPlayersList);

            var games = from g in _context.Game.Include(g => g.User)
                        select g;

            //adding search by title, genre, platform, and number of players
            if (!string.IsNullOrEmpty(searchQuery))
            {
                games = games.Where(g => g.Title.Contains(searchQuery) || g.Genre.Contains(searchQuery) || g.Platform.Contains(searchQuery) || g.NumberOfPlayers.Contains(searchQuery));
            }
            //checking for filter for genre
            if (!string.IsNullOrEmpty(gameGenre))
            {
                games = games.Where(g => g.Genre.Contains(gameGenre));
            }
            //checking for filter for platform
            if (!string.IsNullOrEmpty(gamePlatform))
            {
                games = games.Where(g => g.Platform.Contains(gamePlatform));
            }
            //checking for filter for number of players
            if (!string.IsNullOrEmpty(gamePlayers))
            {
                games = games.Where(g => g.NumberOfPlayers.Contains(gamePlayers));
            }

            ApplicationUser user = await GetCurrentUserAsync();
            var applicationDbContext = _context.Game.Include(g => g.User);

            return View(games);
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Genre,Description,EsrbRating,Platform,NumberOfPlayers,ReleaseDate,HavePlayed")] Game game)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");

            var currentUser = await GetCurrentUserAsync();
            game.UserId = currentUser.Id;


            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id = game.GameId });
            }
            return View(game);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int GameId, [Bind("GameId, Title,Genre,Description,EsrbRating,Platform,NumberOfPlayers,ReleaseDate,HavePlayed")] Game game)
        {
            if (GameId != game.GameId)
            {
                return NotFound();
            }
            ModelState.Remove("User");
            ModelState.Remove("UserId");

            var currentUser = await GetCurrentUserAsync();
            game.UserId = currentUser.Id;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.GameId))
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
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Game.FindAsync(id);
            _context.Game.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Game.Any(e => e.GameId == id);
        }

        //Add Game To List
        [HttpGet]

        public async Task<IActionResult> AddGameToList([FromRoute]int GameId, Game game)
        {
            var currentUser = await GetCurrentUserAsync();
            game.UserId = currentUser.Id;

            List<Game> Games = await _context.Game.Where(g => g.UserId == currentUser.Id).ToListAsync();

            _context.Add(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}