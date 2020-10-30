using RoundRegister;
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
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl
    {
        public CashControl(OrderControl order)
        {
            InitializeComponent();
            oc = order;
            CashDrawer.ResetDrawer();
            //(DataContext as RoundRegisterModelView).TotalValueChanged += new EventHandler(updateTotal);
            //Total.Text = String.Format("Enter cash to pay the Order Total: {0:C}", oc.T);
//          GoalTotalText.Text = String.Format("Cash entered so far: {0:C}", (DataContext as RoundRegisterModelView).TotalValue);
        }


        public OrderControl oc { get; set; }

        public double Total { get; set; }
    }
}
