namespace GameGuideApp.MenuSystem.MenuTemplates.Interfaces
{
    public interface IMenu_SubMenus : IMenu, IInteractable
    {
        public List<IMenu> SubMenus { get; set; }
    }
}
