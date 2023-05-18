using GameGuideApp.MenuSystem;
using GameGuideApp.Utilities;

namespace GameGuideApp.Games.MonsterHunterRise
{
    public class Weapon : MenuLast
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Button_Basic { get; set; }
        public List<string> Attack_Basic { get; set; }

        public override void Display()
        {
            //Name & Description
            string tempDescription = FormatController.DoubleSpace(Description);
            Console.WriteLine(string.Format("\n{0, 55}\n", Name.ToUpper())
            + "   ___________________________________________________________________________________________");
            Console.WriteLine("\n--\t\t\t\t\t\t\t\t\t\t\t\t--");
            Console.WriteLine(string.Format("\n{0, -5}", tempDescription));
            Console.WriteLine("\n--\t\t\t\t\t\t\t\t\t\t\t\t--");

            //Basic Attacks
            Console.WriteLine("\nBasic Attacks:\n\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n");
            for (int i = 0; i< Button_Basic.Count; i++)
            {
                Console.WriteLine(string.Format("\t\t  {0, 28}  |  {1, -28}", Attack_Basic[i], Button_Basic[i]));
                Console.WriteLine(string.Format(string.Format("{0,-100}",
                string.Format("{0," + ((100 + 71) / 2).ToString() + "}", "-----------------------------------------------------------------------")))); 
            }
            Console.WriteLine("\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n");


            Console.WriteLine("\n  - 0 : Back\n");
        }
    }
}
