using Microsoft.AspNetCore.Mvc;
using TeamsTab.Models;

namespace TeamsTab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name, string tenant, string group, string entity, string locale)
        {
            var team = new TeamData();
            team.User = name;
            team.Tenant = tenant;
            team.Group = group;
            team.Entity = entity;
            team.Locale = locale;
            return View(team);
        }
        
    }
}
