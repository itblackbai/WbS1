using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WbS.Models
{
    [Index("AccoutName", IsUnique = true)]
    public class Accounts
    {
       
        public string Id { get; set; }
        [Required(ErrorMessage = "Please enter accout name")]
        [Display(Name = "AccoutName")]
        [Remote(action: "CheckAccount", controller: "Home", ErrorMessage = "Account is valid")]
        public string? AccoutName { get; set; }

        
        public int? IncidentId { get; set; }
        public Incidents? incidents { get; set; }


        public ICollection<Contacts> contacts { get; set; } // one to many
        public Accounts()
        {
            contacts = new List<Contacts>();
        }
    }
}
