using GameGuideApp.MenuSystem.Attributes.Interfaces;

namespace GameGuideApp.MenuSystem.Attributes
{
    public class Attributes_List : Attributes, IAttributes_List
    {
        public List<string> AttributesList { get; set; } = new List<string>();
    }
}
