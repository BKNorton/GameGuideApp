
using GameGuideApp.MenuSystem;
using GameGuideApp.Utilities;

namespace GameGuideApp.Games.MonsterHunterRise
{

    public class Monster : MenuLast
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> WeakPoints { get; set; }
        //public Dictionary<int , string> Ailments { get; set; }
        public List<string> Tips_Gear { get; set; }
        public List<string> Tips_Combat { get; set; }


        public override void Display()
        {
            //Format strings
            string tempDescription = FormatController.DoubleSpace(Description);


            //Name & Description
            Console.WriteLine(string.Format("\n{0, 55}\n", Name.ToUpper())
            + "   ___________________________________________________________________________________________");
            Console.WriteLine( "\n >\t\t\t\t\t\t\t\t\t\t\t\t<" );
            Console.WriteLine(string.Format("\n{0, -5}", tempDescription));
            Console.WriteLine( "\n >\t\t\t\t\t\t\t\t\t\t\t\t<" );


            //WeakPoints
            Console.WriteLine("\n\n Weak Points:\n");
            Console.WriteLine(" >\t\t\t\t\t\t\t\t\t\t\t\t<\n");
            foreach (var item in WeakPoints)
            {
                Console.WriteLine(string.Format("{0, 8} {1, -8}", "-", item));
            }
            Console.WriteLine("\n >\t\t\t\t\t\t\t\t\t\t\t\t< \n");


            //Gear Tips
            Console.WriteLine( "\n Gear Tips:\n" );
            Console.WriteLine( " >\t\t\t\t\t\t\t\t\t\t\t\t<" );
            foreach (var item in Tips_Gear)
            {
                string tempTip = FormatController.SingleSpace(item);
                Console.WriteLine(string.Format("\n{0, 8} {1, -10}", "[]", tempTip));
            }
            Console.WriteLine( "\n >\t\t\t\t\t\t\t\t\t\t\t\t< \n" );


            //Combat Tips
            Console.WriteLine( "\n Combat Tips:\n" );
            Console.WriteLine( " >\t\t\t\t\t\t\t\t\t\t\t\t<" );
            foreach (var item in Tips_Combat)
            {
                string tempTip = FormatController.SingleSpace(item);
                Console.WriteLine(string.Format( "\n{0, 8} {1, -10}", "[]", tempTip ));
            }
            Console.WriteLine( "\n >\t\t\t\t\t\t\t\t\t\t\t\t< \n" );

            Console.WriteLine( "\n  - 0 : Back\n" );
        }
    }
}
