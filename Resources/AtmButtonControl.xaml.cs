using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using AtmDesigner.Entities;

namespace AtmDesigner.Resources {
    /// <summary>
    /// Interaction logic for AtmButtonControl.xaml
    /// </summary>
    public partial class AtmButtonControl : UserControl {
        public AtmButtonControl(AtmButton atmButton) {
            InitializeComponent();
            ButtonText0 = atmButton.Text0;
            ButtonText1 = atmButton.Text1;
            ButtonText2 = atmButton.Text2;
            ButtonText3 = atmButton.Text3;
            Text0Color = atmButton.Text0Color.ToString() != "#00000000" ? atmButton.Text0Color : Colors.White;
            Text1Color = atmButton.Text1Color.ToString() != "#00000000" ? atmButton.Text1Color : Colors.White;
            Text2Color = atmButton.Text2Color.ToString() != "#00000000" ? atmButton.Text2Color : Colors.White;
            Text3Color = atmButton.Text3Color.ToString() != "#00000000" ? atmButton.Text3Color : Colors.White;
            MainText.Text = atmButton.MainText;
            ImagePath = atmButton.ImagePath;
            Name = atmButton.Name + DateTime.Now.Ticks;
            ButtonImage.SetValue(NameProperty, Name);
            MainText.SetValue(NameProperty, Name);
            Text0.SetValue(NameProperty, Name);
            Text1.SetValue(NameProperty, Name);
            Text2.SetValue(NameProperty, Name);
            Text3.SetValue(NameProperty, Name);
            IsRightButton = atmButton.IsRightButton;
            if (IsRightButton) {
                ButtonGrid.HorizontalAlignment = HorizontalAlignment.Right;
            }
        }
        public string ButtonText0
        {
            get
            {
                return Text0.Text.ToString();
            }
            set
            {
                Text0.Text = value;
            }
        }
        public string ButtonText1
        {
            get
            {
                return Text1.Text.ToString();
            }
            set
            {
                Text1.Text = value;
            }
        }
        public string ButtonText2
        {
            get
            {
                return Text2.Text.ToString();
            }
            set
            {
                Text2.Text = value;
            }
        }
        public string ButtonText3
        {
            get
            {
                return Text3.Text.ToString();
            }
            set
            {
                Text3.Text = value;
            }
        }
        public string ImagePath
        {
            set
            {
                ButtonImage.Background = new ImageBrush(new BitmapImage(new Uri(value, UriKind.Relative)));
            }
        }
        public bool IsRightButton { get; set; }
        public Color Text0Color {
            set
            {
                Text0.Foreground = new SolidColorBrush(value);
            }
        }
        public Color Text1Color
        {
            set
            {
                Text1.Foreground = new SolidColorBrush(value);
            }
        }
        public Color Text2Color
        {
            set
            {
                Text2.Foreground = new SolidColorBrush(value);
            }
        }
        public Color Text3Color
        {
            set
            {
                Text3.Foreground = new SolidColorBrush(value);
            }
        }
    }
}
