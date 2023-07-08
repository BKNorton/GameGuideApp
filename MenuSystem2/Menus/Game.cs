using GameGuideApp.MenuSystem.MenuTemplates;

namespace GameGuideApp.MenuSystem
{
    /// <summary>
    /// This class represents a Game with a GameMenu. 
    /// </summary>
    public class Game
    {
        public string Name { get; set; } = string.Empty;
        public Menu_SubMenus GameMenu;

        public Game()
        {
            GameMenu = new Menu_SubMenus();
            {
                GameMenu.Prompt = "Select menu";
            }
        }
    }
}
