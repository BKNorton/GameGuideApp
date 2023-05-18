using GameGuideApp.Games;
using GameGuideApp.Games.MonsterHunterRise;

namespace GameGuideApp.MenuSystem
{
    /// <summary>
    /// This is the first Menu. All Games must be added to the class.
    /// </summary>
    public class MenuMain : Menu
    {   
        //Games
        private Game MonsterHunterRise; //1
        private Game Halo;              //2
        private Game NoMansSky;         //3

        private List<Game> games;

        /// <summary>
        /// This is the first Menu. All Games must be added to the class.
        /// </summary>
        public MenuMain()
        {
            //Parent Properties
            menuTitle = "Main Menu";
            prompt = "Select Game";
            
            //Class Properties
            games = new List<Game>();

            //Initiate Games
            MonsterHunterRise = new MonsterHunterRise();
            Halo = new Halo();
            NoMansSky = new NoMansSky(); 

            //Add Games
            games.Add(MonsterHunterRise);
            games.Add(Halo);
            games.Add(NoMansSky);

            //Add Menus
            foreach(Game game in games)
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

            //Displays menuTitle and prompt and subMenus - menuTitle
            base.Display(); 
            Console.WriteLine("    0:  Exit\n");
        }
    }
}
