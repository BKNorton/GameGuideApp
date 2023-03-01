using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GameGuideApp
{
    class MainMenu : Menu
    {   
        private List<Game> games;

        //Games
        //Limited to 9 games
        private Game MonsterHunterRise; //1
        private Game Halo;              //2

        public MainMenu()
        {
            //Menu Properties
            menuTitle = "Game Guide App:\n\nMain Menu";
            prompt = "Select Game";
            
            //Class Properties
            games = new List<Game>();
            

            //Initiate Games
            MonsterHunterRise = new MonsterHunterRise();
            Halo = new Halo();

            //Add games
            games.Add(MonsterHunterRise);
            games.Add(Halo);
            //Insure that there are 9 game objects in list
            for (int i = games.Count; i < 9; i++)
            {
                games.Add(new Game());
            }
        }

        public new void Display()
        {
            base.Display();
            for (int i = 0; i < games.Count; i++) 
            {
                Console.WriteLine($"- {i + 1} : {games[i].name}");
            }
            Console.WriteLine("- 0 : Exit");
        }
    }
}
