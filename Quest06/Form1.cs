using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

namespace Quest06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("Fleet");
            ds.ReadXml(@"XMLFleet.xml");
            dataGridView1.DataSource = ds.Tables["Ship"];
            dataGridView1.Columns["Name"].DisplayIndex = 0;
            dataGridView1.Columns["Type"].DisplayIndex = 1;
            dataGridView1.Columns["YearBuilt"].DisplayIndex = 2;
            dataGridView1.Columns["Speed"].DisplayIndex = 3;
            dataGridView1.Columns["CrewCount"].DisplayIndex = 4;
        }

        private void tree1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("PortList");
            ds.ReadXml(@"XMLFile2.xml");
            dataGridView1.DataSource = ds.Tables["Port"];
            dataGridView1.Columns["Name"].DisplayIndex = 0;
            dataGridView1.Columns["Type"].DisplayIndex = 1;
            dataGridView1.Columns["Country"].DisplayIndex = 2;
            dataGridView1.Columns["DockCount"].DisplayIndex = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("Passengers");
            ds.ReadXml(@"XMLFile1.xml");
            dataGridView1.DataSource = ds.Tables["Passenger"];
            dataGridView1.Columns["FullName"].DisplayIndex = 0;
            dataGridView1.Columns["Type"].DisplayIndex = 1;
            dataGridView1.Columns["Birthdate"].DisplayIndex = 2;
            dataGridView1.Columns["TicketNumber"].DisplayIndex = 3;
            dataGridView1.Columns["DepartureDate"].DisplayIndex = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Ship> ships = JsonConvert.DeserializeObject<List<Ship>>(File.ReadAllText("jsconfig1.json"));
            dataGridView1.DataSource = ships;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Port> ports = JsonConvert.DeserializeObject<List<Port>>(File.ReadAllText("jsconfig2.json"));
            dataGridView1.DataSource = ports;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Passenger> passengers = JsonConvert.DeserializeObject<List<Passenger>>(File.ReadAllText("jsconfig3.json"));
            dataGridView1.DataSource = passengers;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
