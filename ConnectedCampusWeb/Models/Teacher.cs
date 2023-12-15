using System.ComponentModel.DataAnnotations;

namespace ConnectedCampusWeb.Models
{
    public class Teacher
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string description { get; set; }

    }
}
