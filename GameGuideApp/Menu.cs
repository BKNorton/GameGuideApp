using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    class Menu
    {
        public string? prompt;
        public string? menuTitle;

        public void Display()
        {
            Console.WriteLine(menuTitle);
            Console.WriteLine(prompt);
        }
    }
}
