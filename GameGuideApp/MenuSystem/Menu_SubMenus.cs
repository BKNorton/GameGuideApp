using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.Utilities.Interfaces;
using System.Net.NetworkInformation;

namespace GameGuideApp.MenuSystem
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

        public bool Interact(IInputController inputController, Navigation_Menu nav)
        {
            return nav.SelectSubMenu(inputController, this);
        }
    }
}