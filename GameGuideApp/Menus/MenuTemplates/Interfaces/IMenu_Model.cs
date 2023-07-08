using GameGuideApp.MenuSystem.Attributes.Interfaces;

namespace GameGuideApp.MenuSystem.MenuTemplates.Interfaces
{
    public interface IMenu_Model : IMenu
    {
        public List<IAttributes> Attributes { get; set; }
    }
}
