﻿/*
 Alex Drogo / Sean Fuller
 Due Date: 05/04/2020
 CIS 3309_001
 Class Description: CDOrchestra - This class handles the creation and all the attribues of Chamber CD's. It is derived from the CDClassical class and the product class. 
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

    //Derived From CDClassical Class
    class CDOrchestra : CDClassical
    {
        //Private Objects
        private string hiddenConductor;

        // Parameterless Constructor
        public CDOrchestra()
        {
            hiddenConductor = "";
        }  // end Parameterless Constructor


        // Parameterized constructor
        public CDOrchestra(int UPC, decimal price, string title, int quantity, string label, string artist, string conductor) 
                : base(UPC, price, title, quantity, label, artist)
        {
            hiddenConductor = conductor;
        }

        // These six methods replace what were VB Properties
        // get or set an item in the List
        // Accessor/mutator for Tuition, Year and Credits
        public string getCDOrchestraConductor()
        {
            return hiddenConductor;
        }


        public void setCDOrchestraConductor(string value)
        {
            hiddenConductor = value;
        }  // end get


        // Save data from form to object
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenConductor = f.txtCDOrchestraConductor.Text;
        }  // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtCDOrchestraConductor.Text = hiddenConductor;
        }  // end Display


        // This toString function overrides the Student toString
        // function.  The base refers to the Student because this class
        // inherits Student by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Orchestra Conductor:  " + hiddenConductor;
            return s;
        } //  end ToString

    }  // end CDClChamber Class
}
