using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    class Halo : Game
    {
        public Halo() 
        {
            name = "Halo";
            gameMenu = new Menu();
            {
                gameMenu.menuTitle = name;
                gameMenu.prompt = "Select menu";
            }
        }
    }
}
