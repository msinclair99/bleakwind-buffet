/*
* Author: Matthew Sinclair
* Class name: SizeCustom.xaml.cs
* Purpose: Creates a screen interactions for Size customization
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.CustomizationDisplays
{
    /// <summary>
    /// Interaction logic for SizeCustom.xaml
    /// </summary>
    public partial class SizeCustom : UserControl
    {
        /// <summary>
        /// Builds the screen and its many xaml components
        /// </summary>
        public SizeCustom()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Updates the properties for a change of a size using the radio buttons
        /// </summary>
        /// <param name="sender">radio button</param>
        /// <param name="e">event</param>
        private void SizeClickChange(object sender, RoutedEventArgs e)
        {
            Size s;

            switch((sender as RadioButton).Name)
            {
                case "SizeSmall":
                    s = Size.Small;
                    break;

                case "SizeMedium":
                    s = Size.Medium;
                    break;
                case "SizeLarge":
                    s = Size.Large;
                    break;
                default:
                    throw new NotImplementedException("Default should not get here");
            }

            if(DataContext is Side)
            {
                Side sd = (Side)DataContext;
                sd.Size = s;
            }
            if(DataContext is Drink)
            {
                Drink dk = (Drink)DataContext;
                dk.Size = s;
            }

        }
    }
}
