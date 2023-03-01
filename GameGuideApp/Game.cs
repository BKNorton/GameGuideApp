using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    internal class Game
    {
        public string? name;
        public Menu mainMenu;
        public List<Menu> subMenus;

        public Game() 
        { 
            subMenus = new List<Menu>();
            mainMenu= new Menu();
        }

        public void Display()
        {
            Console.WriteLine(name + ":");
            for (int i = 0; i < subMenus.Count; i++)
            {
                Console.WriteLine($"-{i} : " + subMenus[i].menuTitle);
            }
            Console.WriteLine("- 0 : Back");
        }
    }
}
