namespace GameGuideApp
{
    //Static class to control input for Program
    public static class Input
    {
        public static string? input;
        public static string? errorMessage;
        public static int inputInt;

        public static void RecieveInput()
        {
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


    }
}
