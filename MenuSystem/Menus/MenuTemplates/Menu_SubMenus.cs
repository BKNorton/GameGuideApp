
using MenuSystem.Interfaces;
using MenuSystem.Menus.MenuTemplates.Interfaces;

namespace MenuSystem.Menus.MenuTemplates
{
    public abstract class Menu_SubMenus : Menu, IMenu_SubMenus
    {
        public List<IMenu> SubMenus { get; set; }

        public Menu_SubMenus()
        {
            SubMenus = new List<IMenu>();
        }

        public bool Interact(Navigation_Menu nav)
        {
            return nav.SelectSubMenu(this);
        }

        public override void Display(IUIController controller)
        {
            controller.DisplayMenu(this);
        }
    }
}