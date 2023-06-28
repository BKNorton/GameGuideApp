using GameGuideApp.MenuSystem;
using GameGuideApp.Utilities;
using GameGuideApp.Games.MonsterHunterRise;
using GameGuideApp.Games.Halo;
using GameGuideApp.Games.NoMansSky;
using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;
using GameGuideApp.MenuSystem.MenuTemplates;
using GameGuideApp.Utilities.ConsoleController;

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
                nav.InputController.RecieveInput();

                // Prompt user to enter input. Continue prompting for input until input is valid and Interact is performed successfuly.
                while (!nav.InputController.ValidateInput() || !nav.Interact())
                {
                    nav.UIController.DisplayStatus(nav); // should make this a extension method
                    nav.InputController.RecieveInput();
                }

                // Display Navigation Menu Status
                nav.UIController.DisplayStatus(nav);
                Console.WriteLine("\n\n\n");
            }
            while (!nav.Exit);
        }
    }
}
