/*
* Author: Matthew Sinclair
* Class name: OrderControl.xaml.cs
* Purpose: Creates a screen for Ordering
*/
using BleakwindBuffet.Data;
using PointOfSale.CustomizationDisplays;
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
        public uint orderNum = 1;
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
            LeftContainer.Child = new PaymentMethod();
            //this.DataContext = new Order(orderNum);
           
        }

        public void CancelButton(object sender, RoutedEventArgs e)
        {
            if (LeftContainer.Child is MenuSelection)
            {
                MenuSelection ms = (MenuSelection)LeftContainer.Child;
                if(ms.ComboCreate.IsEnabled) {
                    orderNum++;
                    this.DataContext = new Order(orderNum);
                }
                else
                {
                    try
                    {
                        var c = this.FindAncestor<ComboCustom>();
                        var x = (IOrderItem)c.DataContext;

                        var elem = (FrameworkElement)x.Display;
                        this?.DisplayUpdate(elem);
                    }
                    catch { }
                }
            }
            else
            {
                LeftContainer.Child = new MenuSelection();
            }
        }
    }
}
