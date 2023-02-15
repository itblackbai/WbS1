using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WbS.Models
{
   // [Index("AccoutName", IsUnique = true)]
    public class Accounts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? AccoutName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? IncidentId { get; set; }
        public Incidents? incidents { get; set; }


        public ICollection<Contacts> contacts { get; set; } // one to many
        public Accounts()
        {
            contacts = new List<Contacts>();
        }
    }
}
