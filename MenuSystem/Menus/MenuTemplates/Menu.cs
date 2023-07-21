
using MenuSystem.Interfaces;
using MenuSystem.Menus.MenuTemplates.Interfaces;

namespace MenuSystem.Menus.MenuTemplates
{
    /// <summary>
    /// Base class for all Menu objects.
    /// Implements IMenu.
    /// </summary>
    public abstract class Menu : IMenu
    {
        public string MenuTitle { get; set; } = string.Empty;
        public string Prompt { get; set; } = string.Empty;

        public virtual void Display(IUIController controller)
        {
            controller.DisplayMenu(this);
        }
    }
}
