namespace GameGuideApp
{
    /// <summary>
    /// Static class that has methods to prompt and recieve and validate user input.
    /// </summary>
    public static class Input
    {
        private static string? input;
        private static string? errorMessage;
        private static int inputInt;

        /// <summary>
        /// Promts and recieves user input.
        /// </summary>
        public static void RecieveInput()
        {
            Console.Write("Enter: ");
            try
            {
                input = Console.ReadLine();
            }
            catch (IOException)
            {
                errorMessage = "Something went wrong";
            }
        }

        /// <summary>
        /// Validate that input is an int, and in range of subMenu Length. Sets inputInt to input if it is a valid integer.
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        //Set inputInt with valid input
        public static bool ValidateInput(Menu menu)
        {
            //Input is invalid
            if ((!int.TryParse(input, out int result))
                || result < 0 || result > menu.subMenus.Count)
            {
                errorMessage = "Invalid Input";
                return false;
            }

            //Input is valid
            inputInt = result;
            return true;
        }

        public static int GetInputInt()
        {
            return inputInt;
        }

        public static void WriteErrorMessage()
        {
            Console.WriteLine(errorMessage);
        }

        public static void ClearInput()
        {
            input = string.Empty;
        }

        public static void ClearErrorMessage()
        {
            errorMessage = string.Empty;
        }

        public static void ChangeErrorMessage(string message)
        {
            errorMessage = message;
        }
    }
}
