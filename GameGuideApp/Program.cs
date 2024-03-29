﻿using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;
using GameGuideApp.MenuSystem.MenuTemplates;


namespace GameGuideApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of games to pass into the MainMenu contructor.
            List<Game> games = new List<Game>
            {
                // Add Games.
                new GameMonsterHunterRise(),
                new GameHalo(),
                new GameNoMansSky()
            };

            // Create a MainMenu passing _games as an argument.
            IMainMenu mainMenu = new MainMenu(games);

            // Create a MenuNavigation with Console input and output, and pass mainMenu as the first menu.
            Navigation_Menu nav = new(new InputController_Console(), new UIController_Console(), mainMenu);

            // Master loop.
            do
            {
                // Display menu, prompt and wait to recieve input from the user.
                nav.DisplayCurrentMenu();
                nav.RecieveInput();

                // Prompt user to enter input. Continue prompting for input until input is valid and Interact is performed successfuly.
                while (!nav.ValidateInput() || !nav.Interact())
                {
                    nav.DisplayStatus();
                    nav.RecieveInput();
                }

                // Display Navigation Menu Status
                //nav.DisplayStatus();
                Console.WriteLine("\n\n\n");
            }
            while (!nav.Exit);
        }
    }
}
