//using Havoc_And_Haven.DAL;
//using Havoc_And_Haven.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity;

//public class PrivateProfileVMController : Controller
//{
//    private readonly HavocAndHavenDbContext _context;
//    private readonly UserManager<User> _userManager;

//    public PrivateProfileVMController(HavocAndHavenDbContext context, UserManager<User> userManager)
//    {
//        _context = context;
//        _userManager = userManager;
//    }
//    public async Task<IActionResult> PrivateProfile(int id)
//    {
//        User user = await _context.Users
//            .Include(u => u.Headquarters)
//                .ThenInclude(h => h.Location)
//            .Include(u => u.Lair)
//                .ThenInclude(l => l.Location)
//            .FirstOrDefaultAsync(u => u.UserId == id);

//        if (user == null)
//        {
//            return NotFound();
//        }

//        PrivateProfileVM vm = new PrivateProfileVM
//        {
//            UserId = user.UserId,
//            FirstName = user.FirstName,
//            LastName = user.LastName,
//            Alias = user.Alias,
//            Email = user.Email,
//            OriginStory = user.OriginStory,
//            Role = user.Role,
//            PowerLevel = user.PowerLevel,

//            HeadquartersId = user.HeadquartersId,
//            HeadquarterTitle = user.Headquarters?.BaseTitle,
//            HeadquarterDescription = user.Headquarters?.Description,
//            HeadquarterCapacity = user.Headquarters?.Capacity,
//            HeadquarterLocation = user.Headquarters?.Location?.Address,

//            LairId = user.LairId,
//            LairTitle = user.Lair?.BaseTitle,
//            LairDescription = user.Lair?.Description,
//            LairCapacity = user.Lair?.Capacity,
//            LairLocation = user.Lair?.Location?.Address,

//            OtherHeroesInHeadquarter = user.Headquarters != null
//                ? _context.Users
//                    .Where(u => u.HeadquartersId == user.HeadquartersId && u.UserId != user.UserId)
//                    .Select(u => u.Alias)
//                    .ToList()
//                : new List<string>(),

//            OtherVillainsInLair = user.Lair != null
//                ? _context.Users
//                    .Where(u => u.LairId == user.LairId && u.UserId != user.UserId)
//                    .Select(u => u.Alias)
//                    .ToList()
//                : new List<string>()
//        };

//        return View(vm);
//    }
//}
