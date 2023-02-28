using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            Input input = new Input();
   
            do
            {
                mainMenu.Display();
                input.RecieveInput();
                input.ValidateInput();
            }
            while (input.input != "0");
        }
    }
}
