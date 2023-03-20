using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GameGuideApp
{
    public class MainMenu : Menu
    {   
        public List<Game> games;

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


            //Add games
            games.Add(MonsterHunterRise);
            games.Add(Halo);
            games.Add(NoMansSky);


            //Add gameMenus to menus
            foreach(Game game in games)
            {
                subMenus.Add(game.gameMenu);
            }  
        }

        //Dislplay uses games instead of menus
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine(menuTitle);
            Console.WriteLine(prompt);
            
            for (int i = 0; i < games.Count; i++) 
            {
                Console.WriteLine($"- {i + 1} : {games[i].name}");
            }
            Console.WriteLine("- 0 : Exit");
        }
    }
}
