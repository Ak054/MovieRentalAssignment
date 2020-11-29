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
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        // start to main screen
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Movie_Rental movr = new Movie_Rental();
            movr.Show();
            this.Hide();
        }
    }
}
