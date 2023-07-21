
using MenuSystem.Menus.MenuTemplates;

namespace MenuSystem.Menus
{
    /// <summary>
    /// This class represents a Game with a GameMenu. 
    /// </summary>
    public abstract class Game
    {
        public string Name { get; set; } = string.Empty;
        public GameMenu GameMenu { get; set; } = new GameMenu();

        public Game() 
        {
            GameMenu.Prompt = "Select Menu";
        }
    }
}
