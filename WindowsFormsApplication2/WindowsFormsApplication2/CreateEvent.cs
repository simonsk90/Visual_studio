using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
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
            MakeLocationList();
            MakeActivityList();
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
                Location l = (Location)comboBoxEventLocation.SelectedItem;
                Activity a = (Activity)comboBoxEventActivity.SelectedItem;
                String s = textEventLecture.Text;
                Event eee = new Event(dateTimePickerEvent.Value, l, s, a);
                DateTime hallo = dateTimePickerEvent.Value;
                lblErrorMsg.Text = "Dit event er blevet oprettet";
                addEvent(eee);
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
                client.BaseAddress = new Uri("http://42345.9220.ovh/");
                var ee = new Event() { date = e.date, lecturer = e.lecturer, acti = e.acti, location = e.location };
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Event", ee);
                if (response.IsSuccessStatusCode)
                {
                    lblErrorMsg.Text = "Dit event er blevet oprettet";
                }
            }
        }

        private async Task MakeLocationList()
        {
            List<Location> locList = new List<Location>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://42345.9220.ovh/");
                HttpResponseMessage response = await client.GetAsync("api/Location");
                locList = await response.Content.ReadAsAsync<List<Location>>();
            }
            BindingSource bd = new BindingSource();
            bd.DataSource = locList;
            comboBoxEventLocation.DataSource = bd.DataSource;
            comboBoxEventLocation.DisplayMember = "address";
        }

        private async Task MakeActivityList()
        {
            List<Activity> aList = new List<Activity>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://42345.9220.ovh/");
                HttpResponseMessage response = await client.GetAsync("api/Activity");
                aList = await response.Content.ReadAsAsync<List<Activity>>();
            }
            BindingSource bda = new BindingSource();
            bda.DataSource = aList;
            comboBoxEventActivity.DataSource = bda.DataSource;
            comboBoxEventActivity.DisplayMember = "title";
        }

    }
}
