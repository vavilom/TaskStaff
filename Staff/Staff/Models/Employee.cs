using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staff.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required, Display(Name = "First name")]
        public string Name { get; set; }
        [Required, Display(Name = "Last name")]
        public string LastName { get; set; }
        [Range(18, 80)]
        [Required, Display(Name = "Age")]
        public int Age { get; set; }
        [Required, Display(Name = "Position")]
        public string Position { get; set; }
        [Display(Name = "Chief")]
        public int? ChiefId { get; set; }
        [Display(Name = "Full name")]
        public string FullName
        {
            get { return Name + " " + LastName; }
        }

        [ForeignKey("ChiefId")]
        public Employee Chief { get; set; }
    }
}