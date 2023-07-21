using MenuSystem.Attributes.Interfaces;

namespace MenuSystem.Attributes
{
    public class Attributes_List : Attributes, IAttributes_List
    {
        public List<string> AttributesList { get; set; } = new List<string>();
    }
}
