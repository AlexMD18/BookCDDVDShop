/*
 Alex Drogo / Sean Fuller
 Due Date: 05/04/2020
 CIS 3309_001
 Class Description: 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BookCDDVDShop.Classes
{
    public static class Validation
    {
        //This method will validate the product UPC to make sure it is a length of 5 and can contain a mix of alphanumeric characters. 
        public static bool validateProductUPC(string productUPC)
        {
            //^ - beginning of statement
            //$ - end of statement
            //This should allow all letters lowercase a-z, UPPERCASE A-Z and numbers 0-9. Length of 5.
            Regex rx = new Regex("^\\d{5}$");
            return rx.IsMatch(productUPC);
        }

        //This method will validate the product price. It will assure that the price is a decimal with any number of integers
        //before the decimal and up to 2 inegers after the decimal.
        public static bool validateProductPrice(string productPrice)
        {
            //^ - beginning of statement
            //$ - end of statement
            //any digit + decimal + any digit up to 2 digits in length
            Regex rx = new Regex("^\\d+(,\\d{3})*(\\.\\d{1,2})?$");
            return rx.IsMatch(productPrice);
        }

        //This method will validate the title for the product. There are few rules for the title becides it must not be null.
        public static bool validateAnything(string productTitle)
        {
            //Allows title to be anything of any length
            Regex rx = new Regex("[\\s\\S]");
            return rx.IsMatch(productTitle);
        }

        public static bool validatePositiveInteger(string productQuantity)
        {
            Regex rx = new Regex("^[1-9]\\d*$");
            return rx.IsMatch(productQuantity);
        }

        public static bool validateBookISBN(string ISBN)
        {
            Regex rx = new Regex("^[0-9]{3}$");
            return rx.IsMatch(ISBN);
        }

        public static bool validatePersonName(string author)
        {
            Regex rx = new Regex("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z][',. -]*)*$");
            //Regex rx = new Regex("^(?s).*$");
            return rx.IsMatch(author);
        }

        public static bool validateDate(DateTime releaseDate)
        {
            DateTime oldest = DateTime.Parse("03/26/1997");
            DateTime newest = DateTime.Parse("04/30/2020");

            bool validDate = (releaseDate.Date >= oldest.Date) && (releaseDate.Date <= newest.Date);
            return validDate;
        }

    }
}
