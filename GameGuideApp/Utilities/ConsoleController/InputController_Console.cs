using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.Interfaces;
using GameGuideApp.Utilities.ConsoleController.Interfaces;

namespace GameGuideApp.Utilities.ConsoleController
{
    /// <summary>
    /// Static class that has methods to prompt and recieve user _input, and to validate input.
    /// Implements IInputController.
    /// </summary>
    public class InputController_Console : IInputController
    {
        public string InputStatus { get; set; }
        public string? InputString { get; set; }
        public int InputInt { get; set; }

        public InputController_Console()
        {
            InputStatus = "Input Controller created for Console Input";
        }

        /// <summary>
        /// Promts and recieves user _input.
        /// </summary>
        public void RecieveInput()
        {
            // Prompt user to enter input.
            // Recieve input.
            Console.Write("Enter: ");
            try
            {
                InputString = Console.ReadLine();
                InputStatus = "Input recieved";
            }
            catch (IOException)
            {
                InputString = null;
                InputStatus = "Something went wrong";
            }
        }

        /// <summary>
        /// Validate that _input is an int.   
        /// Sets _inputInt to _input if it is a valid integer.
        /// </summary>
        /// <param Name="menu"></param>
        /// <returns></returns>
        public bool ValidateInput()
        {
            // Checks if input is an integer and is not less than 0.

            // Input is valid
            if (int.TryParse(InputString, out int result)
                && result >= 0)
            {
                InputInt = result;
                InputStatus = "Valid Input";
                return true;
            }

            // Input is invalid
            // Clear InputString
            //InputString = string.Empty;
            InputStatus = "Invalid Input";
            return false;
        }


    }
}
