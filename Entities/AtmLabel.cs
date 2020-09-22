using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDesigner.Entities
{
    public class AtmLabel : BaseComponent, IListable
    {
        public AtmLabel(string name, int height, int width) : base(name, height, width) 
        {

        }
        public string Text { get; set; } = "Label";
    }
}
