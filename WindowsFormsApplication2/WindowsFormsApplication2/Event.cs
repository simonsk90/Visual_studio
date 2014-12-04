using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
            dateTimePickerEvent.Format = DateTimePickerFormat.Custom;
            dateTimePickerEvent.CustomFormat = " MMMM dd " + " kl: " + "HH:mm";

        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventAdd_Click(object sender, EventArgs e)
        {
            if (textEventLecture.Text != "" &&
                textEventAttendants.Text != "" && 
                comboBoxEventActivity.SelectedItem != null && 
                comboBoxEventLocation.SelectedItem != null)
            {
                //Add event to databse

                lblErrorMsg.Text = "Dit event er blevet oprettet";
            }

            else
            {
                lblErrorMsg.Text = "Udfyld alle felter for at fortsætte";
            }
        }
    }
}
