/*
 Alex Drogo / Sean Fuller
 Due Date: 05/04/2020
 CIS 3309_001
 Class Description: BookCIS - This class handles the creation and all the attribues of CIS books. It is derived from the book class and the product class. 
 It saves data typed into the form and displays it back to the form when called. It also contains a ToString method for visibility of what is happenging behind
 the scenes when updating, inserting, ect...
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCDDVDShop.Classes
{
    [Serializable()]

    //Derived From Book Class
    class BookCIS : Book
    {
        //Private Objects
        private string hiddenCISArea;

        //Parameterless Construcor
        public BookCIS()
        {
            this.hiddenCISArea = "";
        }

        //Parameterized Constructor
        public BookCIS(int UPC, decimal price, string title, int quantity, int ISBNLeft, int ISBNRight, string author, int pages, string CISArea)
            : base(UPC, price, title, quantity, ISBNLeft, ISBNRight, author, pages)
        {
            hiddenCISArea = CISArea;
        }

        //Beginning of Getters and Setters
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
        //End of Getters and Setters

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
