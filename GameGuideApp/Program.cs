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
            MenuNavigation nav = new MenuNavigation();
            MainMenu mainMenu = new MainMenu();
            Input input = new Input();

            //MainMenu
            //mainMenu.Display();
            nav.path.Push(mainMenu);
            Console.WriteLine("Game Guide App:\n");
            do
            {
                nav.path.Peek().Display();
                input.RecieveInput();
                while (!input.ValidateInput(nav.path.Peek()))
                {
                    input.WriteErrorMessage();
                    input.RecieveInput();
                }
                nav.PickMenu(input, nav.path.Peek().subMenus);
            }
            while (!nav.exit);
        }
    }
}
