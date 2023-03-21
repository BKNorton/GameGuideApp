namespace GameGuideApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuNavigation nav = new MenuNavigation();
            MainMenu mainMenu = new MainMenu();

            //Add main menu into menu path
            nav.AddMenu(mainMenu);
            Console.WriteLine("Game Guide App:");

            do
            {
                //Display menu and recieve user input
                nav.DisplayMenu();
                Input.ClearInput();
                Input.RecieveInput();

                //Display error message until user enters valid input
                while (!Input.ValidateInput(nav.path.Peek()))
                {
                    Input.WriteErrorMessage();
                    Console.WriteLine();
                    Input.ClearErrorMessage();
                    Input.ClearInput();
                    Input.RecieveInput();
                }

                //Select next menu
                nav.PickMenu(Input.inputInt, nav.path.Peek().subMenus);
            }
            while (!nav.exit);
        }
    }
}
