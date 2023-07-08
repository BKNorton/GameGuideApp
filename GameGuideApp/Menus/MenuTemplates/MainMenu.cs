using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;

namespace GameGuideApp.MenuSystem.MenuTemplates
{
    /// <summary>
    /// This is the first Menu. All Games must be added to the class.
    /// </summary>
    public class MainMenu : Menu_SubMenus, IMainMenu
    {
        public List<Game> Games { get; set; }

        /// <summary>
        /// MainMenu takes a list of type Game and populates subMenus with each GameMenu.
        /// </summary>
        /// <param name="games"></param>
        public MainMenu(List<Game> games)
        {
            // Set MenuTitle and Prompt
            MenuTitle = "Main Menu";
            Prompt = "Select a Game";
            Games = new List<Game>();
            // If SubMenus is null create an empty list of typr IMenu.
            // If games is null create an empty list of type Game.
            // Else add GameMenus to MainMenus SubMenus.
            if (SubMenus == null) SubMenus = new List<IMenu>();
            if (games != null) AddGames(games);
        }

        public void AddGames(List<Game> games)
        {
            foreach (Game game in games)
            {
                SubMenus.Add(game.GameMenu);
                Games.Add(game);
            }
        }

        public void AddGame(Game game)
        {
            SubMenus.Add(game.GameMenu);
            Games.Add(game);
        }
    }
}
