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
    class DVD : Product
    {
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

        public DVD(int UPC, decimal price, string title, int quantity, string leadActor, DateTime releaseDate, int runtime)
            : base(UPC, price, title, quantity)
        {
            hiddenLeadActor = leadActor;
            hiddenReleaseDate = releaseDate;
            hiddenRuntime = runtime;
        }

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


        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "DVD Info: " + hiddenLeadActor + hiddenReleaseDate + hiddenRuntime;
            return s;
        }  // end ToString
    }
}