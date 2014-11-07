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
    public partial class ChekInForm : Form
    {
        public ChekInForm()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.hotelDBDataSet.Payments);
            // TODO: This line of code loads data into the 'hotelDBDataSet.HouseKeeping' table. You can move, or remove it, as needed.
            this.houseKeepingTableAdapter.Fill(this.hotelDBDataSet.HouseKeeping);
            // TODO: This line of code loads data into the 'hotelDBDataSet.GuestCard' table. You can move, or remove it, as needed.
            this.guestCardTableAdapter.Fill(this.hotelDBDataSet.GuestCard);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.hotelDBDataSet.Customers);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
