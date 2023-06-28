using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;

namespace GameGuideApp.Utilities.ConsoleController.Interfaces
{
    public interface IUIController
    {
        void DisplayMenu(IMenu? menu);
        void DisplayStatus(Navigation_Menu nav);
    }
}