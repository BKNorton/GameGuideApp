using GameGuideApp.Games;

namespace GameGuideApp.MenuSystem
{
    /// <summary>
    /// This is the first Menu. All Games must be added to the class.
    /// </summary>
    public class MainMenu : Menu
    {
        //Games
        private Game MonsterHunterRise; //1
        private Game Halo;              //2
        private Game NoMansSky;         //3

        private List<Game> _games;

        /// <summary>
        /// Main Menutakes a list of type Game and populates subMenus with each GameMenu.
        /// </summary>
        /// <param name="games"></param>
        public MainMenu()
        {
            //Parent Properties
            menuTitle = "Main Menu";
            prompt = "Select Game";
            
            //Class Properties
            _games = new List<Game>();

            //Initiate Games
            MonsterHunterRise = new MonsterHunterRise();
            Halo = new Halo();
            NoMansSky = new NoMansSky();

            ////Add Games
            _games.Add(MonsterHunterRise);
            _games.Add(Halo);
            _games.Add(NoMansSky);

            //Add Menus
            foreach (Game game in _games)
            {
                subMenus.Add(game.GameMenu);
            }  
        }

        public MainMenu(List<Game> games)
        {
            _games = games;

            //Add Menus
            foreach (Game game in _games)
            {
                subMenus.Add(game.GameMenu);
            }
        }

        public override void Display()
        {
            //Display app title
            Console.WriteLine(string.Format("{0,-30}",
                string.Format("{0," + ((30 + 19) / 2).ToString() + "}", " __________________")));
            Console.WriteLine(string.Format("{0,-32}",
                string.Format("{0," + ((32 + 19) / 2).ToString() + "}", "|  GAME GUIDE APP  |")));
            Console.WriteLine(string.Format("{0,-30}",
                string.Format("{0," + ((30 + 19) / 2).ToString() + "}", " __________________")));

            base.Display(); 
            Console.WriteLine("    0:  Exit\n");
        }
    }
}
