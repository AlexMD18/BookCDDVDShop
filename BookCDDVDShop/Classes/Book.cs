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

        public Book(int UPC, decimal price, string title, int quantity, int ISBNLeft, int ISBNRight, string author, int pages)
            : base (UPC, price, title, quantity)
        {
            hiddenISBNLeft = ISBNLeft;
            hiddenISBNRight = ISBNRight;
            hiddenAuthor = author;
            hiddenPages = pages;
        }

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


        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Book Info: " + hiddenAuthor + hiddenISBNLeft + hiddenISBNRight + hiddenPages;
            return s;
        }  // end ToString
    }
}


