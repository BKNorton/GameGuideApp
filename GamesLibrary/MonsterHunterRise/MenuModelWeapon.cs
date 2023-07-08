using GameGuideApp.MenuSystem.Attributes;
using GameGuideApp.MenuSystem.Attributes.Interfaces;
using GameGuideApp.MenuSystem.MenuTemplates;

namespace GameGuideApp.GamesLibrary
{
    public class MenuModelWeapon : Menu_Model
    {
        IAttributes_Paragraph Desctription { get; set; }
        IAttributes_Table Combos { get; set; }

        public MenuModelWeapon(Weapon model) : base(model)
        {
            Attributes = new List<IAttributes>();
            Desctription = new Attributes_Paragraph() { Name = "Description" }; Desctription.Paragraph = model.Description; Attributes.Add(Desctription);

            Combos = new Attributes_Table(2) { Name = "Combos" }; 
            for (int i = 0; i < model.Button_Basic.Count;  i++)
            {
                Combos.Rows[0] = model.Button_Basic[i];
                Combos.Rows[1] = model.Attack_Basic[i];
                string[] row = new string[] { Combos.Rows[0], Combos.Rows[1] };
                Combos.Table.Add(row);
            }
            Attributes.Add(Combos);
        }
    }
}
