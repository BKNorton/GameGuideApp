namespace GameGuideApp
{
    public class Game
    {
        public string? name;
        public Menu gameMenu;
        
        public Game() 
        {
            gameMenu = new Menu();
            {
                gameMenu.menuTitle = name!;
                gameMenu.prompt = "Select menu";
            }
        }
    }
}
