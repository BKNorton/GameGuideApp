namespace GameGuideApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuNavigation nav = new MenuNavigation();
            Menu mainMenu = new MainMenu();

            //Add mainMenu as the first menu in the path
            nav.AddMenu(mainMenu);

            //Master loop
            do
            {
                //Display menu and recieve user input
                nav.DisplayMenu();
                Input.ClearInput();
                Input.RecieveInput();

                //Display error message until user enters valid input
                while (!Input.ValidateInput(nav.GetCurrentMenu()))
                {
                    Input.WriteErrorMessage();
                    Console.WriteLine();
                    Input.ClearErrorMessage();
                    Input.ClearInput();
                    Input.RecieveInput();
                }

                //Select next menu
                nav.PickMenu(Input.GetInputInt(), nav.GetSubMenus());
                Console.WriteLine("\n\n\n");
            }
            while (!nav.ExitProgram());
        }
    }
}
