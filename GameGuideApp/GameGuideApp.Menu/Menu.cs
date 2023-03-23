namespace GameGuideApp
{
    public class Menu 
    {
        public string prompt;
        public string menuTitle;
        public List<Menu> subMenus;
        
        public Menu() 
        {
            prompt = string.Empty;
            menuTitle = string.Empty;
            subMenus = new List<Menu>();
        }

        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-30}",
                String.Format("{0," + ((30 + menuTitle.Length) / 2).ToString() + "}", menuTitle)));
            Console.WriteLine(String.Format("{0,-30}",
                String.Format("{0," + ((30 + prompt.Length) / 2).ToString() + "}", prompt)));
            Console.WriteLine("_________________________________\n");

            for (int i = 0; i < subMenus.Count; i++)
            {
                Console.WriteLine(String.Format("{0,-50}", $"  - {i + 1} :  {subMenus[i].menuTitle}\n"));
            }
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
    }
}
