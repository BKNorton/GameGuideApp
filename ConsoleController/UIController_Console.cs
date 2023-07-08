using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.MenuSystem.Attributes.Interfaces;
using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;

namespace ConsoleController
{
    public class UIController_Console : IUIController
    {
        public void DisplayMenu(IMenu? menu)
        {
            // Check if menu is null
            if (menu == null)
            {
                Console.WriteLine("There is no Menu");
                return;
            }

            if (menu is IMainMenu) DisplayMenu((IMainMenu)menu);
            if (menu is IMenu_SubMenus) DisplayMenu((IMenu_SubMenus)menu);
            if (menu is IMenu_Model) DisplayMenu((IMenu_Model)menu);
            Console.WriteLine(FormatController_Console.FormatExitOrBack(menu));
        }

        public void DisplayMenu(IMenu_SubMenus subMenu)
        {
            Console.WriteLine(FormatController_Console.FormatMenuHeader(subMenu));
            Console.WriteLine(FormatController_Console.FormatSubMenuDescending(subMenu));
        }

        public void DisplayMenu(IMenu_Model model)
        {
            Console.WriteLine(FormatController_Console.FormatMenuTitle(model));
            DisplayAttributes(model.Attributes);
        }

        public void DisplayMenu(IMainMenu menu)
        {
            Console.WriteLine(FormatController_Console.GameGuideTitle());
        }

        /// <summary>
        /// This method displays the InputStatus of IIntputController passed as an argument.
        /// </summary>
        /// <param name="input"></param>
        public void DisplayStatus(Navigation_Menu nav)
        {
            Console.WriteLine($"\n{nav.Status}\n");
        }

        public void DisplayAttributes(List<IAttributes> attributes)
        {
            // This loop skips the first element in attributes because the first element should always be Name and Name is already displayed.
            for (int i = 0; i < attributes.Count; i++)
            {
                var attr = attributes[i];
                if (attr is IAttributes_Paragraph)
                {
                    Console.WriteLine(FormatController_Console.FormatWithBorder1((IAttributes_Paragraph)attr));
                }
                else if (attr is IAttributes_ListSingle)
                {
                    Console.WriteLine(FormatController_Console.FormatWithBorder1((IAttributes_List)attr));
                }
                else if (attr is IAttributes_List)
                {
                    Console.WriteLine(FormatController_Console.FormatWithBorder1_1((IAttributes_List)attr));
                }
                // For now this will automatically only display two collums until I can fix this. 
                // TODO : Create Display table method that will display all sizes of tables.
                else if (attr is IAttributes_Table)
                {
                    Console.WriteLine(FormatController_Console.FormatTwoColTable1((IAttributes_Table)attr));
                }
            }
        }
    }
}
