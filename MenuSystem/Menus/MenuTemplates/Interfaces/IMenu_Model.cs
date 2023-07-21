using MenuSystem.Attributes.Interfaces;

namespace MenuSystem.Menus.MenuTemplates.Interfaces
{
    public interface IMenu_Model : IMenu
    {
        public List<IAttributes> Attributes { get; set; }
    }
}
