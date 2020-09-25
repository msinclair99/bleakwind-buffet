﻿/*
* Author: Matthew Sinclair
* Class name: MainWindow.xaml.cs
* Purpose: Creates a screen interactions for main window
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PointOfSale.CustomizationDisplays;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Builds the screen and its many xaml components
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
