﻿namespace WebApplication1.Models
{
    public class Cat
    {
        public string Race { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public Cat(string race, int age, string description)
        {
            Race = race;
            Age = age;
            Description = description;

        }
    }
}
