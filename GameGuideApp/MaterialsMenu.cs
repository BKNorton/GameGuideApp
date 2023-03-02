using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp
{
    class MaterialsMenu : Menu
    {
        public MaterialsMenu()
        {
            //Parent Properties
            menuTitle = "Materials";
            prompt = "Select a Material";

            //Class Properies
            subMenus = new List<Menu>();

            //Add Menu options
        }

        public void Display()
        {
            base.Display();
        }
    }
}
