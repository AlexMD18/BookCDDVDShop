/*
 Alex Drogo / Sean Fuller
 Due Date: 05/04/2020
 CIS 3309_001
 Class Description: Product List - This class is used for creating and lists of recently accessed products. Used by the update method to 
 identify the current record to be updated.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    public class ProductList
    {
        //List of product objects
        private List<Product> hiddenProductList = new List<Product>();

        //Parameterless Constructor 
        public ProductList()
        {
            hiddenProductList = new List<Product>();
        }

        //Getter
        public Product getAnItem(int i)
        {
            return hiddenProductList[i];
        }

        //Method to add object to the end of the list
        public void Add(Product p)
        {
            hiddenProductList.Add(p);
        }

        //Gets the number of objects in the list
        public int Count()
        {
            return hiddenProductList.Count;
        }

    }
}