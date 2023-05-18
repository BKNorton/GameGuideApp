
namespace GameGuideApp.Utilities
{

    //Format string data to console specifications
    public static class FormatController
    {

        /// <summary>
        /// Takes a string and adds double spaces at a specified character count to format for console output, and returns the new string.
        /// </summary>
        /// <param Name="oldString"></param>
        /// <returns></returns>
        public static string DoubleSpace(string oldString)
        {
            List<string> words = oldString.Split(' ').ToList();
            string newString = string.Empty;
            var charCount = 0;

            words[0] = "\t" + words[0];
            for (int i = 0; i < words.Count; i++)
            {
                charCount += words[i].Length;

                if (charCount <= 70 && charCount >= 62)
                {
                    words[i] = "\n\n\t" + words[i];
                    charCount = 0;
                }
                newString += words[i] + ' ';
            }

            return newString;
        }

        /// <summary>
        /// Takes a string and adds double spaces at a specified character count to format for console output, and returns the new string.
        /// </summary>
        /// <param Name="oldString"></param>
        /// <returns></returns>
        public static string SingleSpace(string oldString)
        {
            List<string> words = oldString.Split(' ').ToList();
            string newString = string.Empty;
            var charCount = 0;

            for (int i = 0; i < words.Count; i++)
            {
                charCount += words[i].Length;

                if (charCount <= 65 && charCount >= 58)
                {
                    words[i] = "\n\t " + words[i];
                    charCount = 0;
                }
                newString += words[i] + ' ';
            }

            return newString;
        }
    }
}
