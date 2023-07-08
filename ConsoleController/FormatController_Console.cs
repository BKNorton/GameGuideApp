using GameGuideApp.MenuSystem.Attributes.Interfaces;
using GameGuideApp.MenuSystem.MenuTemplates.Interfaces;

namespace ConsoleController
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

        public static string StyleBorder(string markerL, string markerR)
        {
            return $"\n{markerL}\t\t\t\t\t\t\t\t\t\t\t\t{markerR}\n";
        }

        public static string FormatAttributeTitle(IAttributes att)
        {
            return $"\n {att.Name}:\n";
        }

        /// <summary>
        /// Returns MenuTitle of menu passed into the parameter in all caps with a solid line underneath.
        /// </summary>
        /// <param name="title"></param>
        public static string FormatMenuTitle(IMenu menu)
        {
            return string.Format("\n{0, 55}\n", menu.MenuTitle.ToUpper())
            + "   ___________________________________________________________________________________________\n";
        }

        /// <summary>
        /// Takes in a IMenu object and returns the MenuTitle and Prompt as a string, formatted for the console.
        /// </summary>
        /// <param name="menuTitle"></param>
        /// <param name="prompt"></param>
        public static string FormatMenuHeader(IMenu menu)
        {
            //Center and write menutitle and prompt
            return
                // MenuTitle
                string.Format("{0,-32}",
                    string.Format("{0," + ((32 + menu.MenuTitle.Length) / 2).ToString() + "}", menu.MenuTitle)) + "\n" +
                // Prompt
                string.Format("{0,-32}",
                    string.Format("{0," + ((32 + menu.Prompt.Length) / 2).ToString() + "}", menu.Prompt)) + "\n" +
                "_________________________________\n";
        }

        /// <summary>
        /// Write a IAttribute_Paragraph within "--  --" borders. Auto formats to double space.
        /// </summary>
        /// <param name="paragraph"></param>
        public static string FormatWithBorder1(IAttributes_Paragraph paragraph)
        {
            return FormatAttributeTitle(paragraph) + StyleBorder("--", "--") +
            string.Format("\n{0, -5}\n", DoubleSpace(paragraph.Paragraph)) +
            StyleBorder("--", "--");
        }

        /// <summary>
        /// Writes a IAttribute_List within "--  --" borders. Each item preceded by "-".
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="list"></param>
        public static string FormatWithBorder1(IAttributes_List att)
        {
            string output = FormatAttributeTitle(att);
            output += StyleBorder("--", "--");
            foreach (var item in att.AttributesList)
            {
                output += string.Format("\n{0, 8} {1, -8}", "-", item);
            }
            output += StyleBorder("--", "--");
            return output;
        }

        /// <summary>
        /// Writes a IAttribute_List within "--  --" borders. Each item preceded by "[]". AutoFormatted to single space.
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="list"></param>
        public static string FormatWithBorder1_1(IAttributes_List att)
        {
            var output = FormatAttributeTitle(att);
            output += StyleBorder("--", "--");
            foreach (var item in att.AttributesList)
            {
                output += string.Format("\n{0, 8} {1, -10}\n", "[]", SingleSpace(item));
            }
            output += StyleBorder("--", "--");
            return output;
        }

        /// <summary>
        /// Write a IAttribute_Paragraph within ">  <" borders. Auto formats to double space.
        /// </summary>
        /// <param name="paragraph"></param>
        public static string FormatWithBorder2(IAttributes_Paragraph paragraph)
        {
            return FormatAttributeTitle(paragraph) + StyleBorder(" >", "< ") +
            string.Format("\n{0, -5}", DoubleSpace(paragraph.Paragraph)) +
            StyleBorder(" >", "< ");
        }

        /// <summary>
        /// Writes a IAttribute_List within "--", "--" borders. Each item preceded by "-".
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="list"></param>
        public static string FormatWithBorder2(IAttributes_List att)
        {
            string output = FormatAttributeTitle(att);
            output += StyleBorder("--", "--");
            foreach (var item in att.AttributesList)
            {
                output += string.Format("\n{0, 8} {1, -8}", "-", item);
            }
            output += StyleBorder(" >", "< ");
            return output;
        }

        /// <summary>
        /// Writes a IAttribute_List within ">  <" borders. Each item preceded by "[]". AutoFormatted to single space.
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="list"></param>
        public static string FormatWithBorder2_1(IAttributes_List att)
        {
            var output = FormatAttributeTitle(att);
            output += StyleBorder(" >", "< ");
            foreach (var item in att.AttributesList)
            {
                output += string.Format("\n{0, 8} {1, -10}\n", "[]", SingleSpace(item));
            }
            output += StyleBorder(" >", "< ");
            return output;
        }

        /// <summary>
        /// Displays a two collum table within "--  --" borders. Uses parameter lists of string. 
        /// Displays tile paramater above.
        /// </summary>
        /// <param name="listL"></param>
        /// <param name="listR"></param>
        /// <param name="title"></param>
        public static string FormatTwoColTable1(IAttributes_Table table)
        {
            var output = FormatAttributeTitle(table);
            output += StyleBorder("--", "--")
                + string.Format(string.Format("\n{0,-100}",
                      string.Format("\n{0," + ((100 + 71) / 2).ToString() + "}\n",
                    "-----------------------------------------------------------------------")));
            for (int i = 0; i < table.Table.Count; i++)
            {
                output += string.Format("\n\t\t  {0, 30}  |  {1, -30}", table.Table[i][0], table.Table[i][1])
                    + string.Format(string.Format("\n{0,-100}",
                      string.Format("{0," + ((100 + 71) / 2).ToString() + "}\n",
                    "-----------------------------------------------------------------------")));
            }
            output += StyleBorder("--", "--");
            return output;
        }

        /// <summary>
        /// Displays a two collum table within " >  < " borders.  
        /// Displays Name of attribute that is passed into the parameter.
        /// </summary>
        /// <param name="listL"></param>
        /// <param name="listR"></param>
        /// <param name="title"></param>
        public static string FormatTwoColTable2(IAttributes_Table table)
        {
            var output = FormatAttributeTitle(table);
            output += StyleBorder(" >", "< ")
                + "-----------------------------------------------------------------------";
            for (int i = 0; i < table.Table.Count; i++)
            {
                output += string.Format("\n\t\t  {0, 28}  |  {1, -28}", table.Table.ElementAt(i)[0], table.Table.ElementAt(i)[1])
                    + string.Format(string.Format("\n{0,-100}",
                      string.Format("\n{0," + ((100 + 71) / 2).ToString() + "}",
                    "-----------------------------------------------------------------------")));
            }
            output += StyleBorder(" >", "< ");
            return output;
        }

        /// <summary>
        /// Returns a banner for Game Guide App.
        /// </summary>
        public static string GameGuideTitle()
        {
            return
                string.Format("\n{0,-30}",
                    string.Format("{0," + ((30 + 19) / 2).ToString() + "}", " __________________")) +

                string.Format("\n{0,-32}",
                    string.Format("{0," + ((32 + 19) / 2).ToString() + "}", "|  GAME GUIDE APP  |")) +

                string.Format("\n{0,-30}",
                    string.Format("{0," + ((30 + 19) / 2).ToString() + "}\n", " __________________"));
        }

        /// <summary>
        /// Display "  0: Exit" or " 0:  Back" on a line with a line space.
        /// </summary>
        public static string FormatExitOrBack(IMenu menu)
        {
            if (menu == null) return string.Empty;
            if (menu is IMainMenu) return "    0:  Exit\n";
            return "    0:  Back\n";
        }

        public static string FormatSubMenuDescending(IMenu_SubMenus menu)
        {
            var i = 1;
            var output = string.Empty;
            foreach (IMenu submenu in menu.SubMenus)
            {
                output += string.Format("\n   {0, 2}{1, 1}{2, -4}", i++, ":  ", submenu.MenuTitle + "\n");
            }
            return output;
        }
    }
}
