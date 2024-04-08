using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class AnimalDescriptionModel : PageModel
    {
        public List<Bear> bears {  get; set; }
        public List<Cat> cats { get; set; }
        public List<Snake> snakes { get; set; }
        public void OnGet()
        {
            
        }
    }
}
