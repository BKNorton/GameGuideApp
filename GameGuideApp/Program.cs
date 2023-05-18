using GameGuideApp.MenuSystem;

namespace GameGuideApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuNavigation nav = new MenuNavigation();
            Menu mainMenu = new MenuMain();

            //Add mainMenu as the first menu in the MenuNavigation path
            nav.AddMenu(mainMenu);

            //Master loop
            do
            {
                //Display menu and recieve user input
                nav.DisplayMenu();
                Input.RecieveInput();

                //Display error message until user enters valid input
                while (!Input.ValidateInput(nav.GetCurrentMenu()))
                {
                    Input.WriteErrorMessage();
                    Console.WriteLine();
                    Input.RecieveInput();
                }

                //Select next menu
                nav.PickMenu();
                Console.WriteLine("\n\n\n");
            }
            while (!nav.ExitProgram());
        }
    }
}
