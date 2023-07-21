namespace MenuSystem.Menus.MenuTemplates.Interfaces
{
    public interface IMainMenu : IMenu
    {
        public List<Game> Games { get; set; }
    }
}
