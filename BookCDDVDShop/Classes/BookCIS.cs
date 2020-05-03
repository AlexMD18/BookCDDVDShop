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

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    class BookCIS : Book
    {
        private string hiddenCISArea;

        public BookCIS()
        {
            this.hiddenCISArea = "";
        }

        public BookCIS(int UPC, decimal price, string title, int quantity, int ISBNLeft, int ISBNRight, string author, int pages, string CISArea)
            : base(UPC, price, title, quantity, ISBNLeft, ISBNRight, author, pages)
        {
            hiddenCISArea = CISArea;
        }

        public string BookCISCISArea
        {
            get
            {
                return hiddenCISArea;
            }
            set
            {
                hiddenCISArea = value;
            }
        }

        public string BookCISArea
        {
            get
            {
                return hiddenCISArea;
            }  // end get
            set   // (string value)
            {
                hiddenCISArea = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenCISArea = f.txtBookCISCISArea.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtBookCISCISArea.Text = hiddenCISArea;
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "CIS Book Info: " + hiddenCISArea;
            return s;
        }  // end ToString

    }
}
