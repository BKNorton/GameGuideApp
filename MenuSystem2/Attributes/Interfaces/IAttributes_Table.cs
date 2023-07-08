
namespace GameGuideApp.MenuSystem.Attributes.Interfaces
{
    public interface IAttributes_Table : IAttributes
    {
        public List<string[]> Table { get; set; }
        public int CollumnCount { get; set; }
        public string[] Rows { get; set; }
    }
}
