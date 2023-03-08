using System.ComponentModel.DataAnnotations;

namespace Graduate_Project___Leon.Models
{
    public class Profile
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
    }
}
