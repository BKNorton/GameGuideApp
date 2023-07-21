
using MenuSystem.Attributes.Interfaces;
using MenuSystem.Interfaces;
using MenuSystem.Menus.MenuTemplates.Interfaces;

namespace MenuSystem.Menus.MenuTemplates
{
    public abstract class Menu_ModelView : Menu, IMenu_Model
    {
        public List<IAttributes> Attributes { get; set; } = new List<IAttributes>();

        public Menu_ModelView(IModel model)
        {
            MenuTitle = model.Name;
        }

        public override void Display(IUIController controller)
        {
            controller.DisplayMenu(this);
        }
    }
}
