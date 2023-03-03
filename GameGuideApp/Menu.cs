using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameGuideApp
{
    class Menu
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
            Console.WriteLine(menuTitle);
            Console.WriteLine(prompt);

            for (int i = 0; i < subMenus.Count; i++)
            {
                Console.WriteLine($"- {i + 1} : {subMenus[i].menuTitle}");
            }
            Console.WriteLine("- 0 : Back");
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
