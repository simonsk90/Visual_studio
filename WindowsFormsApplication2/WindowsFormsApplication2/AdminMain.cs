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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void buttonActivityCreate_Click(object sender, EventArgs e)
        {
            CreateActivity newAct = new CreateActivity();
            newAct.Show();
        }

        private void buttonAdminCreateLocation_Click(object sender, EventArgs e)
        {
            CreateLocation newLoc = new CreateLocation();
            newLoc.Show();
        }

        private void buttonEventCreateEvent_Click(object sender, EventArgs e)
        {
            CreateEvent newEvent = new CreateEvent();
            newEvent.Show();
        }

        private void buttonViewEvents_Click(object sender, EventArgs e)
        {
            ViewEvents newViewEvents = new ViewEvents();
            newViewEvents.Show();
        }

    }
}
