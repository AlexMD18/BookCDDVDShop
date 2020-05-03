/*
 Alex Drogo / Sean Fuller
 Due Date: 05/04/2020
 CIS 3309_001
 Class Description: Book Class - This class handles the creation and all the attribues of books. It is derived from the product class. It saves
 data typed into the form and displays it back to the form when called. It also contains a ToString method for visibility of what is happenging behind
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
    class Book : Product
    {
        //Private Objects
        private int hiddenISBNLeft;
        private int hiddenISBNRight;
        private string hiddenAuthor;
        private int hiddenPages;

        //Parameterless Constructor
        public Book()
        {
            this.hiddenISBNLeft = 0;
            this.hiddenISBNRight = 0;
            this.hiddenAuthor = "";
            this.hiddenPages = 0;
        }

        //Parameterized Constructor
        public Book(int UPC, decimal price, string title, int quantity, int ISBNLeft, int ISBNRight, string author, int pages)
            : base (UPC, price, title, quantity)
        {
            hiddenISBNLeft = ISBNLeft;
            hiddenISBNRight = ISBNRight;
            hiddenAuthor = author;
            hiddenPages = pages;
        }

        //Beginning of Getters and Setters
        public int BookISBNLeft
        {
            get
            {
                return hiddenISBNLeft;
            }
            set
            {
                hiddenISBNLeft = value;
            }
        }

        public int BookISBNRight
        {
            get
            {
                return hiddenISBNRight;
            }
            set
            {
                hiddenISBNRight = value;
            }
        }

        public string BookAuthor
        {
            get
            {
                return hiddenAuthor;
            }
            set
            {
                hiddenAuthor = value;
            }
        }

        public int BookPages
        {
            get
            {
                return hiddenPages;
            }
            set
            {
                hiddenPages = value;
            }
        }
        //End of Getters and Setters

        //Saves the contents of the form's textboxes into the hidden attributes
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenISBNLeft = Convert.ToInt32(f.txtBookISBNLeft.Text);
            hiddenISBNRight = Convert.ToInt32(f.txtBookISBNRight.Text);
            hiddenAuthor = f.txtBookAuthor.Text;
            hiddenPages = Convert.ToInt32(f.txtBookPages.Text);
        }

        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtBookISBNLeft.Text = hiddenISBNLeft.ToString();
            f.txtBookISBNRight.Text = hiddenISBNRight.ToString();
            f.txtBookAuthor.Text = hiddenAuthor.ToString();
            f.txtBookPages.Text = hiddenPages.ToString();
        }  // end Display

        //ToString method used in order to be able to see information about the book as it is passed in.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Book Info: " + hiddenAuthor + hiddenISBNLeft + hiddenISBNRight + hiddenPages;
            return s;
        }  // end ToString
    }
}


