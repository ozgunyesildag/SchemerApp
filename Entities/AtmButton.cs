using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace AtmDesigner.Entities
{
    public class AtmButton : BaseComponent, IListable {
        public AtmButton(string name, int height, int width) : base(name, height, width) 
        {
            Name = Regex.Replace(Path.GetFileNameWithoutExtension(name), "[^a-zA-z]", "");
            ImagePath = BASE_PATH + GetType().Name + "/" + name;
            ScreenHeight = height;
            ScreenWidth = width;
            IsRightButton = name.Contains("Right") ? true : false;
        }
        public string Text0 { get; set; } = "Text0";
        public string Text1 { get; set; } = "Text1";
        public string Text2 { get; set; } = "Text2";
        public string Text3 { get; set; } = "Text3";
        public bool IsRightButton { get; set; }
        public Color Text0Color { get; set; }
        public Color Text1Color { get; set; }
        public Color Text2Color { get; set; }
        public Color Text3Color { get; set; }
        public string MainText { get; internal set; }
    }
}
