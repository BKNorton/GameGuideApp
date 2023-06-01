using GameGuideApp.MenuSystem;

namespace GameGuideApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuNavigation nav = new MenuNavigation(new InputController_Console());
            Menu mainMenu = new MainMenu();

            //Add mainMenu as the first menu in the MenuNavigation path
            nav.AddMenu(mainMenu);

            //Master loop
            do
            {
                //Display menu and recieve user _input
                nav.DisplayMenu();
                nav.input.RecieveInput();

                //Display error message until user enters valid _input
                while (!nav.input.ValidateInput(nav.GetCurrentMenu(), out string message))
                {
                    Console.WriteLine(message);
                    Console.WriteLine();
                    nav.input.RecieveInput();
                }

                //Select next menu
                nav.PickMenu();
                Console.WriteLine("\n\n\n");
            }
            while (!nav.ExitProgram());
        }
    }
}
