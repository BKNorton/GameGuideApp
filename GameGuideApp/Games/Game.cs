namespace GameGuideApp
{
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
