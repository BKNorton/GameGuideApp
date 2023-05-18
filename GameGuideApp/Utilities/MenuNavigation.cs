using GameGuideApp.MenuSystem;

namespace GameGuideApp
{
    /// <summary>
    /// Creates a Menu Stack to navigate through the Menus. 
    /// </summary>
    public class MenuNavigation
    {
        private Stack<Menu> path;
        private bool exit;

        public MenuNavigation()
        {
            path = new Stack<Menu>();
            exit = false;
        }

        /// <summary>
        /// Uses current input value to select what Menu to push into MenuNavigation Stack, or set exit to true 
        /// </summary>
        public void PickMenu()
        {
            //If the user wants to exit the program
            if (Input.GetInput() == "0" && path.Count == 1)
            {
                exit = true;
                Console.WriteLine("\nExiting Program!");
            }

            //If the user wants to go back to the previous menu
            else if (Input.GetInputInt() == 0) GoBack();

            //Select the menu the user chooses
            else if (path.Count != 0) AddMenu(path.Peek().subMenus[Input.GetInputInt() - 1]);

            //There are no menus loaded into path
            else Input.ChangeErrorMessage("Something went wrong!");
        }

        /// <summary>
        /// Returns a List of Menus (subMenus of the current Menu in the Stack). 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Implements the Display method of the current Menu in the Stack
        /// </summary>
        public void DisplayMenu()
        {
            path.Peek().Display();
        }

        /// <summary>
        /// Returns true if exit is true (Meaning the user has selected to exit the program).
        /// </summary>
        /// <returns></returns>
        public bool ExitProgram()
        {
            return exit; 
        }

        /// <summary>
        /// Removes current Menu from Stack.
        /// </summary>
        public void GoBack()
        {
            path.Pop();
        }
    }
}
