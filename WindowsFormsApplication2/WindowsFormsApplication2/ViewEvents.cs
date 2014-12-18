using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ViewEvents : Form
    {
        public ViewEvents()
        {
            InitializeComponent();
            listView1.View = View.Details;
            fillList();
        }

        private async void fillList()
        {
            //ListViewItem item1 = new ListViewItem("Something");
           // item1.SubItems.Add("SubItem1a");
           // item1.SubItems.Add("SubItem1b");
           // listView1.Items.Add(item1);
            List<Event> eList = await getEvents();

            foreach (Event e in eList)
            {
                ListViewItem eItem = new ListViewItem(e.acti.title);
                eItem.SubItems.Add(e.location.name);
                eItem.SubItems.Add(e.date.ToString());
                listView1.Items.Add(eItem);
            }
        }

        private async Task<List<Event>> getEvents()
        {
            List<Event> eList = new List<Event>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://42345.9220.ovh/");
                HttpResponseMessage response = await client.GetAsync("api/Event");
                String json = await response.Content.ReadAsAsync<String>();
                JavaScriptSerializer js = new JavaScriptSerializer();
                eList = js.Deserialize<List<Event>>(json);
            }
            return eList;
            //DataTable dtable = new DataTable();
            //dtable.Columns.Add("Activity", typeof(object));
            //dtable.Columns.Add("Location", typeof(object));
            //dtable.Columns.Add("Date", typeof(object));
            //for (int i = 0; i < dtable.Rows.Count; i++)
            //{
            //    DataRow dr = dtable.Rows[i];
            //    ListViewItem lvItem = new ListViewItem(dr["Activity"].ToString());
            //    lvItem.SubItems.Add(dr["location"].ToString());
            //    lvItem.SubItems.Add(dr["date"].ToString());
            //    listView1.Items.Add(lvItem);
                
            //}

            



        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
