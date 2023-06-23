using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.Utilities.Interfaces;

namespace GameGuideApp.Utilities
{
    public class UIController_Console : IUIController
    {
        public void DisplayMenu(IMenu? menu)
        {
            if (menu == null)
            {
                Console.WriteLine("There is no Menu");
                return;
            }
            Console.WriteLine(FormatController_Console.FormatMenuHeader(menu));
            Console.WriteLine(FormatController_Console.FormatExitOrBack(menu));
        }

        public void DisplayMenu(IMenu_SubMenus subMenu)
        {
            Console.WriteLine(FormatController_Console.FormatMenuHeader(subMenu));
            Console.WriteLine(FormatController_Console.FormatSubMenuDescending(subMenu));
            Console.WriteLine(FormatController_Console.FormatExitOrBack(subMenu));
        }

        public void DisplayMenu(IMenu_Custom customMenu)
        {
            Console.WriteLine(customMenu.MenuToString());
            Console.WriteLine(FormatController_Console.FormatExitOrBack(customMenu));
        }

        /// <summary>
        /// This method displays the InputStatus of IIntputController passed as an argument.
        /// </summary>
        /// <param name="input"></param>
        public void DisplayStatus(Navigation_Menu nav)
        {
            Console.WriteLine(nav.Status);
        }
    }
}
