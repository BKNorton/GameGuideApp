using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class NoMansSky : Game
    {
        public NoMansSky()
        {
            name = "No Man's Sky";
            gameMenu = new Menu();
            {
                gameMenu.menuTitle = name;
                gameMenu.prompt = "Select menu";
            }
        }
    }
}
