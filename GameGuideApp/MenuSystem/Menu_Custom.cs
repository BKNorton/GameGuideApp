using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.Utilities;


namespace GameGuideApp.MenuSystem
{
    public class Menu_Custom : Menu, IMenu_Custom
    {
        public virtual string MenuToString()
        {
            return FormatController_Console.FormatMenuTitle(MenuTitle);
        }
    }
}
