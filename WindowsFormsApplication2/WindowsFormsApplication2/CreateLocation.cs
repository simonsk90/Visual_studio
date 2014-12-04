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
    public partial class CreateLocation : Form
    {
        public CreateLocation()
        {
            InitializeComponent();
        }

        private void buttonLocationAdd_Click(object sender, EventArgs e)
        {
            if (
                textLocationName.Text != "" &&
                textLocationAddress.Text != "" &&
                textLocationZipCode.Text != "" &&
                textLocationCity.Text != ""
                )
            {
                //Add to database
                lblErrorMsg.Text = "Lokation oprettet";
            }

            else
            {
                lblErrorMsg.Text = "Udfyld alle felter for at fortsætte";
            }
        }
    }
}
