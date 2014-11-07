using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystemProgramShell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hotelDBDataSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.hotelDBDataSet.Customers);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkAvailabilityOfRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomsStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hotelDBDataSet //== houseKeepingTableAdapter;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           
          

        }

        private void hotelDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hotelDBDataSetBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
