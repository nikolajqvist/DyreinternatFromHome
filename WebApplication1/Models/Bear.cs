namespace WebApplication1.Models
{
    public class Bear
    {

        public Bear(string race, int age, string description)
        {
            Race = race;
            Age = age;
            Description = description;
        }

        public string Race { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

    }
}
