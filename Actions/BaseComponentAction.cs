using AtmDesigner.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AtmDesigner.Actions
{
    public class BaseComponentAction
    {
        public static List<IListable> GetComponents()
        {
            //Read FileNames
            string[] componentNames = Directory.GetDirectories(BaseComponent.BASE_PATH);
            List<IListable> Components = new List<IListable>();
            foreach (var itemType in componentNames)
            {
                if (itemType.Contains("AtmButton"))
                {
                    foreach (var itemPath in Directory.GetFiles(BaseComponent.BASE_PATH + itemType))
                    {
                        using (Stream stream = File.OpenRead(itemPath)) {
                            BitmapDecoder decoder = BitmapDecoder.Create(stream, BitmapCreateOptions.IgnoreColorProfile, BitmapCacheOption.Default);
                            Components.Add(new AtmButton(Path.GetFileName(itemPath), decoder.Frames[0].PixelHeight, decoder.Frames[0].PixelWidth));
                        }
                    }
                }
                else if (itemType.Contains("AtmContainer"))
                {
                    foreach (var itemPath in Directory.GetFiles(BaseComponent.BASE_PATH + itemType)) {
                        using (Stream stream = File.OpenRead(itemPath)) {
                            BitmapDecoder decoder = BitmapDecoder.Create(stream, BitmapCreateOptions.IgnoreColorProfile, BitmapCacheOption.Default);
                            Components.Add(new AtmContainer(Path.GetFileName(itemPath), decoder.Frames[0].PixelHeight, decoder.Frames[0].PixelWidth));
                        }
                    }
                }
                else if (itemType.Contains("AtmGrid"))
                {
                    foreach (var itemPath in Directory.GetFiles(BaseComponent.BASE_PATH + itemType)) {
                        using (Stream stream = File.OpenRead(itemPath)) {
                            BitmapDecoder decoder = BitmapDecoder.Create(stream, BitmapCreateOptions.IgnoreColorProfile, BitmapCacheOption.Default);
                            Components.Add(new AtmGrid(Path.GetFileName(itemPath), decoder.Frames[0].PixelHeight, decoder.Frames[0].PixelWidth));
                        }
                    }
                }
                //else if (itemType.Contains("AtmLabel"))
                //{
                //    foreach (var itemPath in Directory.GetFiles(BaseComponent.BASE_PATH + itemType)) {
                //        using (Stream stream = File.OpenRead(itemPath)) {
                //            BitmapDecoder decoder = BitmapDecoder.Create(stream, BitmapCreateOptions.IgnoreColorProfile, BitmapCacheOption.Default);
                //            Components.Add(new AtmLabel(Path.GetFileName(itemPath), decoder.Frames[0].PixelHeight, decoder.Frames[0].PixelWidth));
                //        }
                //    }
                //}
                else if (itemType.Contains("AtmTextBox"))
                {
                    foreach (var itemPath in Directory.GetFiles(BaseComponent.BASE_PATH + itemType)) {
                        using (Stream stream = File.OpenRead(itemPath)) {
                            BitmapDecoder decoder = BitmapDecoder.Create(stream, BitmapCreateOptions.IgnoreColorProfile, BitmapCacheOption.Default);
                            Components.Add(new AtmTextBox(Path.GetFileName(itemPath), decoder.Frames[0].PixelHeight, decoder.Frames[0].PixelWidth));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Item Class Couldn't be found. Check item name or class existence!");
                }
            }
            return Components;
        }
    }
}
