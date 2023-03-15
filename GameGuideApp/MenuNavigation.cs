using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class MenuNavigation
    {
        public Stack<Menu> path;
        public bool exit;

        public MenuNavigation()
        {
            path = new Stack<Menu>();
            exit = false;
        }

        //Takes user input and the current menu's subMenus to navigate
        public void PickMenu(Input input, List<Menu> menus)
        {
            //if the user wants to exit the program
            if (input.inputInt == 0 && path.Peek().menuTitle == "Main Menu")
            {
                ExitProgram();
            }
            //If the user wants to go back to the previous menu
            else if (input.inputInt == 0)
            {
                GoBack();
            }
            //Select the menu the user chooses
            else
            {
                path.Push(menus[input.inputInt-1]);
            }       
        }

        public void AddMenu(Menu menu)
        {
            path.Push(menu);
        }

        public void DisplayMenu()
        {
            path.Peek().Display();
        }

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
