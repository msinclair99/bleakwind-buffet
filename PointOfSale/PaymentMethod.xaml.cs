using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Security.Policy;
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
    /// Interaction logic for PaymentMethod.xaml
    /// </summary>
    public partial class PaymentMethod : UserControl
    {
        public PaymentMethod()
        {
            InitializeComponent();
        }


        private void CashSelection(object sender, RoutedEventArgs e)
        {
            var o = this.FindAncestor<OrderControl>();
            CashControl control = new CashControl(o);
            o.LeftContainer.Child = control;
        }

        private void CreditSelection(object sender, RoutedEventArgs e)
        {
            var o = this.FindAncestor<OrderControl>();
            uint Ordernum = ((OrderControl)o).orderNum;

            CardTransactionResult result = CardReader.RunCard((o.DataContext as Order).Total);

            if (result == CardTransactionResult.Approved)
            {
                RecieptPrinting();
                RecieptPrinter.CutTape();
                o.DataContext = new Order(Ordernum);
                o.LeftContainer.Child = new MenuSelection();
            }
            else
            {
                ErrorReport.Text = "Transaction Failed With: " + result.ToString() + "!";
            }
        }

        private void RecieptPrinting()
        {
            int spaces;
            StringBuilder sb = new StringBuilder();
            Order o = (this.DataContext as Order);

            for (int i = 0; i < 45; i++)
            {
                sb.Append("_");
            }
            RecieptPrinter.PrintLine(sb.ToString());
            sb.Clear();

            sb.Append("Order ");
            sb.Append(o.OrderNumber.ToString());
            RecieptPrinter.PrintLine(sb.ToString());
            sb.Clear();

            sb.Append("Date: ");
            sb.Append(DateTime.Now.ToString());
            RecieptPrinter.PrintLine(sb.ToString());
            sb.Clear();

            foreach (IOrderItem item in o)
            {
                sb.Append(" -");
                sb.Append(item);
                spaces = SpacesNeeded(item.ToString().Length, item.Price);
                for (int i = 0; i < spaces; i++)
                {
                    sb.Append(" ");
                }
                sb.AppendFormat("{0:C}", item.Price);
                RecieptPrinter.PrintLine(sb.ToString());
                sb.Clear();
                if (item.SpecialInstructions != null)
                {
                    foreach (string instruction in item.SpecialInstructions)
                    {
                        sb.Append("    ");
                        sb.Append(instruction);
                        RecieptPrinter.PrintLine(sb.ToString());
                        sb.Clear();
                    }
                }


            }
            for (int i = 0; i < 45; i++)
            {
                sb.Append(".");
            }
            RecieptPrinter.PrintLine(sb.ToString());
            sb.Clear();
            sb.Append("Subtotal:");
            spaces = 3+SpacesNeeded("Subtotal:".Length , o.Subtotal);
            for (int i = 0; i < spaces; i++)
            {
                sb.Append(" ");
            }
            sb.AppendFormat("{0:C}", o.Subtotal);
            RecieptPrinter.PrintLine(sb.ToString());
            sb.Clear();

            sb.Append("Tax:");
            spaces = 3+SpacesNeeded("Tax:".Length, o.Tax);
            for (int i = 0; i < spaces; i++)
            {
                sb.Append(" ");
            }
            sb.AppendFormat("{0:C}", o.Tax);
            RecieptPrinter.PrintLine(sb.ToString());
            sb.Clear();

            sb.Append("Total after tax:");
            spaces = SpacesNeeded("Total after tax:".Length, o.Total);
            for (int i = 0; i < spaces; i++)
            {
                sb.Append(" ");
            }
            sb.AppendFormat("{0:C}", o.Total);
            RecieptPrinter.PrintLine(sb.ToString());
            sb.Clear();
            RecieptPrinter.PrintLine("Processed by: Credit");
            sb.Clear();

            sb.Append("Change:");
            spaces = SpacesNeeded("Change:".Length+3, 0.00);
            for (int i = 0; i < spaces; i++)
            {
                sb.Append(" ");
            }
            sb.Append("$0.00");
            RecieptPrinter.PrintLine(sb.ToString());
            sb.Clear();

        }

        private int SpacesNeeded(int Length, double amount)
        {
            return (35 - Length - amount.ToString().Length);
        }
    }
}
