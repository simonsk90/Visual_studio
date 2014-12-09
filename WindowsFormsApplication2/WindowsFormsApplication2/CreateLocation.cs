using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
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
                //Create object

                string name = textLocationName.Text;
                string address = textLocationAddress.Text;
                int zipCode = Int32.Parse(textLocationZipCode.Text);
                string city = textLocationCity.Text;

                Location l = new Location(name, address, zipCode, city);
                
                //Add to database
                callLocationController(l);
                lblErrorMsg.Text = "Lokation oprettet";                
            }

            else
            {
                lblErrorMsg.Text = "Udfyld alle felter for at fortsætte";
            }
        }

        private async Task callLocationController(Location l)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51938/");
                var a = new Location() { name = l.name, address = l.address, zipCode = l.zipCode, city = l.city };
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Location", a);
            }
        }

    }
}
