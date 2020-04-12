using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCDDVDShop.Classes
{
    public class ProductList
    {
        private ArrayList productList;


        public int Count()
        {
            return this.productList.Count;
        }
    }
}
