using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class Monster : LastMenu
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> WeakPoints { get; set; }
        //public Dictionary<int , string> Ailments { get; set; }
        public List<string> Tips_Gear { get; set; }
        public List<string> Tips_Combat { get; set; }

        public Monster() 
        {
            Name = string.Empty;
            Description = string.Empty;
            WeakPoints = new List<string>();
            //Ailments = new Dictionary<int, string>();
            Tips_Gear = new List<string>();
            Tips_Combat = new List<string>();
        }

        public override void Display()
        {
            //Name & Description
            Console.WriteLine(String.Format("\n{0, 55}\n", Name.ToUpper()) +
                "__________________________________________________________________________________________________" +
                $"\n\n >\t\t\t\t\t\t\t\t\t\t\t\t< \n{Description}\n >\t\t\t\t\t\t\t\t\t\t\t\t<");

            //WeakPoints
            Console.WriteLine("\n\n Weak Points:\n");
            Console.WriteLine(" >\t\t\t\t\t\t\t\t\t\t\t\t<\n");
            foreach ( var item in WeakPoints )
            {
                Console.WriteLine(String.Format("{0, 8} {1, -8}", "-", item));
            }
            Console.WriteLine(" >\t\t\t\t\t\t\t\t\t\t\t\t< \n");

            //Ailments
            //Console.WriteLine("Ailments: \n\n");
            //foreach (var item in Ailments)
            //{
            //    Console.WriteLine(String.Format("   - {0, -10} :  {1, -10}", item.Value, item.Key));
            //}

            //Gear Tips
            Console.WriteLine("\n Gear Tips:\n");
            Console.WriteLine(" >\t\t\t\t\t\t\t\t\t\t\t\t<");
            foreach (var item in Tips_Gear)
            {
                Console.WriteLine(String.Format("{0, 128} {1, -128}", "[]", item));
            }
            Console.WriteLine(" >\t\t\t\t\t\t\t\t\t\t\t\t< \n");

            //Combat Tips
            Console.WriteLine("\n Combat Tips:\n");
            Console.WriteLine(" >\t\t\t\t\t\t\t\t\t\t\t\t<");
            foreach (var item in Tips_Combat)
            {
                Console.WriteLine(String.Format("{0, 128} {1, -128}", "[]", item));
            }
            Console.WriteLine(" >\t\t\t\t\t\t\t\t\t\t\t\t< \n");

            Console.WriteLine("\n  - 0 :  Back\n");
        }
    }
}
