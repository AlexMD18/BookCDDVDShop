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
using System.Data.OleDb;

namespace BookCDDVDShop
{
    public partial class frmBookCDDVDShop : Form
    {
        public string clickedBtn;
        ProductList thisProductList = new ProductList();

        // This index keeps track of the current Owl
        int currentIndex = -1;

        int recordsProcessedCount = 0;
        // File to read or write to
        //string FileName = "PersistentObject.bin";

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
            //SerializationFile.readFromFile(ref thisProductList, FileName);
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
            if (Validation.validateAnything(txtProductTitle.Text) == false)
            {
                txtProductTitle.Text = "";
                txtProductTitle.Focus();
                MessageBox.Show("Product Title not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validation.validatePositiveInteger(txtProductQuantity.Text) == false)
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
            btnSave.Enabled = true;
            clickedBtn = "create_book";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of records processed = " +
                recordsProcessedCount.ToString(),
                "Exit Message", MessageBoxButtons.OK);
            MessageBox.Show("The list entries are ...", "Display List Entries");
            //thisProductList.displayProductList();

            // Save serialized binary file
            //SerializationFile.writeToFile(thisProductList, FileName);

            this.Close();

        }

        private void btnCreateBookCIS_Click(object sender, EventArgs e)
        {
            FormController.activateBookCIS(this);
            clickedBtn = "create_book_CIS";
            btnSave.Enabled = true;
        }

        private void btnCreateDVD_Click(object sender, EventArgs e)
        {
            FormController.activateDVD(this);
            btnCreateBook.Enabled = false;
            btnCreateBookCIS.Enabled = false;
            btnCreateCDChamber.Enabled = false;
            btnCreateCDOrchestra.Enabled = false;
            btnSave.Enabled = true;
            clickedBtn = "create_DVD";
        }

        private void btnCreateCDClassical_Click(object sender, EventArgs e)
        {
            FormController.activateCDClassical(this);
            btnCreateBook.Enabled = false;
            btnCreateBookCIS.Enabled = false;
            btnCreateCDChamber.Enabled = true;
            btnCreateCDOrchestra.Enabled = true;
            btnSave.Enabled = true;
            clickedBtn = "create_CD_classical";
        }

        private void btnCreateCDOrchestra_Click(object sender, EventArgs e)
        {
            FormController.activateCDClassical(this);
            FormController.activateCDOrchestra(this);
            btnCreateBook.Enabled = false;
            btnCreateBookCIS.Enabled = false;
            btnCreateCDChamber.Enabled = false;
            btnCreateDVD.Enabled = false;
            btnSave.Enabled = true;
            clickedBtn = "create_CD_orchestra";
        }

        private void btnCreateCDChamber_Click(object sender, EventArgs e)
        {
            FormController.activateCDClassical(this);
            FormController.activateCDChamber(this);
            btnCreateBook.Enabled = false;
            btnCreateBookCIS.Enabled = false;
            btnCreateDVD.Enabled = false;
            btnCreateCDOrchestra.Enabled = false;
            btnSave.Enabled = true;
            clickedBtn = "create_CD_chamber";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dbFunctions.Delete(Convert.ToInt32(txtProductUPC.Text));
                recordsProcessedCount++;
                FormController.clear(this);
            }
            
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            bool success;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            success = findAnItem("Edit/Update");
            if (success)
            {
                btnSave.Enabled = true;
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
                    recordsProcessedCount++;
                }
                else if (p.GetType() == typeof(CDOrchestra))
                {
                    FormController.activateCDOrchestra(this);
                    FormController.deactivateAllButCDOrchestra(this);

                    txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                    txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                    txtCDOrchestraConductor.Text = ((CDOrchestra)p).getCDOrchestraConductor();
                    recordsProcessedCount++;
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
                    recordsProcessedCount++;
                }
                else if (p.GetType() == typeof(BookCIS))
                {
                    FormController.activateBookCIS(this);
                    FormController.deactivateAllButBookCIS(this);

                    txtBookISBNLeft.Text = (((Book)p).BookISBNLeft).ToString();
                    txtBookISBNRight.Text = (((Book)p).BookISBNRight).ToString();
                    txtBookAuthor.Text = ((Book)p).BookAuthor;
                    txtBookPages.Text = (((Book)p).BookPages).ToString();
                    txtBookCISCISArea.Text = ((BookCIS)p).BookCISCISArea;
                    recordsProcessedCount++;
                }  // end multiple alternative if

                else if (p.GetType() == typeof(DVD))
                {
                    FormController.activateDVD(this);
                    FormController.deactivateAllButDVD(this);

                    txtDVDLeadActor.Text = ((DVD)p).DVDLeadActor;
                    txtDVDReleaseDate.Text = ((DateTime)((DVD)p).DVDReleaseDate).ToString("MM/dd/yyyy");
                    txtDVDRunTime.Text = (((DVD)p).DVDRunTime).ToString();
                    recordsProcessedCount++;
                }
                else
                {
                    MessageBox.Show("Fatal error. Data type not Book, BookCIS, DVD, DC Chamber or CD Orchestra. Program Terminated. ",
                        "Mis-typed Object", MessageBoxButtons.OK);
                    this.Close();
                }  // end multiple alternative if
            }  // end if on success
        }

        private bool findAnItem(string v)
        {
            bool temp = Validation.validateProductUPC(txtProductUPC.Text);
            if (temp)
            {
                bool found; // boolean reference for search success
                string pstring; // Product string updated upon product DB search call.
                OleDbDataReader odb = dbFunctions.SelectProductFromProduct(Convert.ToInt32(txtProductUPC.Text), out found, out pstring);
                if (!found) //not found
                {
                    return false;
                }
                return true;
            }
            return false;
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
                btnDelete.Enabled = true;
                btnEditUpdate.Enabled = true;
            }  // end else
        } // end getItem

        private void btnProductUPCSearch_Click(object sender, EventArgs e)
        {
            bool temp = Validation.validateProductUPC(txtProductUPCSearch.Text); //first make sure the format is correct
            if (temp)
            {
                bool found; // boolean reference for search success
                string pstring; // Product string updated upon product DB search call.
                Product prod;

                //  this returns an OleDbDataReader object, but you don't really need to use it
                //  the boolean flag and string that are returned are important
                //  pstring will hold the attributes of a product from the database in a single string, separated by newline characters
                //  split it below 

                OleDbDataReader odb = dbFunctions.SelectProductFromProduct(Convert.ToInt32(txtProductUPCSearch.Text), out found, out pstring);

                if (!found) //not found
                {
                    MessageBox.Show("Product not found");
                    txtProductUPCSearch.Clear();
                    txtProductUPCSearch.Focus();

                } // Creates a new product to display in form.
                else
                {
                    btnDelete.Enabled = true;
                    string[] attributes = pstring.Split('\n'); // splits product attributes into array

                    for (int i = 0; i < attributes.Length; i++)
                    {
                        attributes[i] = attributes[i].Trim('\r'); // clears "junk" from each field
                    }

                    string ptype = attributes[4]; // gets the product type from this attribute and then creates new product to display in form

                    if (ptype == "DVD")
                    {
                        prod = new DVD(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            attributes[5], DateTime.Parse(attributes[6]), Convert.ToInt32(attributes[7]));
                        prod.Display(this);
                        FormController.searchForm(this);
                        FormController.activateDVD(this);
                        thisProductList.Add(prod);
                        currentIndex++;
                    }

                    if (ptype == "Book")
                    {
                        String isbnS = attributes[5];
                        String isbn1 = isbnS.Substring(0, 3);
                        String isbn2 = isbnS.Substring(3, 3);
                        prod = new Book(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            Convert.ToInt32(isbn1), Convert.ToInt32(isbn2), attributes[6], Convert.ToInt32(attributes[7]));
                        prod.Display(this);
                        FormController.searchForm(this);
                        FormController.activateBook(this);
                        thisProductList.Add(prod);
                        currentIndex++;
                    }

                    if (ptype == "BookCIS")
                    {
                        String isbnS = attributes[5];
                        String isbn1 = isbnS.Substring(0, 3);
                        String isbn2 = isbnS.Substring(3, 3);
                        prod = new BookCIS(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            Convert.ToInt32(isbn1), Convert.ToInt32(isbn2), attributes[6], Convert.ToInt32(attributes[7]), attributes[8]);
                        prod.Display(this);
                        FormController.searchForm(this);
                        FormController.activateBookCIS(this);
                        thisProductList.Add(prod);
                        currentIndex++;
                    }

                    if (ptype == "CDOrchestra")
                    {
                        prod = new CDOrchestra(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            attributes[5], attributes[6], attributes[7]);
                        prod.Display(this);
                        FormController.searchForm(this);
                        FormController.activateCDOrchestra(this);
                        thisProductList.Add(prod);
                        currentIndex++;
                    }

                    if (ptype == "CDChamber")
                    {
                        //String[] InstrumentList = attributes[6].Split(' ');
                        prod = new CDChamber(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            attributes[5], attributes[6], attributes[7]);
                        prod.Display(this);
                        FormController.searchForm(this);
                        FormController.activateCDChamber(this);
                        thisProductList.Add(prod);
                        currentIndex++;
                    }

                    /*
                     *
                     * add else ifs for the other product types and handle each accordingly
                     *
                     */
                    else
                    {
                        // this is an invalid record (since it does not fit one of our types)
                    }
                }
            }
            else
            {
                // UPC is invalid
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool productValidated;

            productValidated = Validation.validateProductUPC(txtProductUPC.Text)
                               && Validation.validateProductPrice(txtProductPrice.Text)
                               && Validation.validateAnything(txtProductTitle.Text)
                               && Validation.validatePositiveInteger(txtProductQuantity.Text);

            if (productValidated == false)
            {
                MessageBox.Show("You have errors with your product information! Please check the product information and try again.", "Product Input Error");
            }
            else
            {
                bool found; // boolean reference for search success
                string pstring; // Product string updated upon product DB search call.
                //Product prod;

                OleDbDataReader odb = dbFunctions.SelectProductFromProduct(Convert.ToInt32(txtProductUPC.Text), out found, out pstring);

                if (!found)
                {
                    //works
                    if (clickedBtn == "create_book")
                    {
                        bool bookValidated;

                        bookValidated = Validation.validateBookISBN(txtBookISBNLeft.Text) &&
                                        Validation.validateBookISBN(txtBookISBNRight.Text) &&
                                        Validation.validatePersonName(txtBookAuthor.Text) &&
                                        Validation.validatePositiveInteger(txtBookPages.Text);

                        if (bookValidated == true)
                        {
                            Book saveBook = new Book(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                     txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                                     Convert.ToInt32(txtBookISBNLeft.Text), Convert.ToInt32(txtBookISBNRight.Text),
                                                     txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));

                            dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                     txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "Book");
                            dbFunctions.InsertBook(Convert.ToInt32(txtProductUPC.Text), Convert.ToInt32(txtBookISBNLeft.Text + txtBookISBNRight.Text),
                                                     txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));

                            MessageBox.Show("Book successfully inserted into database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the book into the file. Check the entered information and try again!");
                        }

                    }
                    //works
                    else if (clickedBtn == "create_book_CIS")
                    {
                        bool bookCISValidated;

                        bookCISValidated = Validation.validateBookISBN(txtBookISBNLeft.Text) &&
                                           Validation.validateBookISBN(txtBookISBNRight.Text) &&
                                           Validation.validatePersonName(txtBookAuthor.Text) &&
                                           Validation.validatePositiveInteger(txtBookPages.Text) &&
                                           Validation.validateAnything(txtBookCISCISArea.Text);

                        if (bookCISValidated == true)
                        {
                            BookCIS saveCISBook = new BookCIS(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                     txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                                     Convert.ToInt32(txtBookISBNLeft.Text), Convert.ToInt32(txtBookISBNRight.Text),
                                                     txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text), txtBookCISCISArea.Text);

                            dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                    txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "BookCIS");

                            dbFunctions.InsertBook(Convert.ToInt32(txtProductUPC.Text), Convert.ToInt32(txtBookISBNLeft.Text + txtBookISBNRight.Text),
                                                     txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));

                            dbFunctions.InsertBookCIS(Convert.ToInt32(txtProductUPC.Text), txtBookCISCISArea.Text);

                            MessageBox.Show("Book successfully inserted into database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the book into the file. Check the entered information and try again!");
                        }
                    }
                    //works
                    else if (clickedBtn == "create_DVD")
                    {
                        bool dvdValidated;

                        dvdValidated = Validation.validatePersonName(txtDVDLeadActor.Text) &&
                                       Validation.validateDate(Convert.ToDateTime(txtDVDReleaseDate.Text)) &&
                                       Validation.validatePositiveInteger(txtDVDRunTime.Text);

                        if (dvdValidated == true)
                        {
                            DVD saveDVD = new DVD(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                     txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                                     txtDVDLeadActor.Text, Convert.ToDateTime(txtDVDReleaseDate.Text),
                                                     Convert.ToInt32(txtDVDRunTime.Text));

                            dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                    txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "DVD");

                            dbFunctions.InsertDVD(Convert.ToInt32(txtProductUPC.Text), txtDVDLeadActor.Text,
                                                  Convert.ToDateTime(txtDVDReleaseDate.Text), Convert.ToInt32(txtDVDRunTime.Text));

                            MessageBox.Show("DVD successfully inserted into database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the DVD into the file. Check the entered information and try again!");
                        }
                    }
                    
                    else if (clickedBtn == "create_CD_chamber")
                    {
                        bool chamberValidated;

                        chamberValidated = Validation.validateAnything(txtCDClassicalLabel.Text) &&
                                           Validation.validatePersonName(txtCDClassicalArtists.Text) &&
                                           Validation.validateAnything(txtCDChamberInstrumentList.Text);

                        if (chamberValidated == true)
                        {
                            dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                      txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "CDChamber");
                            dbFunctions.InsertCDClassical(Convert.ToInt32(txtProductUPC.Text), txtCDClassicalLabel.Text, txtCDClassicalArtists.Text);

                            dbFunctions.InsertCDChamber(Convert.ToInt32(txtProductUPC.Text), txtCDChamberInstrumentList.Text);

                            MessageBox.Show("Chamber CD successfully inserted into database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the chamber CD into the file. Check the entered information and try again!");
                        }
                    }
                    else if (clickedBtn == "create_CD_orchestra")
                    {
                        bool orchestraValidated;

                        orchestraValidated = Validation.validateAnything(txtCDClassicalLabel.Text) &&
                                             Validation.validatePersonName(txtCDClassicalArtists.Text) &&
                                             Validation.validatePersonName(txtCDOrchestraConductor.Text);

                        if (orchestraValidated == true)
                        {
                            dbFunctions.InsertProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                      txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text), "CDOrchestra");

                            dbFunctions.InsertCDClassical(Convert.ToInt32(txtProductUPC.Text), txtCDClassicalLabel.Text, txtCDClassicalArtists.Text);

                            dbFunctions.InsertCDOrchestra(Convert.ToInt32(txtProductUPC.Text), txtCDOrchestraConductor.Text);

                            MessageBox.Show("Orchestra CD successfully inserted into database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the orchestra CD into the file. Check the entered information and try again!");
                        }
                    }
                }
                //this is for updating
                else
                {
                    string[] attributes = pstring.Split('\n'); // splits product attributes into array

                    for (int i = 0; i < attributes.Length; i++)
                    {
                        attributes[i] = attributes[i].Trim('\r'); // clears "junk" from each field
                    }

                    string ptype = attributes[4]; // gets the product type from this attribute and then creates new product to display in form

                    if (ptype == "Book")
                    {
                        bool bookValidated;

                        bookValidated = Validation.validateBookISBN(txtBookISBNLeft.Text) &&
                                        Validation.validateBookISBN(txtBookISBNRight.Text) &&
                                        Validation.validatePersonName(txtBookAuthor.Text) &&
                                        Validation.validatePositiveInteger(txtBookPages.Text);

                        if (bookValidated == true)
                        {
                            Book saveBook = new Book(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                     txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                                     Convert.ToInt32(txtBookISBNLeft.Text), Convert.ToInt32(txtBookISBNRight.Text),
                                                     txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));

                            dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                     txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));
                            dbFunctions.UpdateBook(Convert.ToInt32(txtProductUPC.Text), Convert.ToInt32(txtBookISBNLeft.Text + txtBookISBNRight.Text),
                                                     txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));

                            MessageBox.Show("Book successfully updated to database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the book into the file. Check the entered information and try again!");
                        }
                    }

                    if (ptype == "BookCIS")
                    {
                        bool bookCISValidated;

                        bookCISValidated = Validation.validateBookISBN(txtBookISBNLeft.Text) &&
                                           Validation.validateBookISBN(txtBookISBNRight.Text) &&
                                           Validation.validatePersonName(txtBookAuthor.Text) &&
                                           Validation.validatePositiveInteger(txtBookPages.Text) &&
                                           Validation.validateAnything(txtBookCISCISArea.Text);

                        if (bookCISValidated == true)
                        {
                            BookCIS saveCISBook = new BookCIS(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                     txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                                     Convert.ToInt32(txtBookISBNLeft.Text), Convert.ToInt32(txtBookISBNRight.Text),
                                                     txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text), txtBookCISCISArea.Text);

                            dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                    txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));

                            dbFunctions.UpdateBook(Convert.ToInt32(txtProductUPC.Text), Convert.ToInt32(txtBookISBNLeft.Text + txtBookISBNRight.Text),
                                                     txtBookAuthor.Text, Convert.ToInt32(txtBookPages.Text));

                            dbFunctions.UpdateBookCIS(Convert.ToInt32(txtProductUPC.Text), txtBookCISCISArea.Text);

                            MessageBox.Show("BookCIS successfully updated to database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the book into the file. Check the entered information and try again!");
                        }
                    }
                    if (ptype == "DVD")
                    {
                        bool dvdValidated;

                        dvdValidated = Validation.validatePersonName(txtDVDLeadActor.Text) &&
                                       Validation.validateDate(Convert.ToDateTime(txtDVDReleaseDate.Text)) &&
                                       Validation.validatePositiveInteger(txtDVDRunTime.Text);

                        if (dvdValidated == true)
                        {
                            DVD saveDVD = new DVD(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                     txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text),
                                                     txtDVDLeadActor.Text, Convert.ToDateTime(txtDVDReleaseDate.Text),
                                                     Convert.ToInt32(txtDVDRunTime.Text));

                            dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                    txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));

                            dbFunctions.UpdateDVD(Convert.ToInt32(txtProductUPC.Text), txtDVDLeadActor.Text,
                                                  Convert.ToDateTime(txtDVDReleaseDate.Text), Convert.ToInt32(txtDVDRunTime.Text));

                            MessageBox.Show("DVD successfully updated to database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the DVD into the file. Check the entered information and try again!");
                        }
                    }

                    if (ptype == "CDOrchestra")
                    {
                        bool orchestraValidated;

                        orchestraValidated = Validation.validateAnything(txtCDClassicalLabel.Text) &&
                                             Validation.validatePersonName(txtCDClassicalArtists.Text) &&
                                             Validation.validatePersonName(txtCDOrchestraConductor.Text);

                        if (orchestraValidated == true)
                        {
                            dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                      txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));

                            dbFunctions.UpdateCDClassical(Convert.ToInt32(txtProductUPC.Text), txtCDClassicalLabel.Text, txtCDClassicalArtists.Text);

                            dbFunctions.UpdateCDOrchestra(Convert.ToInt32(txtProductUPC.Text), txtCDOrchestraConductor.Text);

                            MessageBox.Show("CDOrchestra successfully updated to database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the orchestra CD into the file. Check the entered information and try again!");
                        }
                    }

                    if (ptype == "CDChamber")
                    {
                        bool chamberValidated;

                        chamberValidated = Validation.validateAnything(txtCDClassicalLabel.Text) &&
                                           Validation.validatePersonName(txtCDClassicalArtists.Text) &&
                                           Validation.validateAnything(txtCDChamberInstrumentList.Text);

                        if (chamberValidated == true)
                        {
                            dbFunctions.UpdateProduct(Convert.ToInt32(txtProductUPC.Text), Convert.ToDecimal(txtProductPrice.Text),
                                                      txtProductTitle.Text, Convert.ToInt32(txtProductQuantity.Text));
                            dbFunctions.UpdateCDClassical(Convert.ToInt32(txtProductUPC.Text), txtCDClassicalLabel.Text, txtCDClassicalArtists.Text);

                            dbFunctions.UpdateCDChamber(Convert.ToInt32(txtProductUPC.Text), txtCDChamberInstrumentList.Text);

                            MessageBox.Show("CDChamber successfully updated to database!");
                            recordsProcessedCount++;
                            FormController.clear(this);
                        }
                        else
                        {
                            MessageBox.Show("There was a problem inserting the chamber CD into the file. Check the entered information and try again!");
                        }
                    }
                }
            }

        }
    }
}