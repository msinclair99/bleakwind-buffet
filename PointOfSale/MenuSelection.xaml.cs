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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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
            var test = new BriarheartBurger(); ;
            IOrderItem choice;
            FrameworkElement display;
            switch ((sender as Button).Name)
            {
                case "burger":
                    display = new BriarheartBurgerCustom();
                    choice = new BriarheartBurger();
                    break;
                case "draugr":
                    display = new DoubleDraugrCustom();
                    choice = new DoubleDraugr();
                    break;
                case "triple":
                    display = new ThalmorTripleCustom();
                    choice = new ThalmorTriple();
                    break;
                case "skeleton":
                    display = new SmokehousrSkeletonCustom();
                    choice = new SmokehouseSkeleton();
                    break;
                case "omelette":
                    display = new GardenOrcOmeletteCustom();
                    choice = new GardenOrcOmelette();
                    break;
                case "poacher":
                    display = new PhillyPoacherCustom();
                    choice = new PhillyPoacher();
                    break;
                case "t_bone":
                    display = new NoCustom();
                    choice = new ThugsTBone();
                    break;

                case "salad":
                    SideCustom salad =  new SideCustom();
                    salad.Title.Text = "Vokun Salad Customization";
                    display = salad;
                    choice = new VokunSalad();
                    break;
                case "miraak":
                    SideCustom miraak = new SideCustom();
                    miraak.Title.Text = "Fried Miraak Customization";
                    display = miraak;
                    choice = new FriedMiraak();
                    break;
                case "grits":
                    SideCustom grits = new SideCustom();
                    grits.Title.Text = "Mad Otar Grits Customization";
                    display = grits;
                    choice = new MadOtarGrits();
                    break;
                case "fries":
                    SideCustom fries = new SideCustom();
                    fries.Title.Text = "DragonBorn Waffle Fries Customization";
                    display = fries;
                    choice = new DragonbornWaffleFries();
                    break;

                case "water":
                    display = new WarriorWaterCustom();
                    choice = new WarriorWater();
                    break;
                case "soda":
                    display = new SailorSodaCustom();
                    choice = new SailorSoda();
                    break;
                case "coffee":
                    display = new CandlehearthCoffeeCustom();
                    choice = new CandlehearthCoffee();
                    break;
                case "milk":
                    display = new MarkarthMilkCustom();
                    choice = new MarkarthMilk();
                    break;
                case "juice":
                    display = new ArentinoAppleJuiceCustom();
                    choice = new AretinoAppleJuice();
                    break;
                default:
                    display = new MenuSelection();
                    choice = null;
                    break;
            }


            display.DataContext = choice;
            o?.DisplayUpdate(display);
        }
    }
}

