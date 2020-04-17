using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    class CDOrchestra : CDClassical
    {
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
