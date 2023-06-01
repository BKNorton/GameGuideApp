using GameGuideApp.MenuSystem;

namespace GameGuideApp
{
    /// <summary>
    /// Creates a Menu Stack to navigate through the Menus. 
    /// </summary>
    public class MenuNavigation
    {
        private Stack<Menu> _path;
        private bool _exit;
        public IInputController Input;

        /// <summary>
        /// Default constructor instantiates input as InputController_Console
        /// </summary>
        public MenuNavigation()
        {
            _path = new Stack<Menu>();
            _exit = false;
            Input = new InputController_Console();
        }

        /// <summary>
        /// Takes a IInputController and injects it into input.
        /// </summary>
        /// <param name="input"></param>
        public MenuNavigation(IInputController input)
        {
            _path = new Stack<Menu>();
            _exit = false;
            this.Input = input;
        }

        /// <summary>
        /// Uses current _input value to select what Menu to push into MenuNavigation Stack, pop path to return to previus Menu, or set exit to true 
        /// </summary>
        public void PickMenu()
        {
            //If the user wants to exit the program
            if (Input.GetInputString() == "0" 
                && _path.Count == 1)
            {
                _exit = true;
                Console.WriteLine("\nExiting Program!");
            }

            //If the user wants to go back to the previous menu
            else if (Input.GetInputString() == "0") GoBack();

            //Select the menu the user chooses
            else if (_path.Count != 0) AddMenu(_path.Peek().subMenus[Input.GetInputInt() - 1]);

            //There are no menus loaded into path
            else Console.WriteLine("Something went wrong! There are no Menus in path");
        }

        /// <summary>
        /// Returns a List of Menus (subMenus of the current Menu in the Stack). 
        /// </summary>
        /// <returns></returns>
        public List<Menu> GetSubMenus()
        {
            return _path.Peek().subMenus;
        }

        public Menu GetCurrentMenu()
        {
            return _path.Peek();
        }

        public void AddMenu(Menu menu)
        {
            _path.Push(menu);
        }

        /// <summary>
        /// Implements the Display method of the current Menu in the Stack
        /// </summary>
        public void DisplayMenu()
        {
            _path.Peek().Display();
        }

        /// <summary>
        /// Returns true if exit is true (Meaning the user has selected to exit the program).
        /// </summary>
        /// <returns></returns>
        public bool ExitProgram()
        {
            return _exit; 
        }

        /// <summary>
        /// Removes current Menu from Stack.
        /// </summary>
        public void GoBack()
        {
            _path.Pop();
        }
    }
}
