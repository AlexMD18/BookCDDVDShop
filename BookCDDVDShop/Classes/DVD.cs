/*
 Alex Drogo / Sean Fuller
 Due Date: 05/04/2020
 CIS 3309_001
 Class Description: DVD - This class handles the creation and all the attribues of DVDs. It is derived from the product class. 
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

    //Derived From Product Class
    class DVD : Product
    {
        //Private Objects
        private string hiddenLeadActor;
        private DateTime hiddenReleaseDate;
        private int hiddenRuntime;

        //Parameterless Constructor
        public DVD()
        {
            hiddenLeadActor = "";
            hiddenRuntime = 0;
            hiddenReleaseDate = new DateTime(01, 01, 1997);
        }

        //Parameterized Constructor
        public DVD(int UPC, decimal price, string title, int quantity, string leadActor, DateTime releaseDate, int runtime)
            : base(UPC, price, title, quantity)
        {
            hiddenLeadActor = leadActor;
            hiddenReleaseDate = releaseDate;
            hiddenRuntime = runtime;
        }

        //Beginning of Getters and Setters
        public string DVDLeadActor
        {
            get
            {
                return hiddenLeadActor;
            }
            set
            {
                hiddenLeadActor = value;
            }
        }

        public DateTime DVDReleaseDate
        {
            get
            {
                return hiddenReleaseDate;
            }
            set
            {
                hiddenReleaseDate = value;
            }
        }

        public int DVDRunTime
        {
            get
            {
                return hiddenRuntime;
            }
            set
            {
                hiddenRuntime = value;
            }
        }
        //End of Getters and Setters

        // Save data from form to object
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenLeadActor = f.txtDVDLeadActor.Text;
            hiddenReleaseDate = DateTime.Parse(f.txtDVDReleaseDate.Text);
            hiddenRuntime = Convert.ToInt32(f.txtDVDRunTime.Text);
        }

        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtDVDLeadActor.Text = hiddenLeadActor.ToString();
            f.txtDVDReleaseDate.Text = hiddenReleaseDate.ToShortDateString();
            f.txtDVDRunTime.Text = hiddenRuntime.ToString();
        }  // end Display

        //ToString method used in order to be able to see information about the book as it is passed in.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "DVD Info: " + hiddenLeadActor + hiddenReleaseDate + hiddenRuntime;
            return s;
        }  // end ToString
    }
}