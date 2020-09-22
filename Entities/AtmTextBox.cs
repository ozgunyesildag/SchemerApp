using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDesigner.Entities
{
    public class AtmTextBox : BaseComponent, IListable
    {
        public AtmTextBox(string name, int height, int width) : base(name, height, width) 
        {

        }
        public string Placeholder { get; set; }
    }
}
