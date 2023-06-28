

using GameGuideApp.MenuSystem.Attributes.Interfaces;

namespace GameGuideApp.MenuSystem.Attributes
{
    internal class Attributes_ListSingle : Attributes_List, IAttributes_ListSingle
    {
        public List<string> AttributesList { get; set; }
    }
}
