using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDesigner.Entities
{
    public class AtmGrid : BaseComponent, IListable {
        public AtmGrid(string name, int height, int width) : base(name, height, width) 
        {

        }
    }
}
