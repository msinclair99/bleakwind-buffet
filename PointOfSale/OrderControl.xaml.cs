/*
* Author: Matthew Sinclair
* Class name: OrderControl.xaml.cs
* Purpose: Creates a screen for Ordering
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        uint orderNum = 1;
        public OrderControl()
        {
            this.DataContext = new Order(orderNum);
            InitializeComponent();
        }
        public void DisplayUpdate(FrameworkElement display)
        {
            LeftContainer.Child = display;
        }

        public void SubmitButton(object sender, RoutedEventArgs e )
        {
            orderNum++;
            this.DataContext = new Order(orderNum);
            throw new NotImplementedException("Cannot finish order Proccessing");
        }

        public void CancelButton(object sender, RoutedEventArgs e)
        {
            if (LeftContainer.Child is MenuSelection)
            {
                orderNum++;
                this.DataContext = new Order(orderNum);
            }
            else
            {
                LeftContainer.Child = new MenuSelection();
            }
        }
    }
}
