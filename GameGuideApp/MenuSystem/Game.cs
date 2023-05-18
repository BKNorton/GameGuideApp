namespace GameGuideApp.MenuSystem
{
    /// <summary>
    /// This class represents a Game with a GameMenu. 
    /// </summary>
    public class Game
    {
        public string Name;
        public MenuGame GameMenu;

        public Game()
        {
            GameMenu = new MenuGame();
            {
                GameMenu.prompt = "Select menu";
            }
        }
    }
}
