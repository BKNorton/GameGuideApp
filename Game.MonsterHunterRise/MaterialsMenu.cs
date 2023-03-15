using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    public class MaterialsMenu : Menu
    {
        public MaterialsMenu()
        {
            //Parent Properties
            menuTitle = "Materials";
            prompt = "Select a Material";
            subMenus = new List<Menu>();

            //Class Properies

            //Add Menu options
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
