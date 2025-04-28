using BlApi;
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
    public partial class Customer : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        public Customer()
        {
            InitializeComponent();
        }

        private void tabControlProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Customer.Create(new BO.Customer()
                {
                    Id = int.Parse(textIdCust.Text),
                    Address = textAdrress.Text,
                    CustomerName = textName.Text,
                    Phone = textPhone.Text,
                });
                MessageBox.Show("הלקוח נוצר בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Customer.Delete(int.Parse(textCodeDelete.Text));
                MessageBox.Show("הלקוח נמחק בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveUD_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Customer.Update(new BO.Customer()
                {
                    Id = int.Parse(textIdUpdate.Text),
                    Address = textAddressUD.Text,
                    CustomerName = textNameUD.Text,
                    Phone = textPhoneUD.Text,
                });
                MessageBox.Show("הלקוח עודכן בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListCust_Click(object sender, EventArgs e)
        {

            List<BO.Customer> list = _bl.Customer.ReadAll();
            listCust.DataSource = null;
            listCust.Items.Clear();
            listCust.DataSource = list.SelectMany(c => c.ToString().Split("\n")).ToList();
        }

        private void btnsearchById_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer c = _bl.Customer.Read(int.Parse(searchId.Text));
                lblfoundId.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<BO.Customer> list = _bl.Customer.ReadAll(c => c.Phone.Length==10);
            listSearch.Items.Clear();
            listSearch.DataSource = list.SelectMany(c => c.ToString().Split("\n")).ToList();
        }
    }
}
