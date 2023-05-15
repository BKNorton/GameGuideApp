namespace GameGuideApp
{
    /// <summary>
    /// This class represents a Game with a GameMenu. 
    /// </summary>
    public class Game
    {
        public string? name;
        public GameMenu gameMenu;

        public Game()
        {
            gameMenu = new GameMenu();
            {
                gameMenu.prompt = "Select menu";
            }
        }
    }
}
