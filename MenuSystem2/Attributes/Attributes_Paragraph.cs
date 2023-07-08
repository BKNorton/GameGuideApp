using GameGuideApp.MenuSystem.Attributes.Interfaces;

namespace GameGuideApp.MenuSystem.Attributes
{
    public class Attributes_Paragraph : Attributes, IAttributes_Paragraph
    {
        public string Paragraph { get; set; } = string.Empty;
    }
}
