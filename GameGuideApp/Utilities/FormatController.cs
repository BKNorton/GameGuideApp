
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

        /// <summary>
        /// Prints out string passed in the parameter with a solid line underneath.
        /// </summary>
        /// <param name="title"></param>
        public static void WriteMenuHeader(string title)
        {
            Console.WriteLine(string.Format("\n{0, 55}\n", title.ToUpper())
            + "   ___________________________________________________________________________________________");
        }

        /// <summary>
        /// Write a paragraph within "--  --" borders. Auto formats to double space.
        /// </summary>
        /// <param name="paragraph"></param>
        public static void WriteWithBorder1(string paragraph)
        {
            Console.WriteLine("\n--\t\t\t\t\t\t\t\t\t\t\t\t--");
            Console.WriteLine(string.Format("\n{0, -5}", DoubleSpace(paragraph)));
            Console.WriteLine("\n--\t\t\t\t\t\t\t\t\t\t\t\t--");
        }

        /// <summary>
        /// Write a paragraph within ">  <" borders. Auto formats to double space.
        /// </summary>
        /// <param name="paragraph"></param>
        public static void WriteWithBorder2(string paragraph)
        {
            Console.WriteLine("\n >\t\t\t\t\t\t\t\t\t\t\t\t<");
            Console.WriteLine(string.Format("\n{0, -5}", DoubleSpace(paragraph)));
            Console.WriteLine("\n >\t\t\t\t\t\t\t\t\t\t\t\t<");
        }

        /// <summary>
        /// Writes a list within ">  <" borders. Each item preceded by "-".
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="list"></param>
        public static void WriteWithBorder2(List<string> list, string title)
        {
            Console.WriteLine($"\n\n {title}:\n");
            Console.WriteLine(" >\t\t\t\t\t\t\t\t\t\t\t\t<\n");
            foreach (var item in list)
            {
                Console.WriteLine(string.Format("{0, 8} {1, -8}", "-", item));
            }
            Console.WriteLine("\n >\t\t\t\t\t\t\t\t\t\t\t\t< \n");
        }

        /// <summary>
        /// Writes a list within ">  <" borders. Each item preceded by "[]". AutoFormatted to single space.
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="list"></param>
        public static void WriteWithBorder2_1(List<string> list, string title)
        {
            Console.WriteLine($"\n {title}:\n");
            Console.WriteLine(" >\t\t\t\t\t\t\t\t\t\t\t\t<");
            foreach (var item in list)
            {
                Console.WriteLine(string.Format("\n{0, 8} {1, -10}", "[]", SingleSpace(item)));
            }
            Console.WriteLine("\n >\t\t\t\t\t\t\t\t\t\t\t\t< \n");
        }

        /// <summary>
        /// Displays a two collum table within "--  --" borders. Uses parameter lists of string. 
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="listL"></param>
        /// <param name="listR"></param>
        /// <param name="title"></param>
        public static void DisplayTwoColTable(List<string> listL, List<string> listR, string title)
        {
            Console.WriteLine($"\n{title}:\n\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n");
            for (int i = 0; i < listL.Count; i++)
            {
                Console.WriteLine(string.Format("\t\t  {0, 28}  |  {1, -28}", listL[i], listR[i]));
                Console.WriteLine(string.Format(string.Format("{0,-100}",
                string.Format("{0," + ((100 + 71) / 2).ToString() + "}", "-----------------------------------------------------------------------"))));
            }
            Console.WriteLine("\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n");
        }
    }
}
