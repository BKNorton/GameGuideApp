using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class Weapon : LastMenu
    {
        //public Menu WeaponMenu;
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Button_Basic { get; set; }
        public List<string> Attack_Basic { get; set; }

        public Weapon()
        {
            prompt = string.Empty;
            menuTitle = Name;
        }

        public override void Display()
        {
            Console.WriteLine($"\n{Name.ToUpper()} " +
                $"\n\n--  \t\t\t\t\t\t\t\t\t\t  --\n {Description} " +
                $"\n--  \t\t\t\t\t\t\t\t\t\t  --\n\n Basic Attacks:\n");
            for (int i = 0; i< Button_Basic.Count; i++)
            {
                Console.WriteLine(String.Format("  {0, -25} |   {1, -25}", Attack_Basic[i], Button_Basic[i]));
                Console.WriteLine("  ---------------------------------------------------------------------");
            }
            Console.WriteLine("\n- 0 : Back");
        }

    }
}
