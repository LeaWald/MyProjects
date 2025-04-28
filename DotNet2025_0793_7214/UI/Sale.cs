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
    public partial class Sale : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        public Sale()
        {
            InitializeComponent();
        }

        private void tabControlProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Sale.Create(new BO.Sale()
                {
                    IdSale = 0,
                    CodeProduct = int.Parse(textInserCode.Text),
                    Quantity = int.Parse(nUDQuentityToSale.Text),
                    Price = double.Parse(nUDprice.Text),
                    Club = checkBoxClub.Checked,
                    StartDate = dateTimePicker1.Value,
                    FinishDate = dateTimePicker2.Value
                });
                MessageBox.Show("המבצע נוסף בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Sale.Update(new BO.Sale()
                {
                    IdSale = int.Parse(textCodeUd.Text),
                    CodeProduct = int.Parse(textCode.Text),
                    Quantity = int.Parse(nUDQuentity.Text),
                    Price = double.Parse(price.Text),
                    Club = checkBox1club.Checked,
                    StartDate = dateTimePickerS.Value,
                    FinishDate = dateTimePickerF.Value
                });
                MessageBox.Show("המבצע עודכן בהצלחה");
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
                _bl.Sale.Delete(int.Parse(textCodeDelete.Text));
                MessageBox.Show("המבצע נמחק בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListProd_Click(object sender, EventArgs e)
        {
            List<BO.Sale> list = _bl.Sale.ReadAll();
            listSales.DataSource = null;
            listSales.Items.Clear();
            listSales.DataSource = list.SelectMany(s => s.ToString().Split("\n")).ToList();
        }

        private void btnsearchById_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Sale s = _bl.Sale.Read(int.Parse(searchId.Text));
                lblfoundId.Text = s.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<BO.Sale> list = _bl.Sale.ReadAll(s => s.Quantity > 3);
            listSales.DataSource = null;
            listSearch.Items.Clear();
            listSearch.DataSource = list.SelectMany(s => s.ToString().Split("\n")).ToList();
        }

    }
}
