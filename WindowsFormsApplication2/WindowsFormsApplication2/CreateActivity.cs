using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CreateActivity : Form
    {
        public CreateActivity()
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM dd " +  " kl: " + "HH:mm";
        }

        private void SaveActivity(object sender, EventArgs e)
        {

            string title = textTitle.Text;
            string tags = textTag.Text;
            int spots = 0;

            if (checkIfNumber(textSpots.Text))
            { 
                spots = Convert.ToInt32(textSpots.Text);
            }
            string lector = textLector.Text;
            string address = textAddress.Text;
            string city = textCity.Text;
            string description = richTextBoxDescription.Text;
            DateTime date = dateTimePicker.Value;
        }

        private bool checkIfNumber(string txt) //Check to see if string only contains digits
        {
            bool pass = true;
            foreach (var ch in txt)
            {
                if (!char.IsDigit(ch))
                {
                    pass = false;
                }
            }
            return pass;
        }

    
}
