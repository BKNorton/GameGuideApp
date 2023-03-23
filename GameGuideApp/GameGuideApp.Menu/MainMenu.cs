namespace GameGuideApp
{
    public class MainMenu : Menu
    {   
        private List<Game> games;

        //Games
        private Game MonsterHunterRise; //1
        private Game Halo;              //2
        private Game NoMansSky;         //3

        public MainMenu()
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
                subMenus.Add(game.gameMenu);
            }  
        }

        public override void Display()
        {
            //Display app title
            //Console.WriteLine("Game Guide App:");
            Console.WriteLine(String.Format("{0,-30}",
                String.Format("{0," + ((30 + 19) / 2).ToString() + "}", " __________________")));
            Console.WriteLine(String.Format("{0,-30}", 
                String.Format("{0," + ((30 + 19) / 2).ToString() + "}", "|  GAME GUIDE APP  |")));
            Console.WriteLine(String.Format("{0,-30}", 
                String.Format("{0," + ((30 + 19) / 2).ToString() + "}", " __________________")));
            base.Display();
            Console.WriteLine("  - 0 :  Exit\n");
        }
    }
}
