/*
* Author: Matthew Sinclair
* Class name: MenuSelection.xaml.cs
* Purpose: Creates a screen interactions for menu item selection
*/
using System;
using System.Collections.Generic;
using System.Linq;
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
using BleakwindBuffet.Data.Sides;
using PointOfSale.CustomizationDisplays;
using static PointOfSale.Order;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        /// <summary>
        /// Builds the screen and its many xaml components
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes the button selection for a menu item and updates screen to that items customization menu
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event</param>
        public void MenuButtonPress(object sender, RoutedEventArgs e)
        {
            var o = this.FindAncestor<Order>();

            FrameworkElement display;
            switch ((sender as Button).Name)
            {
                case "burger":
                    display = new BriarheartBurgerCustom();
                    break;
                case "draugr":
                    display = new DoubleDraugrCustom();
                    break;
                case "triple":
                    display = new ThalmorTripleCustom();
                    break;
                case "skeleton":
                    display = new SmokehousrSkeletonCustom();
                    break;
                case "omelette":
                    display = new GardenOrcOmeletteCustom();
                    break;
                case "poacher":
                    display = new PhillyPoacherCustom();
                    break;
                case "t_bone":
                    display = new NoCustom();
                    break;

                case "salad":
                    SideCustom salad =  new SideCustom();
                    salad.Title.Text = "Vokun Salad Customization";
                    display = salad;
                    break;
                case "miraak":
                    SideCustom miraak = new SideCustom();
                    miraak.Title.Text = "Fried Miraak Customization";
                    display = miraak;
                    break;
                case "grits":
                    SideCustom grits = new SideCustom();
                    grits.Title.Text = "Mad Otar Grits Customization";
                    display = grits;
                    break;
                case "fries":
                    SideCustom fries = new SideCustom();
                    fries.Title.Text = "DragonBorn Waffle Fries Customization";
                    display = fries;
                    break;

                case "water":
                    display = new WarriorWaterCustom();
                    break;
                case "soda":
                    display = new SailorSodaCustom();
                    break;
                case "coffee":
                    display = new CandlehearthCoffeeCustom();
                    break;
                case "milk":
                    display = new MarkarthMilkCustom();
                    break;
                case "juice":
                    display = new ArentinoAppleJuiceCustom();
                    break;
                default:
                    display = new MenuSelection();
                    break;
            }

            o?.DisplayUpdate(display);

        }
    }
}

