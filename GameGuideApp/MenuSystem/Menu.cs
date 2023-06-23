
using GameGuideApp.Utilities.Interfaces;

namespace GameGuideApp.MenuSystem
{
    /// <summary>
    /// Base class for all Menu objects.
    /// Implements IMenu.
    /// </summary>
    public class Menu : IMenu
    {
        public string MenuTitle { get; set; }
        public string Prompt { get; set; }

        public virtual void Interact(IUIController controller)
        {
            controller.DisplayMenu((IMenu)this);
        }
    }
}
