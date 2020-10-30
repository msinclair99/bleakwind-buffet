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
    /// Interaction logic for CoinsCustom.xaml
    /// </summary>
    public partial class CoinsCustom : UserControl
    {
        public CoinsCustom()
        {
            InitializeComponent();
        }

        public void IncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Decreases coin quantity
        /// </summary>
        /// <param name="sender">The coin amount</param>
        /// <param name="args">event</param>
        public void DecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }

        public int Quantity
        {
            get
            {
                return (int)GetValue(QuantityProperty);
            }
            set
            {
                SetValue(QuantityProperty, value);
            }
        }

        public static readonly DependencyProperty DenominationProperty = DependencyProperty.Register
           (
           "CoinType",                         
           typeof(CashDrawer),                         
           typeof(CoinsCustom),                   
           new PropertyMetadata(CashDrawer.Pennies)       
           );

        public static readonly DependencyProperty QuantityProperty =
                DependencyProperty.Register(
                    "Quantity",
                    typeof(int),
                    typeof(CoinsCustom),
                    new FrameworkPropertyMetadata(
                        0,
                        FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                    )
                );



        public int CoinType
        {
            get
            {
                return (int)GetValue(DenominationProperty);
            }
            set
            {
                SetValue(DenominationProperty, value);
            }
        }

    }
}
