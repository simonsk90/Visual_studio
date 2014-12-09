using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CreateEvent : Form
    {

        public CreateEvent()
        {
            InitializeComponent();
            dateTimePickerEvent.Format = DateTimePickerFormat.Custom;
            dateTimePickerEvent.CustomFormat = " MMMM dd " + " kl: " + "HH:mm";
            getAllLocation();
            comboBoxEventLocation.DataSource = getAllLocation();
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
                //Event e = new Event(dateTimePickerEvent, ,textEventLecture.ToString(),);
                //addEvent(e);
                lblErrorMsg.Text = "Dit event er blevet oprettet";
            }

            else
            {
                lblErrorMsg.Text = "Udfyld alle felter for at fortsætte";
            }
        }

        private async Task addEvent(Event e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51938/");
                var aa = new Event() { ID = e.ID, date = e.date, location = e.location, lecturer = e.lecturer, acti = e.acti };
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Activity", aa);
            }
        }

        private async Task<List<Location>> getAllLocation()
        {
            List<Location> locList = new List<Location>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51938/");
                HttpResponseMessage response = await client.GetAsync("api/Location");
                if (response.IsSuccessStatusCode)
                {
                    locList = await response.Content.ReadAsAsync<List<Location>>();
                }   
            }
            return locList;

        }
    }
}
