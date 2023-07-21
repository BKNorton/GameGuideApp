
namespace MenuSystem.Menus.MenuTemplates.Interfaces
{
    public interface IMenu : IDisplayable
    {
        public string MenuTitle { get; set; }
        public string Prompt { get; set; }
    }
}
