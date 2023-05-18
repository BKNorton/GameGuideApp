using Newtonsoft.Json;

namespace GameGuideApp
{
    public static class JsonReader
    {
        /// <summary>
        /// Take a string path/fileName for a json file and return file contents as a string
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string JsonFileToString(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        /// <summary>
        /// Return a List of objects created from json file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<T> JsonFileToObjects<T>(string fileName)
        {
            return JsonConvert.DeserializeObject<List<T>>(JsonFileToString(fileName))!;
        }

        
    }
}
