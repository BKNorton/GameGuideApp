using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.Utilities.Interfaces;
using System.Runtime.CompilerServices;

namespace GameGuideApp.MenuSystem
{
    public class Navigation_Menu
    {
        public Stack<IMenu> Path;
        public IInputController InputController;
        public IUIController UIController;

        public string Status;
        public bool Exit {  get => (Path.Count == 0); }

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
            if (InputController.InputInt == 0)
            {
                RemoveMenu();
                Status = "Previous Menu";
                return true;
            }

            // Extract current menu to use.
            // If current menu is null, exit the method.
            var currentMenu = Path.Peek();
            if (currentMenu == null) return false;

            // If currentMenu implements IInteractable, then cast as a new obj of type IInteractable to have access to IIteractable methods.
            // Call Interact on new obj.
            if (currentMenu is IInteractable)
            {
                IInteractable interactable = (IInteractable)currentMenu;
                if (!interactable.Interact(InputController, this)) return false;
            }
            return true;
        }

        /// <summary>
        /// Helper Method :
        /// This method passes an IMenu_SubMenus as an argument and uses InputController InputInt, from this class, to add the Menu that matches the input, to the Navigation_Menu path.
        /// This assumes that input has been recieved and validated; it is an int, it is greater than 0 and path Count is greater than zero.
        /// </summary>
        /// <param name="menu"></param>
        public bool SelectSubMenu(IInputController inputController, IMenu_SubMenus menu)
        {   
            if (inputController.InputInt <= menu.SubMenus.Count)
            {
                AddMenu(menu.SubMenus.ElementAt(inputController.InputInt - 1));
                Status = "Menu has been selected";
                return true;
            }
            else
            {
                Status = "Invalid Input!";
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
            if (menu is IMenu_SubMenus)
            {
                Path.Push((IMenu_SubMenus)menu);
            }
            else if (menu is IMenu_Custom)
            {
                Path.Push((IMenu_Custom)menu);
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
                
                if (menu == null) return null;
                if (menu is IMenu_SubMenus) return (IMenu_SubMenus)menu;
                if (menu is IMenu_Custom) return (IMenu_Custom)menu;
                //if (menu is IMainMenu) return (IMainMenu)menu;
            }

            Status = "Error: Get Current Menu was unsuccessful";
            return null;
        }

        public void DisplayCurrentMenu()
        {
            var current = GetCurrentMenu();
            if (current == null) return;
            if (current is IMenu_SubMenus)
                UIController.DisplayMenu((IMenu_SubMenus)current);
            else if (current is IMenu_Custom)
                UIController.DisplayMenu((IMenu_Custom)current);
            else
                UIController.DisplayMenu(current);
        }

        public void DisplayMenu(IMenu menu)
        {
            UIController.DisplayMenu(menu);
        }

        public void ReturnToMainMenu()
        {
            foreach (IMenu menu in Path)
            {
                if (Path.Count == 1) return;
                RemoveMenu();
            }
        }
    }
}
