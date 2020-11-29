using MovieRentalAssignment.DataAccessLayer;
using MovieRentalAssignment.PresentationLayer;
using MovieRentalAssignment.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalAssignment
{
    public partial class Movie_Rental : Form
    {
        public Movie_Rental()
        {
            InitializeComponent();
            
        }

        //bind movies grid
        private void MoviesGridViewDataBind()
        {
            DataTable ds = new Movies().ShowAllMovies();
            MovieDataGridView.DataSource = ds;
            MovieDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Movie_Rental_Load(object sender, EventArgs e)
        {
           //bind dropdown movies
            BindDropDownMovie();

            //bind customer dropdown
            BindDdlCustomer();

            //Grid movies data bind
            MoviesGridViewDataBind();

            //bind customer grid
            BindGridCustomersInfo();

            groupBoxMovie.Visible = true;
            

        }

        //RentedMovie Grid view Bind Data here
        private void RentedMovieGridData()
        {
            DataTable ds = new RentedMOvies().ShowAllRentedMovies();
            RentalDataGridView.DataSource = ds;
            RentalDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //control the tabs from here
        private void TabControlSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (TabControlSystem.SelectedTab == TabControlSystem.TabPages["Movies"])
                {
                    MoviesGridViewDataBind();
                   
                    groupBoxMovie.Visible = true;
                    CustomerBox.Visible = false;
                   



                }
                else if (TabControlSystem.SelectedTab == TabControlSystem.TabPages["Customers"])
                {
                    groupBoxMovie.Visible = false;
                    CustomerBox.Visible = true;
                  
                    
                    BindGridCustomersInfo();

                }
                else if (TabControlSystem.SelectedTab == TabControlSystem.TabPages["RentedMovies"])
                {
                    RentedMovieGridData(); //show all rented movies
                    groupBoxMovie.Visible = false;
                    CustomerBox.Visible = false;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataBaseConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        //Show All Rented Movies
        private void ButtonAllRented_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlSystem.SelectedTab = TabControlSystem.TabPages["RentedMovies"];
                RentedMovieGridData();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Show Most Popular movies
        private void ButtonMostPopular_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlSystem.SelectedTab = TabControlSystem.TabPages["RentedMovies"];
                DataTable dt = new RentedMOvies().MostPopularMovies();
                RentalDataGridView.DataSource = dt;
                RentalDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Show Customers who borrow most movies
        private void Button3_Click(object sender, EventArgs e)
        {

            try
            {
                TabControlSystem.SelectedTab = TabControlSystem.TabPages["RentedMovies"];
                DataTable dt = new RentedMOvies().CustBorrowMostMovies();
                RentalDataGridView.DataSource = dt;
                RentalDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //insert movies
        private void BtnAddMOvie_Click(object sender, EventArgs e)
        {
            string Title, RentCost, Year, Rating, Genre,StoryLine;
            Title = TextBoxMOvieTitle.Text;
            RentCost = TextBoxRent.Text;
            Rating = TextBoxStarRating.Text;
            Year = TextBoxYear.Text;
            Genre = TextBoxGenre.Text;
            StoryLine = textBoxStoryLine.Text;

            if (Title == "")
            {
                MessageBox.Show("Movie title is required!");
                TextBoxMOvieTitle.Focus();
            }
            else if (Year == "")
            {
                MessageBox.Show("Movie released year is required!");
                TextBoxYear.Focus();
            }
            else if (Genre == "")
            {
                MessageBox.Show("Movie genre is required!");
                TextBoxGenre.Focus();
            }
            else if (Rating == "")
            {
                MessageBox.Show("Movie rating is required!");
                TextBoxStarRating.Focus();
            }
            else if (StoryLine == "")
            {
                MessageBox.Show("Story Line is required!");
                textBoxStoryLine.Focus();
            }
            else
            {
                MoviesData data = new MoviesData
                {
                    Title = Title,
                    Year = Year,
                    Rating = Rating,
                    Genre = Genre,
                    RentCost = int.Parse(RentCost),
                    StoryLine = StoryLine
                };
                if (new Movies().InsertMovie(data))
                {

                    MoviesGridViewDataBind(); // method calling to Bind Grid Movies
                    BindDropDownMovie(); // method calling to Bind dropdown Movies
                    MessageBox.Show("Movie Inseted Successfully!");

                    TextBoxMOvieTitle.Text = "Movie Title...";
                    TextBoxYear.Text = "Release Year...";
                    TextBoxStarRating.Text = "Star Rating...";
                    TextBoxGenre.Text = "Genre...";
                    TextBoxRent.Text = "($)Rent... ";
                    textBoxStoryLine.Text = "Story Line...";

                }
            }
        }

        //Complute Movie Rent on the basis of movie release year
        private void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string movieReleaseYear = TextBoxYear.Text;
                string currentYear = DateTime.Now.Year.ToString();
                if (movieReleaseYear == "")
                {
                    TextBoxRent.Text = "";
                }

                else
                {
                    int MovieAge = int.Parse(currentYear) - int.Parse(movieReleaseYear);
                    //if movie is older than 5 years (Release Date) then rent cost is $2 otherwise rent cost is $5
                    if (MovieAge > 5)
                    {
                        TextBoxRent.Text = "2";
                    }
                    else
                    {
                        TextBoxRent.Text = "5";
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //Delete movie
        private void BtnDelMOvie_Click(object sender, EventArgs e)
        {
            try
            {
                string movieid = TextBoxMovieID.Text;

                if (new Movies().DeleteMovie(movieid))
                {
                    BindDropDownMovie(); // method calling to Bind comboBox movie
                    MoviesGridViewDataBind(); // method calling to Bind GridView movie
                    MessageBox.Show("Movie Deleted Successfully!");
                    btnAddMOvie.Enabled = true;
                    TextBoxMovieID.Text = "";
                    TextBoxMOvieTitle.Text = "Movie Title...";
                    TextBoxYear.Text = "Release Year...";
                    TextBoxStarRating.Text = "Star Rating...";
                    TextBoxGenre.Text = "Genre...";
                    TextBoxRent.Text = "($)Rent... ";
                    textBoxStoryLine.Text = "Story Line...";
                }
                else
                {
                    MessageBox.Show("Failed! Not able to delete this movie");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // Bind DropDownSelectMovie
        private void BindDropDownMovie()
        {
            DataTable ds = new Movies().ShowMovies();

            DataRow row = ds.NewRow();
            row[0] = 0;
            row[1] = "Select...";
            ds.Rows.InsertAt(row, 0); // add item at INDEX = 0;

            // Bind Movie in Dropdown in Movie Rent
            DropDownMovie.DisplayMember = "Title";
            DropDownMovie.ValueMember = "MovieID";
            DropDownMovie.DataSource = ds;
        }

        //Update movie
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MovieId = TextBoxMovieID.Text;

                string Title, RentCost, Year, Rating, Genre,StoryLine;
                Title = TextBoxMOvieTitle.Text;
                RentCost = TextBoxRent.Text;
                Rating = TextBoxStarRating.Text;
                Year = TextBoxYear.Text;
                Genre = TextBoxGenre.Text;
                StoryLine = textBoxStoryLine.Text;

                if (Title=="")
                {
                    MessageBox.Show("Movie title is required!");
                    TextBoxMOvieTitle.Focus();
                }
                else if (Year=="")
                {
                    MessageBox.Show("Movie released year is required!");
                    TextBoxYear.Focus();
                }
                
                else if (Genre=="")
                {
                    MessageBox.Show("Movie genre is required!");
                    TextBoxGenre.Focus();
                }
                else if (RentCost=="")
                {
                    MessageBox.Show("Movie rent cost is required!");
                }
                else if (StoryLine == "")
                {
                    MessageBox.Show("Story Line is required!");
                    textBoxStoryLine.Focus();
                }
                else if (Rating=="")
                {
                    MessageBox.Show("Movie rating is required!");
                    TextBoxStarRating.Focus();
                }
               
                else
                {
                    MoviesData data = new MoviesData
                    {
                        Title = Title,
                        Year = Year,
                        Rating = Rating,
                        Genre = Genre,
                        RentCost = int.Parse(RentCost),
                        MovieId = int.Parse(MovieId),
                        StoryLine = StoryLine
                    };
                    if (new Movies().UpdateMovie(data))
                    {

                        MoviesGridViewDataBind();
                        BindDropDownMovie();
                      
                        btnAddMOvie.Enabled = true; // enable Add movie button
                        MessageBox.Show("Movie Updated Successfully!");
                        TextBoxMovieID.Text = "";
                        TextBoxMOvieTitle.Text = "Movie Title...";
                        TextBoxYear.Text = "Release Year...";
                        TextBoxStarRating.Text = "Star Rating...";
                        TextBoxGenre.Text = "Genre...";
                        TextBoxRent.Text = "($)Rent... ";
                        textBoxStoryLine.Text = "Story Line...";

                    }
                    else
                    {
                        MessageBox.Show("Unable to update this movie!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataBaseConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        //Reset movie textboxes
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            btnAddMOvie.Enabled = true;
            TextBoxMovieID.Text = "";
            TextBoxMOvieTitle.Text = "Movie Title...";
            TextBoxYear.Text = "Release Year...";
            TextBoxStarRating.Text = "Star Rating...";
            TextBoxGenre.Text = "Genre...";
            TextBoxRent.Text = "($)Rent... ";
            textBoxStoryLine.Text = "Story Line...";
        }


        //dropdown Customer bind data 
        private void BindDdlCustomer()
        {
            DataTable ds = new Customer().ShowAllCustomers();

            DataRow row = ds.NewRow();
            row[0] = 0;
            row[1] = "Select...";
            ds.Rows.InsertAt(row, 0); // add item at INDEX = 0;

            DropDownSelectCustomer.DisplayMember = "name";
            DropDownSelectCustomer.ValueMember = "CustId";
            DropDownSelectCustomer.DataSource = ds; // Bind customer in Movie Rent Panel

            // Bind customer in Movie Return section **********************************
            DropDownAllCust.DisplayMember = "name";
            DropDownAllCust.ValueMember = "CustId";
            DropDownAllCust.DataSource = ds;

        }

        //Issue movie to selected customer
        private void BtnIssueMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string CustId, MovieId, IssueDate, ReturnDate;
                int totalDays = 0;
                int temp = 0;
                int TotalRent = 0;
                CustId = DropDownSelectCustomer.SelectedValue.ToString();
                MovieId = DropDownMovie.SelectedValue.ToString();
                IssueDate = dtIsuue.Value.ToShortDateString();
                ReturnDate = dtReturn.Value.ToShortDateString();

                if (CustId=="" || CustId == "0" || CustId==null)
                {
                    MessageBox.Show("Please select customer");
                }
                else if (MovieId.Equals("") || MovieId == "0" || MovieId==null)
                {
                    MessageBox.Show("Please select movie");
                }

                else if (DateTime.Parse(IssueDate) > DateTime.Parse(ReturnDate))
                {
                    MessageBox.Show("Issue date can not be greater than retun date", "Alert");
                }
                else if (IssueDate == ReturnDate)
                {
                    totalDays = 1;  
                    temp = new Movies().CalculateMovieCost(int.Parse(MovieId)); // Getting rent amount for that movie

                    TotalRent = totalDays * temp; // Calculate the Total Rent of issue movie
                }
                else
                {
                   
                    totalDays = new CalculateDays().TotalDays(IssueDate, ReturnDate);
                   
                    temp = new Movies().CalculateMovieCost(int.Parse(MovieId)); // Getting rent amount for that movie

                    TotalRent = totalDays * temp; // Calculate the Total Rent of issue movie
                }

                RentedMoviesData rmdata = new RentedMoviesData
                {
                    MovieId = int.Parse(MovieId),
                    CustId = int.Parse(CustId),
                    RentDate = IssueDate,
                    ReturnDate = ReturnDate,
                    TotalRentAmount = TotalRent
                };

                if (new RentedMOvies().InsertRentedMovie(rmdata))
                {
                    TabControlSystem.SelectedTab = TabControlSystem.TabPages["RentedMovies"];
                    RentedMovieGridData();
                    MessageBox.Show("Movie rented successfully!");

                }
                else
                {
                    MessageBox.Show("Failed to rent this movie!");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //show rented movies by customer
        private void DropDownAllCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(DropDownAllCust.SelectedValue.ToString());
                if (customerId > 0)
                {
                    ddlRentedMovies.Enabled = true;
                    DataTable dsRented = new RentedMOvies().ShowRentedMoviesDDL(customerId);

                    if (dsRented.Rows.Count > 0)
                    {
                        DataRow row = dsRented.NewRow();
                        row[0] = 0;
                        row[1] = "Select...";
                        dsRented.Rows.InsertAt(row, 0); // add item at INDEX = 0;

                        ddlRentedMovies.DisplayMember = "Title";
                        ddlRentedMovies.ValueMember = "MovieId";
                        ddlRentedMovies.DataSource = dsRented;
                    }
                    else
                    {
                        ddlRentedMovies.Enabled = false;
                    }
                }
                else
                {
                    ddlRentedMovies.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Reset Customer textboxes
        private void ButtonResetCust_Click(object sender, EventArgs e)
        {
            AddCustomer.Enabled = true;
            TextBoxFirstName.Text = "First Name...";
            textBoxLastName.Text = "Last Name...";
            textBoxAddress.Text = "Address...";
            textBoxPhone.Text = "Phone...";
            tbxCustomerID.Text = "";
        }

        //Customer GridView DataBind
        private void BindGridCustomersInfo()
        {
            DataTable ds = new Customer().ShowCustomers();
            CustomersDataGridView.DataSource = ds;
            CustomersDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //Delete Customer
        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string custId = tbxCustomerID.Text;

                    if (new Customer().DeleteCustomerInform(custId))
                    {
                        BindDdlCustomer(); // method calling to Bind comboBox Customer
                        BindGridCustomersInfo(); // method calling to Bind GridView Customer

                        AddCustomer.Enabled = true;
                        MessageBox.Show("Customer Deleted Successfully!");
                        TextBoxFirstName.Text = "First Name...";
                        textBoxLastName.Text = "Last Name...";
                        textBoxAddress.Text = "Address...";
                        textBoxPhone.Text = "Phone...";
                        tbxCustomerID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete this customer");
                    }
                
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("Can not delete this customer as the customer rented a movie!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                    DataBaseConnection.CloseConnection(); // close connection with database when error occured
                }
            }
        }

        //Insert Customer
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                
                    string Firstname,Lastname, address, phone;
                    Firstname = TextBoxFirstName.Text;
                    Lastname = textBoxLastName.Text;
                    address = textBoxAddress.Text;
                    phone = textBoxPhone.Text;

                    if (Firstname=="")
                    {
                        MessageBox.Show("First name is required!");
                        TextBoxFirstName.Focus();
                    }
                    else if (Lastname == "")
                    {
                        MessageBox.Show("Last name is required!");
                        textBoxLastName.Focus();
                    }
                    else if (address=="")
                    {
                        MessageBox.Show("Address is required!");
                        textBoxAddress.Focus();
                    }
                    else if (phone=="")
                    {
                        MessageBox.Show("Phone number is required!");
                        textBoxPhone.Focus();
                    }
                    
                    else
                    {
                    CustomerData data = new CustomerData
                    {
                        FirstName = Firstname,
                        LastName = Lastname,
                        Address = address,
                        Phone = phone
                    };
                    if (new Customer().InsertCustomerInformation(data))
                        {

                        BindDdlCustomer(); // method calling to Bind comboBox Customer
                        BindGridCustomersInfo(); // method calling to Bind GridView Customer

                        MessageBox.Show("Customer Inserted Successfully!");

                        TextBoxFirstName.Text = "First Name...";
                        textBoxLastName.Text = "Last Name...";
                        textBoxAddress.Text = "Address...";
                        textBoxPhone.Text = "Phone...";
                    }
                        else
                        {
                            MessageBox.Show("Unable to add this customer!");
                        }
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataBaseConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        //Update Customer Information
        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string custId = tbxCustomerID.Text;
                string FirstName,LastName, address, phone;
                LastName = textBoxLastName.Text;
                FirstName = TextBoxFirstName.Text;
                address = textBoxAddress.Text;
                phone = textBoxPhone.Text;

                if (FirstName == "")
                {
                    MessageBox.Show("First name is required!");
                    TextBoxFirstName.Focus();
                }
                else if (LastName == "")
                {
                    MessageBox.Show("Last name is required!");
                    textBoxLastName.Focus();
                }
                else if (address == "")
                {
                    MessageBox.Show("Address is required!");
                    textBoxAddress.Focus();
                }
                else if (phone == "")
                {
                    MessageBox.Show("Phone number is required!");
                    textBoxPhone.Focus();
                }
                else
                {
                    CustomerData data = new CustomerData
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        Address = address,
                        Phone = phone,
                        CustId = int.Parse(custId)
                    };
                    if (new Customer().UpdateCustomerInformation(data))
                    {
                        AddCustomer.Enabled = true;
                        BindDdlCustomer(); // method calling to Bind comboBox Customer
                        BindGridCustomersInfo(); // method calling to Bind GridView Customer
                        MessageBox.Show("Customer Updated Successfully!");
                        TextBoxFirstName.Text = "First Name...";
                        textBoxLastName.Text = "Last Name...";
                        textBoxAddress.Text = "Address...";
                        textBoxPhone.Text = "Phone...";
                        tbxCustomerID.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Unable to update this customer!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataBaseConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        //Show movie info in textboxes
        private void Button1ShowData_Click(object sender, EventArgs e)
        {
            try
            {
                string movieid = TextBoxMovieID.Text;
                if (movieid != "")
                {
                    MoviesData data = new Movies().ShowMovieInfoById(int.Parse(movieid));
                    if (data != null)
                    {
                        btnAddMOvie.Enabled = false;
                        TextBoxMOvieTitle.Text = data.Title;
                        TextBoxYear.Text = data.Year;
                        TextBoxStarRating.Text = data.Rating;
                        TextBoxGenre.Text = data.Genre;
                        TextBoxRent.Text = data.RentCost.ToString();
                        textBoxStoryLine.Text = data.StoryLine;
                    }
                    else
                    {
                        MessageBox.Show("No Record Found!");
                        TextBoxMovieID.Focus();
                        TextBoxMOvieTitle.Text = "Movie Title...";
                        TextBoxYear.Text = "Release Year...";
                        TextBoxStarRating.Text = "Star Rating...";
                        TextBoxGenre.Text = "Genre...";
                        TextBoxRent.Text = "($)Rent... ";
                        textBoxStoryLine.Text = "Story Line...";
                        
                    }
                }
                else
                {
                    MessageBox.Show("MovieId is required!");
                    TextBoxMovieID.Focus();

                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //show customer info in textboxes
        private void Button1Show_Click(object sender, EventArgs e)
        {
            try
            {
                string customerID = tbxCustomerID.Text;

                if (customerID != "")
                {
                    CustomerData data = new Customer().ShowCustomerInfoById(int.Parse(customerID));
                    if (data != null)
                    {
                        AddCustomer.Enabled = false;
                        TextBoxFirstName.Text = data.FirstName;
                        textBoxLastName.Text = data.LastName;
                        textBoxAddress.Text = data.Address;
                        textBoxPhone.Text = data.Phone;
                    }
                    else
                    {
                        MessageBox.Show("No Record Found!");
                        tbxCustomerID.Focus();
                        TextBoxFirstName.Text = "First Name...";
                        textBoxLastName.Text = "Last Name...";
                        textBoxAddress.Text = "Address...";
                        textBoxPhone.Text = "Phone...";
                    }
                }
                else
                {
                    MessageBox.Show("CustomerId is required!");
                    tbxCustomerID.Focus();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Return Movie
        private void BtnReturnMovie_Click(object sender, EventArgs e)
        {
            try
            {
                int MoviID = int.Parse(ddlRentedMovies.SelectedValue.ToString());
                int CustId = int.Parse(DropDownAllCust.SelectedValue.ToString());
                if (new RentedMOvies().ReturnThisMovie(MoviID, CustId))
                {

                    RentedMovieGridData(); //method calling to Bind Grid for all rental movies

                    MessageBox.Show("Movie Returned Successfully!");
                    DropDownAllCust.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Unable to return this movie!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
