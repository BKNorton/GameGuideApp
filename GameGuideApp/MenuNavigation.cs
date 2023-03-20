namespace GameGuideApp
{
    public class MenuNavigation
    {
        public Stack<Menu> path;
        public bool exit;

        public MenuNavigation()
        {
            path = new Stack<Menu>();
            exit = false;
        }

        //Takes user input as an int and the current menu's subMenus as parameters 
        public void PickMenu(int input, List<Menu> menus)
        {
            //if the user wants to exit the program
            if (input == 0 && path.Peek().menuTitle == "Main Menu")
            {
                ExitProgram();
            }
            //If the user wants to go back to the previous menu
            else if (input == 0)
            {
                GoBack();
            }
            //Select the menu the user chooses
            else
            {
                path.Push(menus[input-1]);
            }       
        }

        public void AddMenu(Menu menu)
        {
            path.Push(menu);
        }

        public void DisplayMenu()
        {
            path.Peek().Display();
        }

        public void ExitProgram()
        {
            exit = true; 
        }

        public void GoBack()
        {
            path.Pop();
        }
    }
}
