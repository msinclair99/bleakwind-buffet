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
    /// Interaction logic for ComboCustom.xaml
    /// </summary>
    public partial class ComboCustom : UserControl
    {
        public ComboCustom()
        {
            InitializeComponent();
        }

        private void DrinkSelection(object sender, RoutedEventArgs e)
        {
            MenuSelection display = new MenuSelection();
            display.PickDrink();
            var o = this.FindAncestor<OrderControl>();
            o.DisplayUpdate(display);
        }

        private void EntreeSelection(object sender, RoutedEventArgs e)
        {
            MenuSelection display = new MenuSelection();
            display.PickEntree();
            var o = this.FindAncestor<OrderControl>();
            o.DisplayUpdate(display);
        }

        private void SideSelection(object sender, RoutedEventArgs e)
        {
            MenuSelection display = new MenuSelection();
            display.PickSide();
            var o = this.FindAncestor<OrderControl>();
            o.DisplayUpdate(display);
        }


        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            FrameworkElement display = new MenuSelection();
            var o = this.FindAncestor<OrderControl>();
            var item = (IOrderItem)this.DataContext;
            if (item.newItem)
            {
                ((Order)o.DataContext).Add((IOrderItem)this.DataContext);
                item.newItem = false;
            }
            o.DisplayUpdate(display);
        }




    }
}
