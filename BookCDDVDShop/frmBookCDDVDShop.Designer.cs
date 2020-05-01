namespace BookCDDVDShop
{
    partial class frmBookCDDVDShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.grpCDChamber = new System.Windows.Forms.GroupBox();
            this.txtCDChamberInstrumentList = new System.Windows.Forms.TextBox();
            this.lblInstuments = new System.Windows.Forms.Label();
            this.grpCDOrchestra = new System.Windows.Forms.GroupBox();
            this.txtCDOrchestraConductor = new System.Windows.Forms.TextBox();
            this.lblConductor = new System.Windows.Forms.Label();
            this.grpCDClassical = new System.Windows.Forms.GroupBox();
            this.txtCDClassicalArtists = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtCDClassicalLabel = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.grpDVD = new System.Windows.Forms.GroupBox();
            this.txtDVDRunTime = new System.Windows.Forms.TextBox();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.txtDVDReleaseDate = new System.Windows.Forms.TextBox();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtDVDLeadActor = new System.Windows.Forms.TextBox();
            this.lblLeadActor = new System.Windows.Forms.Label();
            this.grpBookCIS = new System.Windows.Forms.GroupBox();
            this.txtBookCISCISArea = new System.Windows.Forms.TextBox();
            this.lblCISArea = new System.Windows.Forms.Label();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.txtBookPages = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lbldash = new System.Windows.Forms.Label();
            this.txtBookISBNRight = new System.Windows.Forms.TextBox();
            this.txtBookISBNLeft = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProductUPC = new System.Windows.Forms.TextBox();
            this.lblUPC = new System.Windows.Forms.Label();
            this.lblFindSearch = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnCreateCDChamber = new System.Windows.Forms.Button();
            this.btnCreateCDOrchestra = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateBookCIS = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.grpfrmControls = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.lblalert2 = new System.Windows.Forms.Label();
            this.lblalert = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtProductUPCSearch = new System.Windows.Forms.TextBox();
            this.btnProductUPCSearch = new System.Windows.Forms.Button();
            this.grpProduct.SuspendLayout();
            this.grpCDChamber.SuspendLayout();
            this.grpCDOrchestra.SuspendLayout();
            this.grpCDClassical.SuspendLayout();
            this.grpDVD.SuspendLayout();
            this.grpBookCIS.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpfrmControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.grpCDChamber);
            this.grpProduct.Controls.Add(this.grpCDOrchestra);
            this.grpProduct.Controls.Add(this.grpCDClassical);
            this.grpProduct.Controls.Add(this.grpDVD);
            this.grpProduct.Controls.Add(this.grpBookCIS);
            this.grpProduct.Controls.Add(this.grpBook);
            this.grpProduct.Controls.Add(this.lblQuantity);
            this.grpProduct.Controls.Add(this.txtProductQuantity);
            this.grpProduct.Controls.Add(this.txtProductTitle);
            this.grpProduct.Controls.Add(this.lblTitle);
            this.grpProduct.Controls.Add(this.txtProductPrice);
            this.grpProduct.Controls.Add(this.lblPrice);
            this.grpProduct.Controls.Add(this.txtProductUPC);
            this.grpProduct.Controls.Add(this.lblUPC);
            this.grpProduct.Enabled = false;
            this.grpProduct.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduct.Location = new System.Drawing.Point(54, 197);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(1013, 487);
            this.grpProduct.TabIndex = 5;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product";
            // 
            // grpCDChamber
            // 
            this.grpCDChamber.Controls.Add(this.txtCDChamberInstrumentList);
            this.grpCDChamber.Controls.Add(this.lblInstuments);
            this.grpCDChamber.Enabled = false;
            this.grpCDChamber.Location = new System.Drawing.Point(499, 400);
            this.grpCDChamber.Name = "grpCDChamber";
            this.grpCDChamber.Size = new System.Drawing.Size(496, 61);
            this.grpCDChamber.TabIndex = 13;
            this.grpCDChamber.TabStop = false;
            this.grpCDChamber.Text = "CD Chamber Music";
            // 
            // txtCDChamberInstrumentList
            // 
            this.txtCDChamberInstrumentList.Location = new System.Drawing.Point(135, 25);
            this.txtCDChamberInstrumentList.Name = "txtCDChamberInstrumentList";
            this.txtCDChamberInstrumentList.Size = new System.Drawing.Size(203, 29);
            this.txtCDChamberInstrumentList.TabIndex = 3;
            // 
            // lblInstuments
            // 
            this.lblInstuments.AutoSize = true;
            this.lblInstuments.Location = new System.Drawing.Point(16, 28);
            this.lblInstuments.Name = "lblInstuments";
            this.lblInstuments.Size = new System.Drawing.Size(104, 23);
            this.lblInstuments.TabIndex = 2;
            this.lblInstuments.Text = "Instruments";
            // 
            // grpCDOrchestra
            // 
            this.grpCDOrchestra.Controls.Add(this.txtCDOrchestraConductor);
            this.grpCDOrchestra.Controls.Add(this.lblConductor);
            this.grpCDOrchestra.Enabled = false;
            this.grpCDOrchestra.Location = new System.Drawing.Point(18, 400);
            this.grpCDOrchestra.Name = "grpCDOrchestra";
            this.grpCDOrchestra.Size = new System.Drawing.Size(465, 61);
            this.grpCDOrchestra.TabIndex = 12;
            this.grpCDOrchestra.TabStop = false;
            this.grpCDOrchestra.Text = "CD Orchestral Music";
            // 
            // txtCDOrchestraConductor
            // 
            this.txtCDOrchestraConductor.Location = new System.Drawing.Point(132, 25);
            this.txtCDOrchestraConductor.Name = "txtCDOrchestraConductor";
            this.txtCDOrchestraConductor.Size = new System.Drawing.Size(166, 29);
            this.txtCDOrchestraConductor.TabIndex = 3;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(16, 28);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(95, 23);
            this.lblConductor.TabIndex = 2;
            this.lblConductor.Text = "Conductor";
            // 
            // grpCDClassical
            // 
            this.grpCDClassical.Controls.Add(this.txtCDClassicalArtists);
            this.grpCDClassical.Controls.Add(this.lblArtist);
            this.grpCDClassical.Controls.Add(this.txtCDClassicalLabel);
            this.grpCDClassical.Controls.Add(this.lblLabel);
            this.grpCDClassical.Enabled = false;
            this.grpCDClassical.Location = new System.Drawing.Point(18, 321);
            this.grpCDClassical.Name = "grpCDClassical";
            this.grpCDClassical.Size = new System.Drawing.Size(977, 61);
            this.grpCDClassical.TabIndex = 11;
            this.grpCDClassical.TabStop = false;
            this.grpCDClassical.Text = "CDClassical";
            // 
            // txtCDClassicalArtists
            // 
            this.txtCDClassicalArtists.Location = new System.Drawing.Point(346, 25);
            this.txtCDClassicalArtists.Name = "txtCDClassicalArtists";
            this.txtCDClassicalArtists.Size = new System.Drawing.Size(249, 29);
            this.txtCDClassicalArtists.TabIndex = 5;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(287, 28);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(53, 23);
            this.lblArtist.TabIndex = 4;
            this.lblArtist.Text = "Artist";
            // 
            // txtCDClassicalLabel
            // 
            this.txtCDClassicalLabel.Location = new System.Drawing.Point(78, 25);
            this.txtCDClassicalLabel.Name = "txtCDClassicalLabel";
            this.txtCDClassicalLabel.Size = new System.Drawing.Size(173, 29);
            this.txtCDClassicalLabel.TabIndex = 3;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.Location = new System.Drawing.Point(16, 28);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(52, 23);
            this.lblLabel.TabIndex = 2;
            this.lblLabel.Text = "Label";
            // 
            // grpDVD
            // 
            this.grpDVD.Controls.Add(this.txtDVDRunTime);
            this.grpDVD.Controls.Add(this.lblRunTime);
            this.grpDVD.Controls.Add(this.txtDVDReleaseDate);
            this.grpDVD.Controls.Add(this.lblReleaseDate);
            this.grpDVD.Controls.Add(this.txtDVDLeadActor);
            this.grpDVD.Controls.Add(this.lblLeadActor);
            this.grpDVD.Enabled = false;
            this.grpDVD.Location = new System.Drawing.Point(18, 241);
            this.grpDVD.Name = "grpDVD";
            this.grpDVD.Size = new System.Drawing.Size(977, 61);
            this.grpDVD.TabIndex = 10;
            this.grpDVD.TabStop = false;
            this.grpDVD.Text = "DVD";
            // 
            // txtDVDRunTime
            // 
            this.txtDVDRunTime.Location = new System.Drawing.Point(881, 25);
            this.txtDVDRunTime.Name = "txtDVDRunTime";
            this.txtDVDRunTime.Size = new System.Drawing.Size(78, 29);
            this.txtDVDRunTime.TabIndex = 7;
            // 
            // lblRunTime
            // 
            this.lblRunTime.AutoSize = true;
            this.lblRunTime.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunTime.Location = new System.Drawing.Point(785, 28);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(90, 23);
            this.lblRunTime.TabIndex = 6;
            this.lblRunTime.Text = "Run Time";
            // 
            // txtDVDReleaseDate
            // 
            this.txtDVDReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDVDReleaseDate.Location = new System.Drawing.Point(500, 25);
            this.txtDVDReleaseDate.Name = "txtDVDReleaseDate";
            this.txtDVDReleaseDate.Size = new System.Drawing.Size(136, 29);
            this.txtDVDReleaseDate.TabIndex = 5;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(381, 28);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(107, 23);
            this.lblReleaseDate.TabIndex = 4;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // txtDVDLeadActor
            // 
            this.txtDVDLeadActor.Location = new System.Drawing.Point(118, 25);
            this.txtDVDLeadActor.Name = "txtDVDLeadActor";
            this.txtDVDLeadActor.Size = new System.Drawing.Size(166, 29);
            this.txtDVDLeadActor.TabIndex = 3;
            // 
            // lblLeadActor
            // 
            this.lblLeadActor.AutoSize = true;
            this.lblLeadActor.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeadActor.Location = new System.Drawing.Point(16, 28);
            this.lblLeadActor.Name = "lblLeadActor";
            this.lblLeadActor.Size = new System.Drawing.Size(96, 23);
            this.lblLeadActor.TabIndex = 2;
            this.lblLeadActor.Text = "Lead Actor";
            // 
            // grpBookCIS
            // 
            this.grpBookCIS.Controls.Add(this.txtBookCISCISArea);
            this.grpBookCIS.Controls.Add(this.lblCISArea);
            this.grpBookCIS.Enabled = false;
            this.grpBookCIS.Location = new System.Drawing.Point(18, 154);
            this.grpBookCIS.Name = "grpBookCIS";
            this.grpBookCIS.Size = new System.Drawing.Size(977, 62);
            this.grpBookCIS.TabIndex = 9;
            this.grpBookCIS.TabStop = false;
            this.grpBookCIS.Text = "CIS Book";
            // 
            // txtBookCISCISArea
            // 
            this.txtBookCISCISArea.Location = new System.Drawing.Point(110, 27);
            this.txtBookCISCISArea.Name = "txtBookCISCISArea";
            this.txtBookCISCISArea.Size = new System.Drawing.Size(153, 29);
            this.txtBookCISCISArea.TabIndex = 1;
            // 
            // lblCISArea
            // 
            this.lblCISArea.AutoSize = true;
            this.lblCISArea.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCISArea.Location = new System.Drawing.Point(16, 27);
            this.lblCISArea.Name = "lblCISArea";
            this.lblCISArea.Size = new System.Drawing.Size(80, 23);
            this.lblCISArea.TabIndex = 0;
            this.lblCISArea.Text = "CIS Area";
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.txtBookPages);
            this.grpBook.Controls.Add(this.lblPages);
            this.grpBook.Controls.Add(this.txtBookAuthor);
            this.grpBook.Controls.Add(this.lblAuthor);
            this.grpBook.Controls.Add(this.lbldash);
            this.grpBook.Controls.Add(this.txtBookISBNRight);
            this.grpBook.Controls.Add(this.txtBookISBNLeft);
            this.grpBook.Controls.Add(this.lblISBN);
            this.grpBook.Enabled = false;
            this.grpBook.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBook.Location = new System.Drawing.Point(18, 65);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(1000, 73);
            this.grpBook.TabIndex = 8;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // txtBookPages
            // 
            this.txtBookPages.Location = new System.Drawing.Point(871, 31);
            this.txtBookPages.Name = "txtBookPages";
            this.txtBookPages.Size = new System.Drawing.Size(67, 29);
            this.txtBookPages.TabIndex = 15;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(794, 34);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(52, 23);
            this.lblPages.TabIndex = 14;
            this.lblPages.Text = "Pages";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(466, 31);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(160, 29);
            this.txtBookAuthor.TabIndex = 13;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(394, 34);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(66, 23);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "Author";
            // 
            // lbldash
            // 
            this.lbldash.AutoSize = true;
            this.lbldash.Location = new System.Drawing.Point(129, 31);
            this.lbldash.Name = "lbldash";
            this.lbldash.Size = new System.Drawing.Size(14, 23);
            this.lbldash.TabIndex = 11;
            this.lbldash.Text = "-";
            // 
            // txtBookISBNRight
            // 
            this.txtBookISBNRight.Location = new System.Drawing.Point(148, 28);
            this.txtBookISBNRight.Name = "txtBookISBNRight";
            this.txtBookISBNRight.Size = new System.Drawing.Size(40, 29);
            this.txtBookISBNRight.TabIndex = 10;
            // 
            // txtBookISBNLeft
            // 
            this.txtBookISBNLeft.Location = new System.Drawing.Point(83, 28);
            this.txtBookISBNLeft.Name = "txtBookISBNLeft";
            this.txtBookISBNLeft.Size = new System.Drawing.Size(40, 29);
            this.txtBookISBNLeft.TabIndex = 9;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(15, 31);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(53, 23);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(808, 32);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 23);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(889, 28);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(75, 29);
            this.txtProductQuantity.TabIndex = 6;
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Location = new System.Drawing.Point(566, 28);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(159, 29);
            this.txtProductTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(511, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(315, 28);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(115, 29);
            this.txtProductPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(259, 32);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // txtProductUPC
            // 
            this.txtProductUPC.Location = new System.Drawing.Point(89, 28);
            this.txtProductUPC.Name = "txtProductUPC";
            this.txtProductUPC.Size = new System.Drawing.Size(134, 29);
            this.txtProductUPC.TabIndex = 1;
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUPC.Location = new System.Drawing.Point(33, 32);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(50, 23);
            this.lblUPC.TabIndex = 0;
            this.lblUPC.Text = "UPC";
            // 
            // lblFindSearch
            // 
            this.lblFindSearch.AutoSize = true;
            this.lblFindSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblFindSearch.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFindSearch.Location = new System.Drawing.Point(58, 166);
            this.lblFindSearch.Name = "lblFindSearch";
            this.lblFindSearch.Size = new System.Drawing.Size(1150, 28);
            this.lblFindSearch.TabIndex = 6;
            this.lblFindSearch.Text = "To Find/Search, Edit/UPDATE or DELETE, enter Product UPC and Select applropriate " +
    "control at bottom of form.";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Forte", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(266, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(793, 41);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Data Entry and Display for Book CD DVD Shop";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.lblC.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.Black;
            this.lblC.Location = new System.Drawing.Point(58, 50);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(1157, 28);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "To CREATE a new Book, CIS Book, DVD, Orchestra CD or Chamber CD, always press a b" +
    "utton below before typing.";
            // 
            // grpControls
            // 
            this.grpControls.BackColor = System.Drawing.Color.Transparent;
            this.grpControls.BackgroundImage = global::BookCDDVDShop.Properties.Resources.old_background;
            this.grpControls.Controls.Add(this.btnCreateCDChamber);
            this.grpControls.Controls.Add(this.btnCreateCDOrchestra);
            this.grpControls.Controls.Add(this.btnCreateDVD);
            this.grpControls.Controls.Add(this.btnCreateBookCIS);
            this.grpControls.Controls.Add(this.btnCreateBook);
            this.grpControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpControls.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpControls.Location = new System.Drawing.Point(54, 81);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(1013, 82);
            this.grpControls.TabIndex = 9;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls for Creating a New Entry";
            // 
            // btnCreateCDChamber
            // 
            this.btnCreateCDChamber.Location = new System.Drawing.Point(752, 21);
            this.btnCreateCDChamber.Name = "btnCreateCDChamber";
            this.btnCreateCDChamber.Size = new System.Drawing.Size(167, 55);
            this.btnCreateCDChamber.TabIndex = 4;
            this.btnCreateCDChamber.Text = "Create CD Chamber";
            this.btnCreateCDChamber.UseVisualStyleBackColor = true;
            this.btnCreateCDChamber.Click += new System.EventHandler(this.btnCreateCDChamber_Click);
            // 
            // btnCreateCDOrchestra
            // 
            this.btnCreateCDOrchestra.Location = new System.Drawing.Point(566, 21);
            this.btnCreateCDOrchestra.Name = "btnCreateCDOrchestra";
            this.btnCreateCDOrchestra.Size = new System.Drawing.Size(167, 55);
            this.btnCreateCDOrchestra.TabIndex = 3;
            this.btnCreateCDOrchestra.Text = "Create CD Orchestra";
            this.btnCreateCDOrchestra.UseVisualStyleBackColor = true;
            this.btnCreateCDOrchestra.Click += new System.EventHandler(this.btnCreateCDOrchestra_Click);
            // 
            // btnCreateDVD
            // 
            this.btnCreateDVD.Location = new System.Drawing.Point(384, 21);
            this.btnCreateDVD.Name = "btnCreateDVD";
            this.btnCreateDVD.Size = new System.Drawing.Size(167, 55);
            this.btnCreateDVD.TabIndex = 2;
            this.btnCreateDVD.Text = "Create DVD";
            this.btnCreateDVD.UseVisualStyleBackColor = true;
            this.btnCreateDVD.Click += new System.EventHandler(this.btnCreateDVD_Click);
            // 
            // btnCreateBookCIS
            // 
            this.btnCreateBookCIS.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBookCIS.Location = new System.Drawing.Point(202, 21);
            this.btnCreateBookCIS.Name = "btnCreateBookCIS";
            this.btnCreateBookCIS.Size = new System.Drawing.Size(167, 55);
            this.btnCreateBookCIS.TabIndex = 1;
            this.btnCreateBookCIS.Text = "Create CIS Book";
            this.btnCreateBookCIS.UseVisualStyleBackColor = true;
            this.btnCreateBookCIS.Click += new System.EventHandler(this.btnCreateBookCIS_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(18, 21);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(167, 55);
            this.btnCreateBook.TabIndex = 0;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // grpfrmControls
            // 
            this.grpfrmControls.Controls.Add(this.btnDelete);
            this.grpfrmControls.Controls.Add(this.btnSave);
            this.grpfrmControls.Controls.Add(this.btnEditUpdate);
            this.grpfrmControls.Controls.Add(this.lblalert2);
            this.grpfrmControls.Controls.Add(this.lblalert);
            this.grpfrmControls.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpfrmControls.Location = new System.Drawing.Point(54, 706);
            this.grpfrmControls.Name = "grpfrmControls";
            this.grpfrmControls.Size = new System.Drawing.Size(1013, 149);
            this.grpfrmControls.TabIndex = 15;
            this.grpfrmControls.TabStop = false;
            this.grpfrmControls.Text = "Form Controls for Data Processing";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(829, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 53);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(416, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 53);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.Enabled = false;
            this.btnEditUpdate.Location = new System.Drawing.Point(61, 82);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(135, 53);
            this.btnEditUpdate.TabIndex = 4;
            this.btnEditUpdate.Text = "Edit/Update";
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // lblalert2
            // 
            this.lblalert2.AutoSize = true;
            this.lblalert2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblalert2.Location = new System.Drawing.Point(15, 47);
            this.lblalert2.Name = "lblalert2";
            this.lblalert2.Size = new System.Drawing.Size(399, 23);
            this.lblalert2.TabIndex = 1;
            this.lblalert2.Text = "Press CLEAR FORM when operation is complete.";
            // 
            // lblalert
            // 
            this.lblalert.AutoSize = true;
            this.lblalert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblalert.Location = new System.Drawing.Point(15, 24);
            this.lblalert.Name = "lblalert";
            this.lblalert.Size = new System.Drawing.Size(712, 23);
            this.lblalert.TabIndex = 0;
            this.lblalert.Text = "These operations require entry of an Product UPC (see above) before they can be e" +
    "xecuted.";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1086, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 62);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1088, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 62);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtProductUPCSearch
            // 
            this.txtProductUPCSearch.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductUPCSearch.Location = new System.Drawing.Point(1079, 87);
            this.txtProductUPCSearch.Name = "txtProductUPCSearch";
            this.txtProductUPCSearch.Size = new System.Drawing.Size(146, 29);
            this.txtProductUPCSearch.TabIndex = 18;
            // 
            // btnProductUPCSearch
            // 
            this.btnProductUPCSearch.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductUPCSearch.Location = new System.Drawing.Point(1088, 122);
            this.btnProductUPCSearch.Name = "btnProductUPCSearch";
            this.btnProductUPCSearch.Size = new System.Drawing.Size(129, 41);
            this.btnProductUPCSearch.TabIndex = 19;
            this.btnProductUPCSearch.Text = "Search UPC";
            this.btnProductUPCSearch.UseVisualStyleBackColor = true;
            this.btnProductUPCSearch.Click += new System.EventHandler(this.btnProductUPCSearch_Click);
            // 
            // frmBookCDDVDShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookCDDVDShop.Properties.Resources.old_background;
            this.ClientSize = new System.Drawing.Size(1258, 857);
            this.Controls.Add(this.btnProductUPCSearch);
            this.Controls.Add(this.txtProductUPCSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpfrmControls);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblFindSearch);
            this.Controls.Add(this.grpProduct);
            this.Name = "frmBookCDDVDShop";
            this.Text = "Book CD DVD";
            this.Load += new System.EventHandler(this.frmBookCDDVDShop_Load);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpCDChamber.ResumeLayout(false);
            this.grpCDChamber.PerformLayout();
            this.grpCDOrchestra.ResumeLayout(false);
            this.grpCDOrchestra.PerformLayout();
            this.grpCDClassical.ResumeLayout(false);
            this.grpCDClassical.PerformLayout();
            this.grpDVD.ResumeLayout(false);
            this.grpDVD.PerformLayout();
            this.grpBookCIS.ResumeLayout(false);
            this.grpBookCIS.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpfrmControls.ResumeLayout(false);
            this.grpfrmControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpProduct;
        internal System.Windows.Forms.GroupBox grpCDChamber;
        internal System.Windows.Forms.TextBox txtCDChamberInstrumentList;
        internal System.Windows.Forms.Label lblInstuments;
        internal System.Windows.Forms.GroupBox grpCDOrchestra;
        internal System.Windows.Forms.TextBox txtCDOrchestraConductor;
        internal System.Windows.Forms.Label lblConductor;
        internal System.Windows.Forms.GroupBox grpCDClassical;
        internal System.Windows.Forms.TextBox txtCDClassicalArtists;
        internal System.Windows.Forms.Label lblArtist;
        internal System.Windows.Forms.TextBox txtCDClassicalLabel;
        internal System.Windows.Forms.Label lblLabel;
        internal System.Windows.Forms.GroupBox grpDVD;
        internal System.Windows.Forms.TextBox txtDVDRunTime;
        internal System.Windows.Forms.Label lblRunTime;
        internal System.Windows.Forms.TextBox txtDVDReleaseDate;
        internal System.Windows.Forms.Label lblReleaseDate;
        internal System.Windows.Forms.TextBox txtDVDLeadActor;
        internal System.Windows.Forms.Label lblLeadActor;
        internal System.Windows.Forms.GroupBox grpBookCIS;
        internal System.Windows.Forms.TextBox txtBookCISCISArea;
        internal System.Windows.Forms.Label lblCISArea;
        internal System.Windows.Forms.GroupBox grpBook;
        internal System.Windows.Forms.TextBox txtBookPages;
        internal System.Windows.Forms.Label lblPages;
        internal System.Windows.Forms.TextBox txtBookAuthor;
        internal System.Windows.Forms.Label lblAuthor;
        internal System.Windows.Forms.Label lbldash;
        internal System.Windows.Forms.TextBox txtBookISBNRight;
        internal System.Windows.Forms.TextBox txtBookISBNLeft;
        internal System.Windows.Forms.Label lblISBN;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.TextBox txtProductQuantity;
        internal System.Windows.Forms.TextBox txtProductTitle;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.TextBox txtProductPrice;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.Label lblUPC;
        internal System.Windows.Forms.Label lblFindSearch;
        internal System.Windows.Forms.Label lblHeader;
        internal System.Windows.Forms.Label lblC;
        internal System.Windows.Forms.GroupBox grpControls;
        internal System.Windows.Forms.Button btnCreateCDChamber;
        internal System.Windows.Forms.Button btnCreateCDOrchestra;
        internal System.Windows.Forms.Button btnCreateDVD;
        internal System.Windows.Forms.Button btnCreateBookCIS;
        internal System.Windows.Forms.Button btnCreateBook;
        internal System.Windows.Forms.GroupBox grpfrmControls;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnEditUpdate;
        internal System.Windows.Forms.Label lblalert2;
        internal System.Windows.Forms.Label lblalert;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.TextBox txtProductUPC;
        internal System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.TextBox txtProductUPCSearch;
        internal System.Windows.Forms.Button btnProductUPCSearch;
    }
}

