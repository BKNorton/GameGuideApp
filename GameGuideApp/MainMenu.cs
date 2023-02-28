using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    internal class MainMenu : Menu
    {   
        private List<Game> games;

        //Games
        //Limited to 10 games
        private Game MonsterHunterRise;

        public MainMenu()
        {
            prompt = "Select Game";
            games = new List<Game>();

            //Initiate Games
            MonsterHunterRise = new MonsterHunterRise();

            //Add games
            games.Add(MonsterHunterRise);
        }
        public void Display()
        {
            Console.WriteLine("Game Guide App:");
            Console.WriteLine(prompt);

            for (int i = 0; i < games.Count; i++) 
            {
                Console.WriteLine($"- {i + 1} : {games[i].name}");
            }
        }
    }
}
