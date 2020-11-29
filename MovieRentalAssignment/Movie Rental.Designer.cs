namespace MovieRentalAssignment
{
    partial class Movie_Rental
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
            this.TabControlSystem = new System.Windows.Forms.TabControl();
            this.Movies = new System.Windows.Forms.TabPage();
            this.MovieDataGridView = new System.Windows.Forms.DataGridView();
            this.Customers = new System.Windows.Forms.TabPage();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.RentedMovies = new System.Windows.Forms.TabPage();
            this.RentalDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1Show = new System.Windows.Forms.Button();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResetCust = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.GroupBoxReturnMovie = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DropDownAllCust = new System.Windows.Forms.ComboBox();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlRentedMovies = new System.Windows.Forms.ComboBox();
            this.gbRentMovie = new System.Windows.Forms.GroupBox();
            this.DropDownMovie = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DropDownSelectCustomer = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtIsuue = new System.Windows.Forms.DateTimePicker();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.buttonAllRented = new System.Windows.Forms.Button();
            this.buttonMostPopular = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxMovie = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1ShowData = new System.Windows.Forms.Button();
            this.TextBoxMovieID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelMOvie = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxStoryLine = new System.Windows.Forms.TextBox();
            this.btnAddMOvie = new System.Windows.Forms.Button();
            this.TextBoxStarRating = new System.Windows.Forms.TextBox();
            this.TextBoxRent = new System.Windows.Forms.TextBox();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.TextBoxMOvieTitle = new System.Windows.Forms.TextBox();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.TabControlSystem.SuspendLayout();
            this.Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGridView)).BeginInit();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.RentedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGridView)).BeginInit();
            this.CustomerBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GroupBoxReturnMovie.SuspendLayout();
            this.gbRentMovie.SuspendLayout();
            this.groupBoxMovie.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlSystem
            // 
            this.TabControlSystem.Controls.Add(this.Movies);
            this.TabControlSystem.Controls.Add(this.Customers);
            this.TabControlSystem.Controls.Add(this.RentedMovies);
            this.TabControlSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlSystem.Location = new System.Drawing.Point(3, 2);
            this.TabControlSystem.Margin = new System.Windows.Forms.Padding(4);
            this.TabControlSystem.Name = "TabControlSystem";
            this.TabControlSystem.SelectedIndex = 0;
            this.TabControlSystem.Size = new System.Drawing.Size(1425, 363);
            this.TabControlSystem.TabIndex = 22;
            this.TabControlSystem.SelectedIndexChanged += new System.EventHandler(this.TabControlSystem_SelectedIndexChanged);
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.MovieDataGridView);
            this.Movies.Location = new System.Drawing.Point(4, 35);
            this.Movies.Margin = new System.Windows.Forms.Padding(4);
            this.Movies.Name = "Movies";
            this.Movies.Padding = new System.Windows.Forms.Padding(4);
            this.Movies.Size = new System.Drawing.Size(1417, 324);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = true;
            // 
            // MovieDataGridView
            // 
            this.MovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDataGridView.Location = new System.Drawing.Point(5, 7);
            this.MovieDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.MovieDataGridView.Name = "MovieDataGridView";
            this.MovieDataGridView.RowHeadersWidth = 51;
            this.MovieDataGridView.Size = new System.Drawing.Size(1404, 309);
            this.MovieDataGridView.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.CustomersDataGridView);
            this.Customers.Location = new System.Drawing.Point(4, 35);
            this.Customers.Margin = new System.Windows.Forms.Padding(4);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(4);
            this.Customers.Size = new System.Drawing.Size(1417, 324);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(8, 7);
            this.CustomersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.RowHeadersWidth = 51;
            this.CustomersDataGridView.Size = new System.Drawing.Size(1401, 308);
            this.CustomersDataGridView.TabIndex = 0;
            // 
            // RentedMovies
            // 
            this.RentedMovies.BackColor = System.Drawing.Color.Transparent;
            this.RentedMovies.Controls.Add(this.RentalDataGridView);
            this.RentedMovies.Location = new System.Drawing.Point(4, 35);
            this.RentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.RentedMovies.Name = "RentedMovies";
            this.RentedMovies.Size = new System.Drawing.Size(1417, 324);
            this.RentedMovies.TabIndex = 2;
            this.RentedMovies.Text = "Rented Movies";
            // 
            // RentalDataGridView
            // 
            this.RentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalDataGridView.Location = new System.Drawing.Point(4, 4);
            this.RentalDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.RentalDataGridView.Name = "RentalDataGridView";
            this.RentalDataGridView.RowHeadersWidth = 51;
            this.RentalDataGridView.Size = new System.Drawing.Size(1409, 315);
            this.RentalDataGridView.TabIndex = 0;
            // 
            // CustomerBox
            // 
            this.CustomerBox.BackColor = System.Drawing.Color.GreenYellow;
            this.CustomerBox.Controls.Add(this.panel2);
            this.CustomerBox.Controls.Add(this.panel1);
            this.CustomerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBox.Location = new System.Drawing.Point(12, 384);
            this.CustomerBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerBox.Size = new System.Drawing.Size(1061, 322);
            this.CustomerBox.TabIndex = 45;
            this.CustomerBox.TabStop = false;
            this.CustomerBox.Text = "Customer";
            this.CustomerBox.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.button1Show);
            this.panel2.Controls.Add(this.tbxCustomerID);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.DeleteCustomer);
            this.panel2.Controls.Add(this.UpdateCustomer);
            this.panel2.Location = new System.Drawing.Point(8, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 89);
            this.panel2.TabIndex = 55;
            // 
            // button1Show
            // 
            this.button1Show.BackColor = System.Drawing.Color.ForestGreen;
            this.button1Show.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1Show.Location = new System.Drawing.Point(298, 19);
            this.button1Show.Margin = new System.Windows.Forms.Padding(5);
            this.button1Show.Name = "button1Show";
            this.button1Show.Size = new System.Drawing.Size(162, 49);
            this.button1Show.TabIndex = 58;
            this.button1Show.Text = "Show Data";
            this.button1Show.UseVisualStyleBackColor = false;
            this.button1Show.Click += new System.EventHandler(this.Button1Show_Click);
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(157, 28);
            this.tbxCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.Size = new System.Drawing.Size(132, 32);
            this.tbxCustomerID.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 24);
            this.label13.TabIndex = 56;
            this.label13.Text = "Customer Id:";
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.ForestGreen;
            this.DeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteCustomer.Location = new System.Drawing.Point(765, 19);
            this.DeleteCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(237, 49);
            this.DeleteCustomer.TabIndex = 55;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = false;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.BackColor = System.Drawing.Color.ForestGreen;
            this.UpdateCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateCustomer.Location = new System.Drawing.Point(501, 19);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(253, 49);
            this.UpdateCustomer.TabIndex = 54;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.buttonResetCust);
            this.panel1.Controls.Add(this.textBoxLastName);
            this.panel1.Controls.Add(this.TextBoxFirstName);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.AddCustomer);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Location = new System.Drawing.Point(9, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 155);
            this.panel1.TabIndex = 54;
            // 
            // buttonResetCust
            // 
            this.buttonResetCust.BackColor = System.Drawing.Color.Teal;
            this.buttonResetCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonResetCust.Location = new System.Drawing.Point(786, 96);
            this.buttonResetCust.Name = "buttonResetCust";
            this.buttonResetCust.Size = new System.Drawing.Size(162, 42);
            this.buttonResetCust.TabIndex = 56;
            this.buttonResetCust.Text = "Reset";
            this.buttonResetCust.UseVisualStyleBackColor = false;
            this.buttonResetCust.Click += new System.EventHandler(this.ButtonResetCust_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(263, 23);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(212, 32);
            this.textBoxLastName.TabIndex = 45;
            this.textBoxLastName.Text = "Last Name...";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(19, 23);
            this.TextBoxFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(212, 32);
            this.TextBoxFirstName.TabIndex = 44;
            this.TextBoxFirstName.Text = "First Name...";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(19, 78);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(712, 63);
            this.textBoxAddress.TabIndex = 31;
            this.textBoxAddress.Text = "Address...";
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.ForestGreen;
            this.AddCustomer.ForeColor = System.Drawing.Color.White;
            this.AddCustomer.Location = new System.Drawing.Point(783, 23);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(213, 49);
            this.AddCustomer.TabIndex = 43;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(519, 23);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(212, 32);
            this.textBoxPhone.TabIndex = 32;
            this.textBoxPhone.Text = "Phone...";
            // 
            // GroupBoxReturnMovie
            // 
            this.GroupBoxReturnMovie.BackColor = System.Drawing.Color.YellowGreen;
            this.GroupBoxReturnMovie.Controls.Add(this.label12);
            this.GroupBoxReturnMovie.Controls.Add(this.DropDownAllCust);
            this.GroupBoxReturnMovie.Controls.Add(this.btnReturnMovie);
            this.GroupBoxReturnMovie.Controls.Add(this.label11);
            this.GroupBoxReturnMovie.Controls.Add(this.ddlRentedMovies);
            this.GroupBoxReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxReturnMovie.Location = new System.Drawing.Point(1436, 402);
            this.GroupBoxReturnMovie.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxReturnMovie.Name = "GroupBoxReturnMovie";
            this.GroupBoxReturnMovie.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxReturnMovie.Size = new System.Drawing.Size(477, 319);
            this.GroupBoxReturnMovie.TabIndex = 61;
            this.GroupBoxReturnMovie.TabStop = false;
            this.GroupBoxReturnMovie.Text = "Movie Return";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 60);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 26);
            this.label12.TabIndex = 56;
            this.label12.Text = "Customer:";
            // 
            // DropDownAllCust
            // 
            this.DropDownAllCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownAllCust.FormattingEnabled = true;
            this.DropDownAllCust.Location = new System.Drawing.Point(200, 60);
            this.DropDownAllCust.Margin = new System.Windows.Forms.Padding(4);
            this.DropDownAllCust.Name = "DropDownAllCust";
            this.DropDownAllCust.Size = new System.Drawing.Size(250, 34);
            this.DropDownAllCust.TabIndex = 55;
            this.DropDownAllCust.SelectedIndexChanged += new System.EventHandler(this.DropDownAllCust_SelectedIndexChanged);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturnMovie.Location = new System.Drawing.Point(31, 215);
            this.btnReturnMovie.Margin = new System.Windows.Forms.Padding(5);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(179, 50);
            this.btnReturnMovie.TabIndex = 28;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.BtnReturnMovie_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 26);
            this.label11.TabIndex = 54;
            this.label11.Text = "Rented Movie:";
            // 
            // ddlRentedMovies
            // 
            this.ddlRentedMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRentedMovies.FormattingEnabled = true;
            this.ddlRentedMovies.Location = new System.Drawing.Point(200, 121);
            this.ddlRentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.ddlRentedMovies.Name = "ddlRentedMovies";
            this.ddlRentedMovies.Size = new System.Drawing.Size(250, 34);
            this.ddlRentedMovies.TabIndex = 53;
            // 
            // gbRentMovie
            // 
            this.gbRentMovie.BackColor = System.Drawing.Color.YellowGreen;
            this.gbRentMovie.Controls.Add(this.DropDownMovie);
            this.gbRentMovie.Controls.Add(this.label16);
            this.gbRentMovie.Controls.Add(this.DropDownSelectCustomer);
            this.gbRentMovie.Controls.Add(this.label15);
            this.gbRentMovie.Controls.Add(this.label9);
            this.gbRentMovie.Controls.Add(this.dtReturn);
            this.gbRentMovie.Controls.Add(this.label10);
            this.gbRentMovie.Controls.Add(this.label1);
            this.gbRentMovie.Controls.Add(this.dtIsuue);
            this.gbRentMovie.Controls.Add(this.btnIssueMovie);
            this.gbRentMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRentMovie.Location = new System.Drawing.Point(1436, 15);
            this.gbRentMovie.Margin = new System.Windows.Forms.Padding(4);
            this.gbRentMovie.Name = "gbRentMovie";
            this.gbRentMovie.Padding = new System.Windows.Forms.Padding(4);
            this.gbRentMovie.Size = new System.Drawing.Size(477, 366);
            this.gbRentMovie.TabIndex = 62;
            this.gbRentMovie.TabStop = false;
            this.gbRentMovie.Text = "Movie Rent Panel";
            // 
            // DropDownMovie
            // 
            this.DropDownMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownMovie.FormattingEnabled = true;
            this.DropDownMovie.Location = new System.Drawing.Point(183, 114);
            this.DropDownMovie.Margin = new System.Windows.Forms.Padding(4);
            this.DropDownMovie.Name = "DropDownMovie";
            this.DropDownMovie.Size = new System.Drawing.Size(250, 34);
            this.DropDownMovie.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(44, 57);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 26);
            this.label16.TabIndex = 69;
            this.label16.Text = "Customer:";
            // 
            // DropDownSelectCustomer
            // 
            this.DropDownSelectCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownSelectCustomer.FormattingEnabled = true;
            this.DropDownSelectCustomer.Location = new System.Drawing.Point(183, 57);
            this.DropDownSelectCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DropDownSelectCustomer.Name = "DropDownSelectCustomer";
            this.DropDownSelectCustomer.Size = new System.Drawing.Size(250, 34);
            this.DropDownSelectCustomer.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(76, 114);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 26);
            this.label15.TabIndex = 56;
            this.label15.Text = "Movie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 26);
            this.label9.TabIndex = 49;
            this.label9.Text = "Issue Date:";
            // 
            // dtReturn
            // 
            this.dtReturn.Location = new System.Drawing.Point(183, 233);
            this.dtReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(250, 32);
            this.dtReturn.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 239);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 26);
            this.label10.TabIndex = 52;
            this.label10.Text = "Return Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, -82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Select Movie:";
            // 
            // dtIsuue
            // 
            this.dtIsuue.Location = new System.Drawing.Point(183, 175);
            this.dtIsuue.Margin = new System.Windows.Forms.Padding(4);
            this.dtIsuue.Name = "dtIsuue";
            this.dtIsuue.Size = new System.Drawing.Size(250, 32);
            this.dtIsuue.TabIndex = 50;
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIssueMovie.Location = new System.Drawing.Point(29, 290);
            this.btnIssueMovie.Margin = new System.Windows.Forms.Padding(5);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(207, 50);
            this.btnIssueMovie.TabIndex = 27;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.BtnIssueMovie_Click);
            // 
            // buttonAllRented
            // 
            this.buttonAllRented.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonAllRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllRented.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAllRented.Location = new System.Drawing.Point(1135, 591);
            this.buttonAllRented.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllRented.Name = "buttonAllRented";
            this.buttonAllRented.Size = new System.Drawing.Size(289, 80);
            this.buttonAllRented.TabIndex = 63;
            this.buttonAllRented.Text = "All Rented Movies";
            this.buttonAllRented.UseVisualStyleBackColor = false;
            this.buttonAllRented.Click += new System.EventHandler(this.ButtonAllRented_Click);
            // 
            // buttonMostPopular
            // 
            this.buttonMostPopular.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonMostPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostPopular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMostPopular.Location = new System.Drawing.Point(1135, 406);
            this.buttonMostPopular.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMostPopular.Name = "buttonMostPopular";
            this.buttonMostPopular.Size = new System.Drawing.Size(289, 82);
            this.buttonMostPopular.TabIndex = 64;
            this.buttonMostPopular.Text = "Most Popular Movies";
            this.buttonMostPopular.UseVisualStyleBackColor = false;
            this.buttonMostPopular.Click += new System.EventHandler(this.ButtonMostPopular_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1135, 496);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 87);
            this.button3.TabIndex = 65;
            this.button3.Text = "Customer Borrows Most Movies";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBoxMovie
            // 
            this.groupBoxMovie.BackColor = System.Drawing.Color.GreenYellow;
            this.groupBoxMovie.Controls.Add(this.panel4);
            this.groupBoxMovie.Controls.Add(this.panel3);
            this.groupBoxMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMovie.Location = new System.Drawing.Point(13, 383);
            this.groupBoxMovie.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMovie.Name = "groupBoxMovie";
            this.groupBoxMovie.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMovie.Size = new System.Drawing.Size(1100, 338);
            this.groupBoxMovie.TabIndex = 66;
            this.groupBoxMovie.TabStop = false;
            this.groupBoxMovie.Text = "Movies";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.Controls.Add(this.button1ShowData);
            this.panel4.Controls.Add(this.TextBoxMovieID);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnDelMOvie);
            this.panel4.Location = new System.Drawing.Point(11, 41);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(975, 86);
            this.panel4.TabIndex = 59;
            // 
            // button1ShowData
            // 
            this.button1ShowData.BackColor = System.Drawing.Color.ForestGreen;
            this.button1ShowData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1ShowData.Location = new System.Drawing.Point(264, 20);
            this.button1ShowData.Margin = new System.Windows.Forms.Padding(5);
            this.button1ShowData.Name = "button1ShowData";
            this.button1ShowData.Size = new System.Drawing.Size(159, 49);
            this.button1ShowData.TabIndex = 60;
            this.button1ShowData.Text = "Show Data";
            this.button1ShowData.UseVisualStyleBackColor = false;
            this.button1ShowData.Click += new System.EventHandler(this.Button1ShowData_Click);
            // 
            // TextBoxMovieID
            // 
            this.TextBoxMovieID.Location = new System.Drawing.Point(119, 26);
            this.TextBoxMovieID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxMovieID.Name = "TextBoxMovieID";
            this.TextBoxMovieID.Size = new System.Drawing.Size(132, 32);
            this.TextBoxMovieID.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 24);
            this.label14.TabIndex = 56;
            this.label14.Text = "Movie Id:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(509, 23);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(213, 49);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelMOvie
            // 
            this.btnDelMOvie.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelMOvie.Location = new System.Drawing.Point(746, 23);
            this.btnDelMOvie.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelMOvie.Name = "btnDelMOvie";
            this.btnDelMOvie.Size = new System.Drawing.Size(213, 49);
            this.btnDelMOvie.TabIndex = 57;
            this.btnDelMOvie.Text = "Delete Movie";
            this.btnDelMOvie.UseVisualStyleBackColor = false;
            this.btnDelMOvie.Click += new System.EventHandler(this.BtnDelMOvie_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.Controls.Add(this.buttonReset);
            this.panel3.Controls.Add(this.textBoxStoryLine);
            this.panel3.Controls.Add(this.btnAddMOvie);
            this.panel3.Controls.Add(this.TextBoxStarRating);
            this.panel3.Controls.Add(this.TextBoxRent);
            this.panel3.Controls.Add(this.TextBoxGenre);
            this.panel3.Controls.Add(this.TextBoxMOvieTitle);
            this.panel3.Controls.Add(this.TextBoxYear);
            this.panel3.Location = new System.Drawing.Point(11, 150);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 168);
            this.panel3.TabIndex = 58;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Teal;
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(904, 93);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(145, 48);
            this.buttonReset.TabIndex = 65;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // textBoxStoryLine
            // 
            this.textBoxStoryLine.Location = new System.Drawing.Point(17, 76);
            this.textBoxStoryLine.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoryLine.Multiline = true;
            this.textBoxStoryLine.Name = "textBoxStoryLine";
            this.textBoxStoryLine.Size = new System.Drawing.Size(673, 70);
            this.textBoxStoryLine.TabIndex = 64;
            this.textBoxStoryLine.Text = "Story Line...";
            // 
            // btnAddMOvie
            // 
            this.btnAddMOvie.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddMOvie.Location = new System.Drawing.Point(704, 92);
            this.btnAddMOvie.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddMOvie.Name = "btnAddMOvie";
            this.btnAddMOvie.Size = new System.Drawing.Size(187, 49);
            this.btnAddMOvie.TabIndex = 63;
            this.btnAddMOvie.Text = "Add Movie";
            this.btnAddMOvie.UseVisualStyleBackColor = false;
            this.btnAddMOvie.Click += new System.EventHandler(this.BtnAddMOvie_Click);
            // 
            // TextBoxStarRating
            // 
            this.TextBoxStarRating.Location = new System.Drawing.Point(704, 23);
            this.TextBoxStarRating.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxStarRating.Name = "TextBoxStarRating";
            this.TextBoxStarRating.Size = new System.Drawing.Size(159, 32);
            this.TextBoxStarRating.TabIndex = 61;
            this.TextBoxStarRating.Text = "Star Rating...";
            // 
            // TextBoxRent
            // 
            this.TextBoxRent.Location = new System.Drawing.Point(889, 23);
            this.TextBoxRent.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxRent.Name = "TextBoxRent";
            this.TextBoxRent.ReadOnly = true;
            this.TextBoxRent.Size = new System.Drawing.Size(159, 32);
            this.TextBoxRent.TabIndex = 58;
            this.TextBoxRent.Text = "($)Rent...";
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.Location = new System.Drawing.Point(456, 23);
            this.TextBoxGenre.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(225, 32);
            this.TextBoxGenre.TabIndex = 59;
            this.TextBoxGenre.Text = "Genre...";
            // 
            // TextBoxMOvieTitle
            // 
            this.TextBoxMOvieTitle.Location = new System.Drawing.Point(17, 23);
            this.TextBoxMOvieTitle.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxMOvieTitle.Name = "TextBoxMOvieTitle";
            this.TextBoxMOvieTitle.Size = new System.Drawing.Size(225, 32);
            this.TextBoxMOvieTitle.TabIndex = 54;
            this.TextBoxMOvieTitle.Text = "Movie Title...";
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Location = new System.Drawing.Point(268, 23);
            this.TextBoxYear.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(159, 32);
            this.TextBoxYear.TabIndex = 56;
            this.TextBoxYear.Text = "Release Year..";
            this.TextBoxYear.TextChanged += new System.EventHandler(this.TextBoxYear_TextChanged);
            // 
            // Movie_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 727);
            this.Controls.Add(this.groupBoxMovie);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonMostPopular);
            this.Controls.Add(this.buttonAllRented);
            this.Controls.Add(this.gbRentMovie);
            this.Controls.Add(this.GroupBoxReturnMovie);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.TabControlSystem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Movie_Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie_Rental";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Movie_Rental_Load);
            this.TabControlSystem.ResumeLayout(false);
            this.Movies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGridView)).EndInit();
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.RentedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGridView)).EndInit();
            this.CustomerBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupBoxReturnMovie.ResumeLayout(false);
            this.GroupBoxReturnMovie.PerformLayout();
            this.gbRentMovie.ResumeLayout(false);
            this.gbRentMovie.PerformLayout();
            this.groupBoxMovie.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlSystem;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.TabPage Movies;
        private System.Windows.Forms.DataGridView MovieDataGridView;
        private System.Windows.Forms.TabPage RentedMovies;
        private System.Windows.Forms.DataGridView RentalDataGridView;
        private System.Windows.Forms.GroupBox CustomerBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.GroupBox GroupBoxReturnMovie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DropDownAllCust;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlRentedMovies;
        private System.Windows.Forms.GroupBox gbRentMovie;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox DropDownSelectCustomer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtIsuue;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button buttonAllRented;
        private System.Windows.Forms.Button buttonMostPopular;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBoxMovie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TextBoxMovieID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelMOvie;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxStoryLine;
        private System.Windows.Forms.Button btnAddMOvie;
        private System.Windows.Forms.TextBox TextBoxStarRating;
        private System.Windows.Forms.TextBox TextBoxRent;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.TextBox TextBoxMOvieTitle;
        private System.Windows.Forms.TextBox TextBoxYear;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox DropDownMovie;
        private System.Windows.Forms.Button buttonResetCust;
        private System.Windows.Forms.Button button1ShowData;
        private System.Windows.Forms.Button button1Show;
    }
}