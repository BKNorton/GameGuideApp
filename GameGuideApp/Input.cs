using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class Input
    {
        public string? input;
        public string? errorMessage;
        public int inputInt;

        public void RecieveInput()
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
        //Set inputInt 
        public bool ValidateInput(Menu menu)
        {
            if (menu is Menu)
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
            return false;
        }

        public void WriteErrorMessage()
        {
            Console.WriteLine(errorMessage);
        }

        public void ClearInput()
        {
            input = string.Empty;
        }

        public void ClearErrorMessage()
        {
            errorMessage = string.Empty;
        }


    }
}
