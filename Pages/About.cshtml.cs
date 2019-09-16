using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace RazorPagesPizza.Pages
{
    public class AboutModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }

        public IActionResult OnPost()
        {
            Message += " můj dovětek";

            return RedirectToPage("/Index");
        }

        public void OnGetDetail()
        {
            
        }


    }
}
