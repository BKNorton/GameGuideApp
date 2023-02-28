using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    internal class Program
    {
        public static void main(string[] args)
        {
            var mainMenu = new MainMenu();
            Input input = new Input();

            do
            {
                mainMenu.Display();

            }
            while (input.input != "0");
        }
    }
}
