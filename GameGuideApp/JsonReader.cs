using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class JsonReader
    {
        //Take a file and retrun file contents as a string
        public string JsonToString(string fileName)
        {
            return File.ReadAllText(@fileName);
        }


    }
}
