using MenuSystem.Menus.MenuTemplates.Interfaces;

namespace MenuSystem.Interfaces
{
    public interface IUIController
    {
        void DisplayMenu(IMenu? menu);
        void DisplayStatus(Navigation_Menu nav);
    }
}