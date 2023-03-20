namespace GameGuideApp
{
    public class NoMansSky : Game
    {
        public NoMansSky()
        {
            name = "No Man's Sky";
            gameMenu = new Menu();
            {
                gameMenu.menuTitle = name;
                gameMenu.prompt = "Select menu";
            }
        }
    }
}
