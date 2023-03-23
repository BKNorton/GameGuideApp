namespace GameGuideApp
{
    public class MenuNavigation
    {
        private Stack<Menu> path;
        private bool exit;

        public MenuNavigation()
        {
            path = new Stack<Menu>();
            exit = false;
        }

        //Takes user input as an int and the current menu's subMenus, as parameters 
        //0 is used to Back out to last menu, or Exit the program
        public void PickMenu(int input, List<Menu> menus)
        {
            //If the user wants to exit the program
            if (input == 0 && path.Count == 1)
            {
                exit = true;
                Console.WriteLine("\nExiting Program!");
            }

            //If the user wants to go back to the previous menu
            else if (input == 0) GoBack();

            //Select the menu the user chooses
            else if (path.Count != 0) path.Push(menus[input - 1]);

            //There are no menus loaded into path
            else Input.ChangeErrorMessage("Path has no menus loaded!");
        }

        //Get list of subMenus from current menu 
        public List<Menu> GetSubMenus()
        {
            return path.Peek().subMenus;
        }

        public Menu GetCurrentMenu()
        {
            return path.Peek();
        }

        public void AddMenu(Menu menu)
        {
            path.Push(menu);
        }

        public void DisplayMenu()
        {
            path.Peek().Display();
        }

        //Returns true if user has has selected exit (0) on first menu in path
        public bool ExitProgram()
        {
            return exit; 
        }

        public void GoBack()
        {
            path.Pop();
        }
    }
}
