/*
 Alex Drogo / Sean Fuller
 Due Date: 05/04/2020
 CIS 3309_001
 Class Description: 
 */

 //This class is used for creating and lists of recently accessed products
 //Used by the update method to identify the current record to be updated

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
        private List<Product> hiddenProductList = new List<Product>();

        public ProductList()
        {
            hiddenProductList = new List<Product>();
        }

        public Product getAnItem(int i)
        {
            return hiddenProductList[i];
        }

        public void Add(Product p)
        {
            hiddenProductList.Add(p);
        }

        public int Count()
        {
            return hiddenProductList.Count;
        }

    }
}