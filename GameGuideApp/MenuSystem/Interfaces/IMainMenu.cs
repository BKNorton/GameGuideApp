using GameGuideApp.Games;

namespace GameGuideApp.MenuSystem.Interfaces
{
    public interface IMainMenu : IMenu
    {
        public List<Game> Games { get; set; }
    }
}
