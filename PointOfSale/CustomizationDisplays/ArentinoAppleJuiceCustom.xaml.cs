/*
* Author: Matthew Sinclair
* Class name: AretinoAppleJuiceCustom.xaml.cs
* Purpose: Creates a screen interactions for apple juice customization
*/
using BleakwindBuffet.Data;
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

namespace PointOfSale.CustomizationDisplays
{
    /// <summary>
    /// Interaction logic for ArentinoAppleJuiceCustom.xaml
    /// </summary>
    public partial class ArentinoAppleJuiceCustom : UserControl
    {
        /// <summary>
        /// Builds the screen and its many xaml components
        /// </summary>
        public ArentinoAppleJuiceCustom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the Customization screen back to Menu Selection
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event</param>
        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            FrameworkElement display = new MenuSelection();
            var o = this.FindAncestor<OrderControl>();
            var item = (IOrderItem)this.DataContext;
            if(item.newItem) {
                ((Order)o.DataContext).Add((IOrderItem)this.DataContext);
                item.newItem = false;
            }
            o.DisplayUpdate(display);
        }
    }
}
