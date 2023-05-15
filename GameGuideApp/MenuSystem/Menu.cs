namespace GameGuideApp
{
    /// <summary>
    /// Base class for all displayable Menu objects.
    /// </summary>
    public class Menu 
    {
        public string menuTitle;
        public string prompt;
        public List<Menu> subMenus;
        
        public Menu() 
        {
            prompt = string.Empty;
            menuTitle = string.Empty;
            subMenus = new List<Menu>();
        }

        public bool Equals(Menu menu)
        {
            if (menuTitle == menu.menuTitle) return true;
            else return false;
        }

        public bool IsEmpty()
        {
            if (menuTitle == string.Empty) return true;
            else return false;
        }

        public virtual void Display()
        {
            //Center and write menutitle and prompt
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-32}",
                String.Format("{0," + ((32 + menuTitle.Length) / 2).ToString() + "}", menuTitle)));
            Console.WriteLine(String.Format("{0,-32}",
                String.Format("{0," + ((32 + prompt.Length) / 2).ToString() + "}", prompt)));
            Console.WriteLine("_________________________________\n");

            //Display subMenus menuTitle and menu number
            for (int i = 0; i < subMenus.Count; i++)
            {
                Console.WriteLine(String.Format("{0, -6}{1, 1}{2, -4}", "  - " + (i+1), " : ", subMenus[i].menuTitle + "\n"));
                //Console.WriteLine(String.Format("{0,50}", $":  {subMenus[i].menuTitle}\n"));
            }
            //Does not display Exit or Back (0). This must be added to all child classes.
            //Any Menu other than MainMenu or a GameMenu must add this to the Display method
        }
    }
}
