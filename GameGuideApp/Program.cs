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
        public static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            Input input = new Input();
   
            do
            {
                //MainMenu
                mainMenu.Display();
                input.RecieveInput();
                if (input.ValidateInput()) 
                {

                }

                //
                else Console.WriteLine(input.errorMessage);
                Console.WriteLine();
            }
            while (input.input != "0");
        }
    }
}
