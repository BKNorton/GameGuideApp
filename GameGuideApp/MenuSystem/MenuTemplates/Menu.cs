using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;
using GameGuideApp.Utilities.ConsoleController.Interfaces;

namespace GameGuideApp.MenuSystem.MenuTemplates
{
    /// <summary>
    /// Base class for all Menu objects.
    /// Implements IMenu.
    /// </summary>
    public abstract class Menu : IMenu
    {
        public string MenuTitle { get; set; }
        public string Prompt { get; set; }

        public virtual void Display(IUIController controller)
        {
            controller.DisplayMenu(this);
        }
    }
}
