namespace GameGuideApp
{
    //Static class to control input for Program
    public static class Input
    {
        private static string? input;
        private static string? errorMessage;
        private static int inputInt;

        public static void RecieveInput()
        {
            Console.Write("Enter: ");
            try
            {
                input = Console.ReadLine();
            }
            catch (Exception)
            {
                errorMessage = "Something went wrong";
            }
        }

        //Validate that input is an int, and in range
        //Set inputInt with valid input
        public static bool ValidateInput(Menu menu)
        {
            if (!int.TryParse(input, out int result)
                || result < 0 || result > menu.subMenus.Count)
            {
                errorMessage = "Invalid Input";
                return false;
            }
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

        internal static void ChangeErrorMessage(string message)
        {
            errorMessage = message;
        }
    }
}
