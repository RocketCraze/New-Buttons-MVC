namespace Graduate_Project___Leon.Models
{
    public class ProfileViewModel
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Dob { get; set; }

        public int Age { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

        public ProfileViewModel(string firstName, string lastName, string dob, int age, string country, string city)
        {
            Name = firstName;
            Surname = lastName;
            Dob = dob;
            Age = age;
            Country = country;
            City = city;
        }
    }

    
}
