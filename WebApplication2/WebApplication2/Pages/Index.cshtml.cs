using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "";
        
        //public void OnGet(string name = "Валерия", int age = 21)
        public void OnGet()
        {
            Message = "";
        }
    }


}
