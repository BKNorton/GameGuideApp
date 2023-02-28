using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    class MainMenu : Menu
    {   
        private List<Game> games;

        //Games
        //Limited to 9 games
        private Game MonsterHunterRise;
        private Game Halo;

        public MainMenu()
        {
            prompt = "Select Game";
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
        public void Display()
        {
            Console.WriteLine("Game Guide App:");
            Console.WriteLine(prompt);

            for (int i = 0; i < games.Count; i++) 
            {
                Console.WriteLine($"- {i + 1} : {games[i].name}");
            }
            Console.WriteLine("- 0 : Exit");
        }
    }
}
