using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    public class RoundRegisterModelView
    {
       
        /// <summary>
        /// Properties representing Quantitiy in the cash drawer
        /// </summary>
        public double TotalValue => CashDrawer.Total;

        public int DrawerPennies { get { return CashDrawer.Pennies; } set { CashDrawer.Pennies = value; } }
        public int DrawerNickels { get { return CashDrawer.Nickels; } set { CashDrawer.Nickels = value; } } 
        public int DrawerDimes { get { return CashDrawer.Dimes; } set { CashDrawer.Dimes = value; } } 
        public int DrawerQuarters { get { return CashDrawer.Quarters; } set { CashDrawer.Quarters = value; } }
        public int DrawerHaldDollars { get { return CashDrawer.HalfDollars; } set { CashDrawer.HalfDollars = value; } }
        public int DrawerDollars { get { return CashDrawer.Dollars; } set { CashDrawer.Dollars = value; } } 

        public int DrawerOnes { get { return CashDrawer.Ones; } set { CashDrawer.Ones = value; } } 
        public int DrawerTwos { get { return CashDrawer.Twos; } set { CashDrawer.Twos = value; } } 
        public int DrawerFives { get { return CashDrawer.Fives; } set { CashDrawer.Fives = value; } }
        public int DrawerTens { get { return CashDrawer.Tens; } set { CashDrawer.Tens = value; } }
        public int DrawerTwenties { get { return CashDrawer.Twenties; } set { CashDrawer.Twenties = value; } }
        public int DrawerFifties { get { return CashDrawer.Fifties; } set { CashDrawer.Fifties = value; } }
        public int DrawerHundreds { get { return CashDrawer.Hundreds; } set { CashDrawer.Hundreds = value; } }

        
    public void Addcurrency()
        {
            DrawerPennies += 1;
        }
    
    
    }
}
