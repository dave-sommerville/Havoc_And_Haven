using Havoc_And_Haven.DAL;
using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class PublicProfileVMController : Controller
{
    private readonly HavocAndHavenDbContext _context;

    public PublicProfileVMController(HavocAndHavenDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Heroes()
    {
        var heroes = await _context.Users
            .Where(u => u.Role == "Hero")
            .Include(u => u.Headquarters)
                .ThenInclude(h => h.Location)
            .ToListAsync();

        var heroVMs = heroes.Select(user => new PublicProfileVM
        {
            UserId = user.UserId,
            Alias = user.Alias,
            OriginStory = user.OriginStory,
            PowerLevel = user.PowerLevel,
            HeadquartersId = user.HeadquartersId,
            HeadquarterTitle = user.Headquarters?.BaseTitle,
            HeadquarterDescription = user.Headquarters?.Description,
            HeadquarterCapacity = user.Headquarters?.Capacity,
            HeadquarterLocation = user.Headquarters?.Location?.Address
        }).ToList();

        return View("Index", heroVMs);
    }
}