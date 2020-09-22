using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtmDesigner.Entities;

namespace BroccoliSchemer.Entities {
    public class AtmTextBlock : BaseComponent, IListable {
        public AtmTextBlock(string name, int height, int width) : base(name, height, width) {
        }
    }
}
