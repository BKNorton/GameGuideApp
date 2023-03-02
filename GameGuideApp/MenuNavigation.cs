using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    internal class MenuNavigation
    {
        public Stack<Menu> path;
        public bool exit;

        public MenuNavigation()
        {
            path = new Stack<Menu>();
            exit = false;
        }

        public void PickMenu(Input input, List<Menu> menus)
        {
            if (input.inputInt == 0 && path.Peek().menuTitle != "Main Menu")
            {
                GoBack();
            }
            else if (input.inputInt == 0)
            {
                ExitProgram();
            }
            else
            {
                //menus[input.inputInt-1].Display();
                path.Push(menus[input.inputInt-1]);
            }
                    
        }
        /*
        public void PickGame(Input input, List<Game> games)
        {
            if (input.inputInt==0) { return; }
            games[input.inputInt-1].Display();
            path.Push(games[input.inputInt-1]);
        }
        */

        public void ExitProgram()
        {
            exit = true; 
        }

        public void GoBack()
        {
            path.Pop();
        }
    }
}
