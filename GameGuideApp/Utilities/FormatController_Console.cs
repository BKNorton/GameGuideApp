
using GameGuideApp.MenuSystem;
using GameGuideApp.MenuSystem.Interfaces;

namespace GameGuideApp.Utilities
{
    /// <summary>
    /// Static class with methods to format output to console.
    /// </summary>
    public static class FormatController_Console
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
        /// Prints out string in  passed in the parameter with all caps and a solid line underneath.
        /// </summary>
        /// <param name="title"></param>
        public static string FormatMenuTitle(string title)
        {
            return (string.Format("\n{0, 55}", title.ToUpper())
            + "   ___________________________________________________________________________________________");
        }

        /// <summary>
        /// Takes in a IMenu object and returns the MenuTitle and Prompt as a string, formatted for the console.
        /// </summary>
        /// <param name="menuTitle"></param>
        /// <param name="prompt"></param>
        public static string FormatMenuHeader(IMenu menu)
        {
            if (menu is IMenu_SubMenus) 
            {
                //Center and write menutitle and prompt
                return 
                (string.Format("{0,-32}",
                    string.Format("{0," + ((32 + menu.MenuTitle.Length) / 2).ToString() + "}", menu.MenuTitle))) + "\n" +
                (string.Format("{0,-32}",
                    string.Format("{0," + ((32 + menu.Prompt.Length) / 2).ToString() + "}", menu.Prompt))) + "\n" +
                ("_________________________________\n");
            }
            else if (menu is IMenu)
            {
                return (string.Format("\n{0, 55}\n", menu.MenuTitle.ToUpper()) +
                    "   ___________________________________________________________________________________________");
            }
            return string.Empty;
        }

        /// <summary>
        /// Write a paragraph within "--  --" borders. Auto formats to double space.
        /// </summary>
        /// <param name="paragraph"></param>
        public static string FormatWithBorder1(string paragraph)
        {
            return ("\n--\t\t\t\t\t\t\t\t\t\t\t\t--\n") +
            (string.Format("\n{0, -5}", DoubleSpace(paragraph)))+
            ("\n--\t\t\t\t\t\t\t\t\t\t\t\t--\n");
        }


        /// <summary>
        /// Write a paragraph within ">  <" borders. Auto formats to double space.
        /// </summary>
        /// <param name="paragraph"></param>
        public static string FormatWithBorder2(string paragraph)
        {
            return ("\n >\t\t\t\t\t\t\t\t\t\t\t\t<\n") +
            (string.Format("\n{0, -5}", DoubleSpace(paragraph))) +
            ("\n >\t\t\t\t\t\t\t\t\t\t\t\t<\n");
        }


        /// <summary>
        /// Writes a list within ">  <" borders. Each item preceded by "-".
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="list"></param>
        public static string FormatListWithBorder2(List<string> list, string title)
        {
            var output = ($"\n\n {title}:\n") +
                ("\n >\t\t\t\t\t\t\t\t\t\t\t\t<\n");

            foreach (var item in list)
            {
                output += (string.Format("\n{0, 8} {1, -8}", "-", item));
            }
           
            output += ("\n\n >\t\t\t\t\t\t\t\t\t\t\t\t< \n");

            return output;
        }


        /// <summary>
        /// Writes a list within ">  <" borders. Each item preceded by "[]". AutoFormatted to single space.
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="list"></param>
        public static string FormatWithBorder2_1(List<string> list, string title)
        {
            var output = ($"\n {title}:\n") +
                ("\n >\t\t\t\t\t\t\t\t\t\t\t\t<\n");

            foreach (var item in list)
            {
                output += (string.Format("\n{0, 8} {1, -10}\n", "[]", SingleSpace(item)));
            }

            output += ("\n >\t\t\t\t\t\t\t\t\t\t\t\t< \n");
            return output;
        }


        /// <summary>
        /// Displays a two collum table within "--  --" borders. Uses parameter lists of string. 
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="listL"></param>
        /// <param name="listR"></param>
        /// <param name="title"></param>
        public static string FormatTwoColTable(List<string> listL, List<string> listR, string title)
        {
            var output = ($"\n{title}:\n\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n");

            for (int i = 0; i < listL.Count; i++)
            {
                output += (string.Format("\n\t\t  {0, 28}  |  {1, -28}", listL[i], listR[i])) +
                    (string.Format(string.Format("\n{0,-100}",
                string.Format("\n{0," + ((100 + 71) / 2).ToString() + "}", 
                "-----------------------------------------------------------------------"))));
            }

            output += ("\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n");
            return output;
        }


        /// <summary>
        /// Returns a banner for Game Guide App.
        /// </summary>
        public static string GameGuideTitle()
        {
            return 
                (string.Format("\n{0,-30}",
                    string.Format("{0," + ((30 + 19) / 2).ToString() + "}", " __________________"))) +

                (string.Format("\n{0,-32}",
                    string.Format("{0," + ((32 + 19) / 2).ToString() + "}", "|  GAME GUIDE APP  |"))) +

                (string.Format("\n{0,-30}",
                    string.Format("{0," + ((30 + 19) / 2).ToString() + "}", " __________________")));
        }


        /// <summary>
        /// Display "  0: Exit" or " 0:  Back" on a line with a line space.
        /// </summary>
        public static string FormatExitOrBack(IMenu menu)
        {
            if (menu == null) return string.Empty;
            if (menu is IMainMenu) return ("    0:  Exit\n");
            return ("    0:  Back\n");
        }

        public static void FormatMenuListDescending(List<IMenu> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(string.Format("\n   {0, 2}{1, 1}{2, -4}", i + 1, ":  ", list[i].MenuTitle + "\n"));
            }
        }

        public static string FormatSubMenuDescending(IMenu_SubMenus menu)
        {
            var i = 1;
            var output = string.Empty;
            foreach (IMenu submenu in menu.SubMenus)
            {
                output += (string.Format("\n   {0, 2}{1, 1}{2, -4}", i++, ":  ", submenu.MenuTitle + "\n"));
            }
            return output;
        }
    }
}
