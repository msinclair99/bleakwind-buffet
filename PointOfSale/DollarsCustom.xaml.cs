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
    /// Interaction logic for DollarsCustom.xaml
    /// </summary>
    public partial class DollarsCustom : UserControl
    {
        public DollarsCustom()
        {
            InitializeComponent();
        }

        public void IncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Decreases cash quantity
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
        "Denomination",                         //Name of property
        typeof(CashDrawer),                          //type of property
        typeof(DollarsCustom),                    //Property's control
        new PropertyMetadata(CashDrawer.Ones)       //The property metadata
        );

        public static readonly DependencyProperty QuantityProperty = DependencyProperty.Register(
     "Quantity",
     typeof(int),
     typeof(CashDrawer),
     new FrameworkPropertyMetadata(
         0,
         FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
         )
     );

        /// </summary>
        public int Denomination
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
