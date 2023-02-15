
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.Text.RegularExpressions;
using WbS.Data;
using WbS.Models;

namespace WbS.Controllers
{
    public class HomeController : Controller
    {
       
        
        ApplicationDbContext db;
        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }

 

        public IActionResult Index() => View();

        public IActionResult Contacts() => View();

        public IActionResult Accounts() => View();
       
        public IActionResult Incidents() => View();

        public IActionResult Error404() => View();


        [AcceptVerbs("Get", "Post")]
        public IActionResult CheckEmail(string AccountName,Contacts contacts)
        {

            if (AccountName == contacts.Email)
                return Json(false);
            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> Contacts(Contacts contacts)
        {
            db.contacts.Add(contacts);
            await db.SaveChangesAsync();
            return RedirectToAction("Accounts");

        }
     

        [HttpPost]
        public async Task<IActionResult> Accounts(Accounts accounts)
        {

            db.accounts.Add(accounts);
            await db.SaveChangesAsync();
            return RedirectToAction("Incidents"); 
  
        }
        [HttpPost]
        public async Task<IActionResult> Incidents(Incidents incidents)
        {
            db.incidents.Add(incidents);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
      


    }
}