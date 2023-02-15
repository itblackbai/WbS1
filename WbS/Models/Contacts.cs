using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WbS.Models
{
    //Index("Email", IsUnique = true )]
    public class Contacts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter FirstName")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter LastName")]
        [Display(Name = "FirstName")]
        public string LastName { get; set; }
       
       
        [Display(Name = "Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        [Remote(action: "CheckEmail", controller: "Home", ErrorMessage = "Email уже используется")]
        public string? Email { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? AccountId { get; set; }
        public Accounts? accounts { get; set; }
    }
}
