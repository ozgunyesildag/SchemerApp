using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDesigner.Entities
{
    public class AtmContainer : BaseComponent, IListable {
        public AtmContainer(string name, int height, int width) : base(name, height, width) 
        {

        }
    }
}
