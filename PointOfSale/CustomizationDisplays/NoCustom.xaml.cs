/*
* Author: Matthew Sinclair
* Class name: NoCustom.xaml.cs
* Purpose: Creates a screen interactions for T-bone with customization options
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

namespace PointOfSale.CustomizationDisplays
{
    /// <summary>
    /// Interaction logic for NoCustom.xaml
    /// </summary>
    public partial class NoCustom : UserControl
    {
        /// <summary>
        /// Builds the screen and its many xaml components
        /// </summary>
        public NoCustom()
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
            var o = this.FindAncestor<Order>();
            o.DisplayUpdate(display);
        }

    }
}
