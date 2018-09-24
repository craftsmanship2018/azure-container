using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CraftathonContainerTest.Pages
{
    public class PlansModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "What could your business achieve if all your employees acted like shareholders?";
        }
    }
}
