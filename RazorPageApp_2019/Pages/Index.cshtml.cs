#nullable enable
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageApp_2019.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var a = Mult(10, 12);
        }

        void Goo(int i)
        {
            Console.WriteLine(value: i);
            i = 0;
            Console.WriteLine(value: i);
        }

        public static int Mult(int x, int y)
        {
            int f = x * y;
            return f;
        }

        public static int[] swap(int[] args)
        {
            var temp = args[0];
            args[0] = args[1];
            args[1] = temp;
            return args;
        }
    }
}
