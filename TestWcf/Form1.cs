using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWcf.SvcCars;

namespace TestWcf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            SvcCars.CarServiceClient client = new SvcCars.CarServiceClient();

            Car[] listCars = null;

            listCars = client.GetAllCars();

            dataGridView1.DataSource = listCars;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            SvcCars.CarServiceClient client = new SvcCars.CarServiceClient();

            Car[] listCars = null;

            listCars = client.GetCarById(textBox1.Text);

            dataGridView1.DataSource = listCars;
            
        }
    }
}
