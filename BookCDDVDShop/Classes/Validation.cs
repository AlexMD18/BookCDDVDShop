﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BookCDDVDShop.Classes
{
    class Validation
    {
        //This method will validate the product UPC to make sure it is a length of 5 and can contain a mix of alphanumeric characters. 
        public static bool validateProductUPC(string productUPC)
        {
            //^ - beginning of statement
            //$ - end of statement
            //This should allow all letters lowercase a-z, UPPERCASE A-Z and numbers 0-9. Length of 5.
            Regex rx = new Regex("^[a-zA-Z0-9]{5}$");
            return rx.IsMatch(productUPC);
        }

        //This method will validate the product price. It will assure that the price is a decimal with any number of integers
        //before the decimal and up to 2 inegers after the decimal.
        public static bool validateProductPrice(string productPrice)
        {
            //^ - beginning of statement
            //$ - end of statement
            //any digit + decimal + any digit up to 2 digits in length
            Regex rx = new Regex("^(\\d+\\.\\d{1,2})");
            return rx.IsMatch(productPrice);
        }

        //This method will validate the title for the product. There are few rules for the title becides it must not be null.
        public static bool validateProductTitle(string productTitle)
        {
            //Allows title to be anything of any length
            Regex rx = new Regex("^.*$");
            return rx.IsMatch(productTitle);
        }

        public static bool validateProductQuantity(string productQuantity)
        {
            Regex rx = new Regex("^[0-9]$");
            return rx.IsMatch(productQuantity);
        }
    }
}
