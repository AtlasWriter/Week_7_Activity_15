using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7_Activity_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Create data type to store index of combobox doctor selection
        int getRowNumber;
        int getTime;


        public void submitForInfo_Click(object sender, EventArgs e)
        {

            //Get select index from combo box user selection
            getRowNumber = comboBox1.SelectedIndex;
            getTime = comboBox2.SelectedIndex;

          
            // create an instance of the imformation page
            InformationPage detailsPage = new InformationPage();

            //Create a random number to generate a random room for office visit.
            Random random = new Random();  
           

            // Verifiy checked rado button status and list the multiple requests
            if (centervilleFamilyPractice.Checked)

            {
                detailsPage.officeName.Text = "Centerville Family Practice";

                detailsPage.doctorsName.Text = comboBox1.SelectedItem.ToString();

                detailsPage.floorLevel.Text = "1st";

                detailsPage.appointmentTime.Text = comboBox2.SelectedItem.ToString();

                detailsPage.roomNumber.Text = random.Next(1, 22).ToString();
            }
            else if (rockyCreekFamilyDentistry.Checked)
            {
                detailsPage.officeName.Text = "Rocky Creek Family Dentistry";

                detailsPage.doctorsName.Text = comboBox1.SelectedItem.ToString();

                detailsPage.floorLevel.Text = "2nd";

                detailsPage.appointmentTime.Text = comboBox2.SelectedItem.ToString();

                detailsPage.roomNumber.Text = random.Next(1, 22).ToString();
            }
            else if (clemsonEye.Checked) 
            {
                detailsPage.officeName.Text = "Clemson Eye ";

                detailsPage.doctorsName.Text = comboBox1.SelectedItem.ToString();

                detailsPage.floorLevel.Text = "3rd";

                detailsPage.appointmentTime.Text = comboBox2.SelectedItem.ToString();

                detailsPage.roomNumber.Text = random.Next(1, 22).ToString();
            }

            detailsPage.Show();

            
        }

        // Individual checkChange event that populates individual doctors working at different medical locations.
        private void centervilleFamilyPractice_CheckedChanged(object sender, EventArgs e)
        {
            getRowNumber = comboBox1.SelectedIndex;

            comboBox1.Items.Clear();    
            comboBox1.Items.Add("David Turner");
            comboBox1.Items.Add("James Ridings");
            comboBox1.Items.Add("Sara Fallow");
            
        }

        private void rockyCreekFamilyDentistry_CheckedChanged(object sender, EventArgs e)
        {
            getRowNumber = comboBox1.SelectedIndex;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Lisa Porter");
            comboBox1.Items.Add("Susan Barnes");
            comboBox1.Items.Add("Adam Eubanks");
        }

        private void clemsonEye_CheckedChanged(object sender, EventArgs e)
        {
            getRowNumber = comboBox1.SelectedIndex;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Melina Spires");
            comboBox1.Items.Add("Tony Franklin");
            comboBox1.Items.Add("Blake McFadden");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

