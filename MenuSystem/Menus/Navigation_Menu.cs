using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;

namespace GameGuideApp.MenuSystem
{
    public class Navigation_Menu
    {
        public Stack<IMenu> Path;
        public IInputController InputController;
        public IUIController UIController;

        public string Status;
        public bool Exit {  get => (Path.Count == 0); }

        private IMenu CurrentMenu { get => Path.Peek(); }

        /// <summary>
        /// Constructor takes 3 arguments; 
        /// IInputController : to control input
        /// IUIController : to control output
        /// IMainMenu : adds a IMainMenu as the first menu in the Stack<IMenu> </IMenu>
        /// </summary>
        /// <param name="inputController"></param>
        /// <param name="uiController"></param>
        /// <param name="menu"></param>
        public Navigation_Menu(IInputController inputController, IUIController uiController, IMainMenu menu)
        {
            Path = new Stack<IMenu>();
            Path.Push(menu);
            InputController = inputController;
            UIController = uiController;

            Status = "Menu Navigation initialized";
        }

        /// <summary>
        /// This method uses the Navigation_Menu's IInputController to Interact with the current Menu in path.
        /// Assumes that the IInputController input has been recieved and validated before calling this method.
        /// </summary>
        public bool Interact()
        {
            // Validate that the path is not empty or null.
            // If path is null or empty, exit the method.
            if (Path == null || Path.Count == 0)
            {
                Status = "Error: Path is null or empty";
                return false;
            }

            // Check to see if inputInt is 0. This means return to previous menu or exit the program.
            // If true exit the method.
            if (InputController.InputString == "0")
            {
                RemoveMenu();
                Status = "Previous Menu";
                return true;
            }

            // Extract current menu to use.
            // If current menu is null, exit the method.
            if (CurrentMenu == null)
            {
                Status = "Menu is null";
                return false;
            }

            // If currentMenu implements IInteractable, then cast as a new obj of type IInteractable to have access to IIteractable methods.
            // Call Interact on new obj.
            if (CurrentMenu is IInteractable)
            {
                IInteractable interactable = (IInteractable)CurrentMenu;
                if (!interactable.Interact(this))
                {
                    Status = InputController.InputStatus;
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Helper Method :
        /// This method passes an IMenu_SubMenus as an argument and uses InputController InputInt, from this class, to add the Menu that matches the input, to the Navigation_Menu path.
        /// This assumes that input has been recieved and validated; it is an int, it is greater than 0 and path Count is greater than zero.
        /// </summary>
        /// <param name="menu"></param>
        public bool SelectSubMenu(IMenu_SubMenus menu)
        {   
            if (InputController.InputInt <= menu.SubMenus.Count)
            {
                AddMenu(menu.SubMenus[InputController.InputInt - 1]);
                Status = InputController.InputStatus;
                return true;
            }
            else
            {
                Status = InputController.InputStatus;
                return false;
            }
        }

        public void AddMenu(IMenu menu)
        {
            if (menu == null)
            {
                Status = "Error: Add Menu was unsuccessful";
                return;
            }
            else
            {
                Path.Push(menu);
            }
            Status = "Menu was added";
        }

        public void RemoveMenu()
        {
            if (Path == null || Path.Count == 0)
            {
                Status = "Error: Attempt to Remove Menu was unsuccessful";
                return;
            }
                Path.Pop();
        }

        public IMenu? GetCurrentMenu()
        {

            if (Path.Count > 0)
            {
                Status = "Returning Menu";
                var menu = Path.Peek();
                return menu;
            }

            Status = "Error: Get Current Menu was unsuccessful";
            return null;
        }

        public void DisplayCurrentMenu()
        {
            var current = GetCurrentMenu();
            if (current == null) return;
            current.Display(UIController);
        }

        public void ReturnToMainMenu()
        {
            foreach (IMenu menu in Path)
            {
                if (Path.Count == 1) return;
                RemoveMenu();
            }
        }

        public void DisplayMenu(IMenu menu)
        {
            UIController.DisplayMenu(menu);
        }

        public void RecieveInput()
        {
            InputController.RecieveInput();
            Status = InputController.InputStatus;
        }

        public bool ValidateInput()
        {
            if (!InputController.ValidateInput()) return false;
            if (CurrentMenu is IMenu_SubMenus)
            {
               if (ValidateInputSub((IMenu_SubMenus)CurrentMenu)) return true;
               else return false;
            }
            else if (CurrentMenu is IMenu_Model)
            {
                if (InputController.InputString == "0") return true;
                else return false;
            }
            else return false;
        }

        public bool ValidateInputSub(IMenu_SubMenus menu)
        {
            if (InputController.InputInt <= menu.SubMenus.Count)
            {
                Status = "Valid Input";
                return true;
            }
            else
            {
                Status = "Invalid Input";
                return false;
            }
        }

        public void DisplayStatus()
        {
            UIController.DisplayStatus(this);
        }
    }
}
