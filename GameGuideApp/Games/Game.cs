using GameGuideApp.MenuSystem;

namespace GameGuideApp.Games
{
    /// <summary>
    /// This class represents a Game with a GameMenu. 
    /// </summary>
    public class Game
    {
        public string Name;
        public GameMenu GameMenu;

        public Game()
        {
            GameMenu = new GameMenu();
            {
                GameMenu.prompt = "Select menu";
            }
        }
    }
}
