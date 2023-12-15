using System.ComponentModel.DataAnnotations;

namespace ConnectedCampusWeb.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int name { get; set; }
        [Required]
        public int Class { get; set; }
    }
}
