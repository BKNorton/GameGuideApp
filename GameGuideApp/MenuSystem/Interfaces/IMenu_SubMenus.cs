
using GameGuideApp.MenuSystem.Interfaces;

namespace GameGuideApp.MenuSystem
{
    public interface IMenu_SubMenus : IMenu , IInteractable
    {
        public List<IMenu> SubMenus { get; set; }
    }
}
