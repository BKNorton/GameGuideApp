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

            //Add main menu into menu path
            nav.path.Push(mainMenu);
            Console.WriteLine("Game Guide App:");

            do
            {
                //Display menu and recieve user input
                nav.path.Peek().Display();
                //input.ClearInput();
                input.RecieveInput();

                //Display error message until user enters valid input
                while (!input.ValidateInput(nav.path.Peek()))
                {
                    input.WriteErrorMessage();
                    //input.ClearErrorMessage();
                    //input.ClearInput();
                    input.RecieveInput();
                }

                //Select next menu
                nav.PickMenu(input, nav.path.Peek().subMenus);
            }
            while (!nav.exit);
        }
    }
}
