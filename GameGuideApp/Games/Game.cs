using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.Interfaces;

namespace GameGuideApp.Games
{
    /// <summary>
    /// This class represents a Game with a GameMenu. 
    /// </summary>
    public class Game 
    {
        public string Name;
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
