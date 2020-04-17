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
        private ArrayList productList;

        public ProductList()
        {
            this.productList = new ArrayList();
        }

        public void add(Product p)
        {
            this.productList.Add(p);
        }

        public int Count()
        {
            return this.productList.Count;
        }

        public void delete(int enteredUPC)
        {
            this.delete(enteredUPC);
        }
    }
}
