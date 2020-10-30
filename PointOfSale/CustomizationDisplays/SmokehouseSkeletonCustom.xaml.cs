/*
* Author: Matthew Sinclair
* Class name: SmokehouseSkeletonCustom.xaml.cs
* Purpose: Creates a screen interactions for smokehouse skeleton customization
*/
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for SmokehousrSkeletonCustom.xaml
    /// </summary>
    public partial class SmokehousrSkeletonCustom : UserControl
    {
        /// <summary>
        /// Builds the screen and its many xaml components
        /// </summary>
        public SmokehousrSkeletonCustom()
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
            if (item.newItem)
            {
                /*try
                {
                    
                    var c = this.<ComboCustom>();
                    ((Combo)c.DataContext).ComboEntree = (Entree)this.DataContext;
                }*/
                //catch {              
                    ((Order)o.DataContext).Add((IOrderItem)this.DataContext);
                //}
                item.newItem = false;
            }
            o.DisplayUpdate(display);
        }
    }
}
