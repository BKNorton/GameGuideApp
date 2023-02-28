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

        public void RecieveInput()
        {
            try
            {
                input = Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("Something went wrong");
            }  
        }

        public bool ValidateInput(string input)
        {
            if (!int.TryParse(input, out int result)) return false;
            else if (result < 0 || result > 10) return false;
            else return true;
        }
    }
}
