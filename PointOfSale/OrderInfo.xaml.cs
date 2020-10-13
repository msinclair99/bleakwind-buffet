/*
* Author: Matthew Sinclair
* Class name: OrderInfo.xaml.cs
* Purpose: Creates a screen for order information
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
using BleakwindBuffet.Data;
using PointOfSale.CustomizationDisplays;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderInfo.xaml
    /// </summary>
    public partial class OrderInfo : UserControl
    {
        public OrderInfo()
        {
            InitializeComponent();
        }

        public void RemoveItemButton(object sender, RoutedEventArgs e)
        {

            Order o = (Order)DataContext;
            IOrderItem item = (IOrderItem)((Button)sender).DataContext;
            o.Remove(item);
        }

        void OrderListSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            FrameworkElement elem;
            IOrderItem item = (IOrderItem)((ListBox)sender).SelectedItem;
            var orderControl = this.FindAncestor<OrderControl>();
            if (item != null)
               
                elem = (FrameworkElement)item.Display;
            else
                elem = new MenuSelection();
            orderControl?.DisplayUpdate(elem);
        }
    

}
}
