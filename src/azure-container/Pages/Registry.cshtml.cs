using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CraftathonContainerTest.Pages
{
    public class RegistryModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Share registration made simple";
        }
    }
}
