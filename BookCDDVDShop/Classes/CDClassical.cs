/*
 Alex Drogo / Sean Fuller
 Due Date: 05/04/2020
 CIS 3309_001
 Class Description: CDClassical - This class handles the creation and all the attribues of Classical CD's. It is derived from the product class. 
 It saves data typed into the form and displays it back to the form when called. It also contains a ToString method for visibility of what is happenging behind
 the scenes when updating, inserting, ect...
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;
// using BookCDDVDShop.Classes;

namespace BookCDDVDShop.Classes
{
    // CDClassical inherits the data and methods in Product
    [Serializable()]

    //Derived From Product Class
    public abstract class CDClassical : Product
    {
        //Private Objects
        private string hiddenLabel;
        private string hiddenArtists;

        // Parameterless Constructor
        public CDClassical()
        {
            hiddenLabel = "";
            hiddenArtists = "";

        } // end CDClassical Parameterless Constructor


        // Parameterized Constructor
        public CDClassical(int UPC, decimal price, string title, int quantity,
            string label, string artists) : base(UPC, price, title, quantity)
        {
            hiddenLabel = label;
            hiddenArtists = artists;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for CD Label
        public string CDClassicalLabel
        {
            get
            {
                return hiddenLabel;
            }  // end get
            set   // (string value)
            {
                hiddenLabel = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for CD Artists
        public string CDClassicalArtists
        {
            get
            {
                return hiddenArtists;
            }  // end get
            set   // (string value)
            {
                hiddenArtists = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenLabel = f.txtCDClassicalLabel.Text;
            hiddenArtists = f.txtCDClassicalArtists.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtCDClassicalLabel.Text = hiddenLabel;
            f.txtCDClassicalArtists.Text = hiddenArtists.ToString();
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "CDClassical Info: " + hiddenLabel + hiddenArtists.ToString();
            return s;
        }  // end ToString

    }  // end CDClassical class
}  // end namespace  
