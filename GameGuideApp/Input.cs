using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    internal class Input
    {
        public string? input;
        public string? errorMessage;

        public void RecieveInput()
        {
            try
            {
                input = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }  
        }

        public bool ValidateInput()
        {
            if (!int.TryParse(input, out int result) 
                || (result < 0 || result > 10))
            {
                errorMessage = "Invalid Input";
                return false;
            }
            else return true;
        }

        public void ClearInput()
        {
            input = null;
        }
    }
}
