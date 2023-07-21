using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.Utilities;

namespace GameGuideApp.MenuSystem
{
    /// <summary>
    /// Anything that inherits from GameMenu overrides Display and adds _input value (0) with the prompt "Back".
    /// </summary>
    public class Menu_SubMenus : Menu, IMenu_SubMenus
    {
        public List<IMenu> SubMenus { get; set; } = new List<IMenu>();

        public override void Display()
        {
            base.Display();
            FormatController_Console.DisplayForBack();
        }
    }
}
