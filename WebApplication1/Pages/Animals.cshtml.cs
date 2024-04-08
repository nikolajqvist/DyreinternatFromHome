using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class AnimalsModel : PageModel
    {
        private readonly ILogger<AnimalsModel> _logger;

        public AnimalsModel(ILogger<AnimalsModel> logger)
        {
            _logger = logger;
        }
        public List<Snake> snakes { get; set; }
        public List<Bear> bears { get; set; }
        public List<Cat> cats { get; set; }
        public void OnGet()
        {
            bears = new List<Bear>();
            bears.Add(new Bear("Blackbear", 84, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
            bears.Add(new Bear("Grizzlybear", 64, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
            bears.Add(new Bear("Salmonbear", 43, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));


            snakes = new List<Snake>();
            snakes.Add(new Snake("Pyton", 81, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
            snakes.Add(new Snake("Anaconda", 71, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
            snakes.Add(new Snake("Hugorm", 61, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));

            cats = new List<Cat>();
            cats.Add(new Cat("Birmacat", 12, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
            cats.Add(new Cat("Straycat", 6, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
            cats.Add(new Cat("Norwegian Forestcat", 22, "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
        }
    }

}
