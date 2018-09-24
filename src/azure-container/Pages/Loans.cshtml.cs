using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CraftathonContainerTest.Pages
{
    public class LoansModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Expert support through our comprehensive range of mortgage and loan services";
        }
    }
}
