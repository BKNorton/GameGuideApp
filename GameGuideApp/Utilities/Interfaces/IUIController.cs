using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.Interfaces;

namespace GameGuideApp.Utilities.Interfaces
{
    public interface IUIController
    {
        void DisplayMenu(IMenu? menu);
        void DisplayMenu(IMenu_SubMenus subMenus);
        void DisplayMenu(IMenu_Custom customMenu);
        void DisplayStatus(Navigation_Menu nav);
    }
}