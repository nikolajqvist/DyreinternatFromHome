namespace WebApplication1.Models
{
    public class Snake
    {
        public string Race { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public Snake(string race, int age, string description)
        {
            Race = race;
            Age = age;
            Description = description;
        }
    }
}
