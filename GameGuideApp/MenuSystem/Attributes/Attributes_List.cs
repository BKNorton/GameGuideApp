

using GameGuideApp.MenuSystem.Attributes.Interfaces;

namespace GameGuideApp.MenuSystem.Attributes
{
    internal class Attributes_List : Attributes, IAttributes_List
    {
        public List<string> AttributesList { get; set; }
    }
}
