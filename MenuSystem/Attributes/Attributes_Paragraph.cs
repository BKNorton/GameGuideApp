using MenuSystem.Attributes.Interfaces;

namespace MenuSystem.Attributes
{
    public class Attributes_Paragraph : Attributes, IAttributes_Paragraph
    {
        public string Paragraph { get; set; } = string.Empty;
    }
}
