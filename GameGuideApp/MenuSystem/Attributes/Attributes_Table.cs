

using GameGuideApp.MenuSystem.Attributes.Interfaces;

namespace GameGuideApp.MenuSystem.Attributes
{
    internal class Attributes_Table : Attributes, IAttributes_Table
    {
        public List<string[]> Table { get; set; }
        public string[] Rows { get; set; }

        public int CollumnCount { get; set; }

        public Attributes_Table(int colSize)
        {
            Rows = new string[colSize];
            CollumnCount = colSize;
            Table = new List<string[]>();
        }
    }
}
