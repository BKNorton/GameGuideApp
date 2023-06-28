using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;
using GameGuideApp.Utilities.ConsoleController.Interfaces;

namespace GameGuideApp.MenuSystem.MenuTemplates
{
    public class Menu_SubMenus : Menu, IMenu_SubMenus
    {
        public List<IMenu> SubMenus { get; set; }

        public Menu_SubMenus()
        {
            SubMenus = new List<IMenu>();
        }

        public void AddSubMenus(List<IMenu> subMenus)
        {
            foreach (IMenu subMenu in subMenus)
            {
                SubMenus.Add(subMenu);
            }
        }

        public void AddSubMenu(IMenu subMenu)
        {
            SubMenus.Add(subMenu);
        }

        public bool Interact(Navigation_Menu nav)
        {
            return nav.SelectSubMenu(this);
        }

        public override void Display(IUIController controller)
        {
            //base.Display(controller);
            controller.DisplayMenu(this);
        }
    }
}