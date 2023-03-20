using Newtonsoft.Json;

namespace GameGuideApp
{
    public static class JsonReader
    {
        //Take a string fileName of json file and return file contents as a string
        public static string JsonFileToString(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        //Return a List of objects created from json file
        public static List<T> JsonFileToObjects<T>(string fileName)
        {
            return JsonConvert.DeserializeObject<List<T>>(JsonFileToString(fileName))!;
        }
    }
}
