using GameGuideApp.MenuSystem;

namespace GameGuideApp
{
    /// <summary>
    /// Static class that has methods to prompt and recieve and validate user _input.
    /// </summary>
    public class InputController_Console : IInputController
    {
        private string _input;
        private int _inputInt;
        private string _errorMessage;

        public InputController_Console()
        {
            _input = string.Empty;
            _errorMessage = string.Empty;
        }

        /// <summary>
        /// Promts and recieves user _input.
        /// </summary>
        public void RecieveInput()
        {
            Console.Write("Enter: ");
            try
            {
                _input = Console.ReadLine();
            }
            catch (IOException)
            {
                _errorMessage = "Something went wrong";
            }
        }

        /// <summary>
        /// Validate that _input is an int, and in range of subMenu Length. 
        /// Sets _inputInt to _input if it is a valid integer.
        /// </summary>
        /// <param Name="menu"></param>
        /// <returns></returns>
        public bool ValidateInput(Menu menu, out string message)
        {
            //Input is invalid
            if (!int.TryParse(_input, out int result)
                || result < 0
                || result > menu.subMenus.Count)
            {
                message = "Invalid Input";
                return false;
            }

            //Input is valid
            _inputInt = result;
            message = "Valid Input";
            return true;
        }

        public int GetInputInt() => _inputInt;

        public string GetInputString() => _input;

        public void WriteErrorMessage() => Console.WriteLine(_errorMessage);

        public void ClearInput() => _input = string.Empty;

        public void ClearErrorMessage() => _errorMessage = string.Empty;

        public void ChangeErrorMessage(string message) => _errorMessage = message;
    }
}
