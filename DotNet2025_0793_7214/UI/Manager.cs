using DalTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagerLbl_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void productCare_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ShowDialog();
        }

        private void customerCare_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void saleCare_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.ShowDialog();
        }

    }
}
