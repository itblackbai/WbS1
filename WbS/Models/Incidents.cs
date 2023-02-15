using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace WbS.Models
{
    public class Incidents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Description")]
        public string? Description { get; set; }

        public ICollection<Accounts> accounts { get; set; } // one to many
        public Incidents()
        {
            accounts = new List<Accounts>();
        }
    }
}
