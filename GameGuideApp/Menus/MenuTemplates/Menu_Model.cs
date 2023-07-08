using GameGuideApp.MenuSystem.Attributes.Interfaces;
using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;

namespace GameGuideApp.MenuSystem.MenuTemplates
{
    public class Menu_Model : Menu, IMenu_Model
    {
        public List<IAttributes> Attributes { get; set; } = new List<IAttributes>();

        public Menu_Model(IModel model)
        {
            MenuTitle = model.Name;
        }

        public override void Display(IUIController controller)
        {
            controller.DisplayMenu(this);
        }
    }
}
