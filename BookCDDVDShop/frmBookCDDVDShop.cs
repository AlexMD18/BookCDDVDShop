using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCDDVDShop.Classes;
using BookCDDVDShop;


namespace BookCDDVDShop
{
    public partial class frmBookCDDVDShop : Form
    {
        ProductList thisProductList = new ProductList();

        // This index keeps track of the current Owl
        int currentIndex = -1;

        int recordsProcessedCount = 0;
        // File to read or write to
        string FileName = "PersistentObject.bin";

        // Database methods and attributes stored here
        ProductDB dbFunctions = new ProductDB();// Parameterless Constructor for fmrEmpMan

        string ttCreateCDChamber = "Click to enter Make CDChamber mode to add a CDChamber to the List of Products.";
        string ttCreateCDOrchestra = "Click to enter Make CDOrchestra mode to add a CDOrchestra to the List of Products.";
        string ttCreateBook = "Click to enter Make Book mode to add a Book to the List of Products.";
        string ttCreateBookCIS = "Click to enter Make BookCIS mode to add a BookCIS to the List of Products.";
        string ttCreateDVD = "Click to enter Make DVD mode to add a DVD to the List of Products.";
        string ttSaveCDChamber = "Click to Save a CDChamber object to the List of Products.";
        string ttSaveCDOrchestra = "Click to Save a CDOrchestra object to the List of Products.";
        string ttSaveBookCIS = "Click to Save a BookCIS object to the list of Products.";
        string ttSaveBook = "Click to Save the Book object to the List of Products.";
        string ttSaveDVD = "Click to Save the DVD to the List of Products.";
        string ttClear = "Click to Clear Form.";
        string ttFind = "Click to Find a Product in the List of Products.";
        string ttDelete = "Click to Delete Product from the List of Products.";
        string ttEdit = "Click to Edit a Product's data.";
        string ttExit = "Click to exit application.";

        // ?????????? Fix The Specs (in red) for Each Item ??????????

        string ttProductUPC = "Enter a 5 digit integer - no leading zeros";
        string ttProductPrice = "Enter dollars and cents >= 0.0. NO $. Exactly two decimal digits";
        string ttProductTitle = "Enter a string of words (all letters) separated by blanks for any item in the shop";
        string ttProductQuantity = "Enter any integer greater than or equal to 0";
        string ttBookISBN = "Enter Book ISBN in format nnn-nnn)";
        string ttBookAuthor = "Enter Book Author first and last names (all letters) separated by a blank";
        string ttBookPages = "Enter Book page count as an integer greater than 0.";
        string ttDVDLeadActor = "Enter DVD Lead Actor with first and last names (all letters) separated by a blank.";
        string ttDVDReleaseDate = "Enter DVD Release Date in form mm/dd/yyyy between Jan 1 1980 and Dec 31 2019. Use date picker.";
        string ttDVDRunTime = "Enter DVD run time in minutes. Must be a positive integer.";
        string ttBookCISCISArea = "Enter valid CIS area of study using a drop-down menu.";
        string ttCDClassicalLabel = "Enter any sequence of words (all letters) separated by blanks.";
        string ttCDClassicalArtists = "Enter soloists last names separated by a blank";
        string ttCDChamberInstrumentList = "Enter Instrument names separated by a blank";
        string ttCDOrchestraConductor = "Enter Conductor last name with all letters and one blank or one hyphen";


        public frmBookCDDVDShop()
        {
            InitializeComponent();
        }

        private void frmBookCDDVDShop_Load(object sender, EventArgs e)
        {
            // Read serialized binary data file
            SerializationFile.readFromFile(ref thisProductList, FileName);
            //FormController.clear(this);

            // get initial Tooltips
            toolTip1.SetToolTip(btnCreateBookCIS, ttCreateBookCIS);
            toolTip1.SetToolTip(btnCreateBook, ttCreateBook);
            toolTip1.SetToolTip(btnCreateCDOrchestra, ttCreateCDOrchestra);
            toolTip1.SetToolTip(btnCreateCDOrchestra, ttCreateDVD);
            toolTip1.SetToolTip(btnCreateDVD, ttCreateCDChamber);

            toolTip1.SetToolTip(btnClear, ttClear);
            toolTip1.SetToolTip(btnDelete, ttDelete);
            toolTip1.SetToolTip(btnEditUpdate, ttEdit);
            toolTip1.SetToolTip(btnFindDisplay, ttFind);
            toolTip1.SetToolTip(btnExit, ttExit);

            toolTip1.SetToolTip(txtProductUPC, ttProductUPC);
            toolTip1.SetToolTip(txtProductPrice, ttProductPrice);
            toolTip1.SetToolTip(txtProductQuantity, ttProductQuantity);
            toolTip1.SetToolTip(txtProductTitle, ttProductTitle);
            toolTip1.SetToolTip(txtCDOrchestraConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtBookISBNLeft, ttBookISBN);
            toolTip1.SetToolTip(txtBookAuthor, ttBookAuthor);
            toolTip1.SetToolTip(txtBookPages, ttBookPages);
            toolTip1.SetToolTip(txtDVDLeadActor, ttDVDLeadActor);
            toolTip1.SetToolTip(txtDVDReleaseDate, ttDVDReleaseDate);
            toolTip1.SetToolTip(txtDVDRunTime, ttDVDRunTime);
            toolTip1.SetToolTip(txtCDClassicalLabel, ttCDClassicalLabel);
            toolTip1.SetToolTip(txtCDClassicalArtists, ttCDClassicalArtists);
            toolTip1.SetToolTip(txtCDOrchestraConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtCDChamberInstrumentList, ttCDChamberInstrumentList);
            toolTip1.SetToolTip(txtBookCISCISArea, ttBookCISCISArea);
            toolTip1.SetToolTip(btnCreateBookCIS, ttCreateBookCIS);
        }

        // Validate Product data
        private bool ValidateProduct()
        {
            if (Validation.validateProductUPC(txtProductUPC.Text) == false)
            {
                txtProductUPC.Text = "";
                txtProductUPC.Focus();
                MessageBox.Show("Product UPC not valid. Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validation.validateProductPrice(txtProductPrice.Text) == false)
            {
                txtProductPrice.Text = "";
                txtProductPrice.Focus();
                MessageBox.Show("Product Price not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validation.validateProductTitle(txtProductTitle.Text) == false)
            {
                txtProductTitle.Text = "";
                txtProductTitle.Focus();
                MessageBox.Show("Product Title not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validation.validateProductQuantity(txtProductQuantity.Text) == false)
            {
                txtProductQuantity.Text = "";
                txtProductQuantity.Focus();
                MessageBox.Show("Product Quantity not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            return true;
        }   // end Validate Product data

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            FormController.activateBook(this);
            FormController.activateProduct(this);
            btnCreateBookCIS.Enabled = true;
            btnCreateCDChamber.Enabled = false;
            btnCreateCDOrchestra.Enabled = false;
            btnCreateDVD.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of records processed = " +
                recordsProcessedCount.ToString(),
                "Exit Message", MessageBoxButtons.OK);
            MessageBox.Show("The list entries are ...", "Display List Entries");
            //thisProductList.displayProductList();

            // Save serialized binary file
            SerializationFile.writeToFile(thisProductList, FileName);

            this.Close();

        }

        private void btnCreateBookCIS_Click(object sender, EventArgs e)
        {
            FormController.activateBookCIS(this);
        }

        private void btnCreateDVD_Click(object sender, EventArgs e)
        {
            FormController.activateDVD(this);
            btnCreateBook.Enabled = false;
            btnCreateBookCIS.Enabled = true;
            btnCreateCDChamber.Enabled = false;
            btnCreateCDOrchestra.Enabled = false;
        }

        private void btnCreateCDOrchestra_Click(object sender, EventArgs e)
        {
            FormController.activateCDClassical(this);
            FormController.activateCDOrchestra(this);
            btnCreateBook.Enabled = false;
            btnCreateBookCIS.Enabled = true;
            btnCreateCDChamber.Enabled = false;
            btnCreateDVD.Enabled = false;
        }

        private void btnCreateCDChamber_Click(object sender, EventArgs e)
        {
            FormController.activateCDClassical(this);
            FormController.activateCDChamber(this);
            btnCreateBook.Enabled = false;
            btnCreateBookCIS.Enabled = true;
            btnCreateDVD.Enabled = false;
            btnCreateCDOrchestra.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //dbFunctions.Delete(Convert.ToInt32(txtProductUPC.Text));
            FormController.resetForm(this);
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            bool success;
            btnFindDisplay.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveUpdate.Enabled = false;
            success = findAnItem("Edit/Update");
            if (success)
            {
                btnSaveUpdate.Enabled = true;
                btnEditUpdate.Enabled = false;

                Product p = thisProductList.getAnItem(currentIndex);
                txtProductPrice.Text = p.ProductPrice.ToString();
                txtProductUPC.Text = p.ProductUPC.ToString();
                txtProductQuantity.Text = p.ProductQuantity.ToString();
                txtProductTitle.Text = p.ProductTitle.ToString();
                MessageBox.Show("Edit/UPDATE current Product (as shown). Press Save Updates Button", "Edit/Update Notice",
                    MessageBoxButtons.OK);
                if (p.GetType() == typeof(CDChamber))
                {
                    FormController.activateCDChamber(this);
                    FormController.deactivateAllButCDChamber(this);
                    FormController.deactivateAddButtons(this);

                    txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                    txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                    txtCDChamberInstrumentList.Text = ((CDChamber)p).getCDChamberInstrumentList();
                }
                else if (p.GetType() == typeof(CDOrchestra))
                {
                    FormController.activateCDOrchestra(this);
                    FormController.deactivateAllButCDOrchestra(this);

                    txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                    txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                    txtCDOrchestraConductor.Text = ((CDOrchestra)p).CDOrchestraConductor();
                }
                else if (p.GetType() == typeof(Book))
                {
                    FormController.activateBook(this);
                    FormController.deactivateAllButBook(this);
                    FormController.deactivateAddButtons(this);

                    txtBookISBNLeft.Text = (((Book)p).BookISBNLeft).ToString();
                    txtBookISBNRight.Text = (((Book)p).BookISBNRight).ToString();
                    txtBookAuthor.Text = ((Book)p).BookAuthor;
                    txtBookPages.Text = ((Book)p).BookPages.ToString();
                }
                else if (p.GetType() == typeof(BookCIS))
                {
                    FormController.activateBookCIS(this);
                    FormController.deactivateAllButBookCIS(this);

                    txtBookISBNLeft.Text = (((Book)p).BookISBNLeft).ToString();
                    txtBookISBNRight.Text = (((Book)p).BookISBNRight).ToString();
                    txtBookAuthor.Text = ((Book)p).BookAuthor;
                    txtBookPages.Text = (((Book)p).BookPages).ToString();
                    txtBookCISCISArea.Text = ((BookCIS)p).BookCISCISArea; ;
                }  // end multiple alternative if

                else if (p.GetType() == typeof(DVD))
                {
                    FormController.activateDVD(this);
                    FormController.deactivateAllButDVD(this);

                    txtDVDLeadActor.Text = ((DVD)p).DVDLeadActor;
                    txtDVDReleaseDate.Text = ((DateTime)((DVD)p).DVDReleaseDate).ToString("mm/dd/yyyy");
                    txtDVDRunTime.Text = (((DVD)p).DVDRunTime).ToString();
                }
                else
                {
                    MessageBox.Show("Fatal error. Data type not Book, BookCIS, DVD, DC Chamber or CD Orchestra. Program Terminated. ",
                        "Mis-typed Object", MessageBoxButtons.OK);
                    this.Close();
                }  // end multiple alternative if
            }  // end if on success
        }


        private void getItem(int i)
        {
            if (thisProductList.Count() == 0)
            {
                btnDelete.Enabled = false;
                btnEditUpdate.Enabled = false;
                // btnToString.Enabled = false;
            }
            else if (i < 0 || i >= thisProductList.Count())
            {
                MessageBox.Show("getItem error: index out of range");
                return;
            }
            else
            {
                currentIndex = i;
                //thisProductList.getAnItem(i).Display(this);
                //lblUserMessage.Text = "Object Type: " + thisProductList.getAnItem(i).GetType().ToString() + " List Index: " + i.ToString();
                btnFindDisplay.Enabled = true;
                btnDelete.Enabled = true;
                btnEditUpdate.Enabled = true;
            }  // end else
        } // end getItem

    }
}
