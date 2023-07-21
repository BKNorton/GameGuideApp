using GameGuideApp.MenuSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuideApp.MenuSystem
{
    public class Model : IModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<List<string>> Attributes { get; set; }
    }
}
