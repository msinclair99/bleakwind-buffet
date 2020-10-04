/*
* Author: Matthew Sinclair
* Class name: Order.xaml.cs
* Purpose: Creates a screen for Ordering
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
using PointOfSale.CustomizationDisplays;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        public void DisplayUpdate(FrameworkElement display)
        {
            LeftContainer.Child = display;
        }

        public void CancelButton(object sender, RoutedEventArgs e)
        {
            if (LeftContainer.Child is MenuSelection)
            {
                throw new NotImplementedException("Cannot cancel an order yet");
            }
            else
            {
                LeftContainer.Child = new MenuSelection();
            }
        }
    }
}
