using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public static class JsonReader
    {
        //Take a file and retrun file contents as a string
        public static string FileToJsonString(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        //public static List<T> Deserialize<T>(string jsonString) 
        //{
        //    return JsonConvert.DeserializeObject<List<T>>(jsonString)!;
        //}

        public static List<T> JsonToObjects<T>(string fileName)
        {
            //return Deserialize<T>(FileToJsonString(fileName));
            return JsonConvert.DeserializeObject<List<T>>(FileToJsonString(fileName))!;
        }
    }
}
