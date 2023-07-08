using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;
using MenuSystem;

namespace GameGuideApp.MenuSystem.Interfaces
{
    public interface IUIController
    {
        void DisplayMenu(IMenu? menu);
        void DisplayStatus(Navigation_Menu nav);
    }
}