namespace GameGuideApp
{
    public class Weapon : LastMenu
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Button_Basic { get; set; }
        public List<string> Attack_Basic { get; set; }

        public Weapon()
        {
            //Parent Properties
            prompt = string.Empty;
            menuTitle = Name!;

            //Class Properties
            Name = string.Empty;
            Description = string.Empty;
            Button_Basic = new List<string>();
            Attack_Basic = new List<string>();
        }

        public override void Display()
        {
            //Name & Description
            Console.WriteLine(String.Format("\n{0, 55}\n", Name.ToUpper()) +
                "__________________________________________________________________________________________________" +
                $"\n\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n{Description}\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n\n ");
            //Basic Attacks
            Console.WriteLine("Basic Attacks:\n\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n");
            for (int i = 0; i< Button_Basic.Count; i++)
            {
                Console.WriteLine(String.Format("\t\t  {0, 28}  |  {1, -28}", Attack_Basic[i], Button_Basic[i]));
                Console.WriteLine(String.Format(String.Format("{0,-100}",
                String.Format("{0," + ((100 + 71) / 2).ToString() + "}", "-----------------------------------------------------------------------")))); 
            }
            Console.WriteLine("\n--\t\t\t\t\t\t\t\t\t\t\t\t-- \n");


            Console.WriteLine("\n  - 0 : Back\n");
        }
    }
}
