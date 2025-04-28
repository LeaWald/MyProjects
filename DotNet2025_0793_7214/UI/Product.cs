using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace UI
{
    public partial class Product : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        public Product()
        {
            InitializeComponent();
            cbCategory.Items.Add(BO.Categories.יום_הולדת);
            cbCategory.Items.Add(BO.Categories.בנים);
            cbCategory.Items.Add(BO.Categories.בנות);
            cbCategory.Items.Add(BO.Categories.בית);
            cbCategory.Items.Add(BO.Categories.כלות);
            chooseCatgoEdit.Items.Add(BO.Categories.יום_הולדת);
            chooseCatgoEdit.Items.Add(BO.Categories.בנים);
            chooseCatgoEdit.Items.Add(BO.Categories.בנות);
            chooseCatgoEdit.Items.Add(BO.Categories.בית);
            chooseCatgoEdit.Items.Add(BO.Categories.כלות);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Product.Create(new BO.Product()
                {
                    Id = 0,
                    ProductName = textInserName.Text,
                    Price = double.Parse(nUDprice.Text),
                    Category = (BO.Categories)Enum.Parse(typeof(BO.Categories), cbCategory.Text),
                    QuantityInStock = int.Parse(nUDQuentity.Text),
                });
                MessageBox.Show("המוצר נוסף בהצלחה");
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
                _bl.Product.Delete(int.Parse(textCodeDelete.Text));
                MessageBox.Show("המוצר נמחק בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Product.Update(new BO.Product()
                {
                    Id = int.Parse(textupdateProd.Text),
                    ProductName = inserNameEdit.Text,
                    Price = double.Parse(priceEdit.Text),
                    Category = (BO.Categories)Enum.Parse(typeof(BO.Categories), chooseCatgoEdit.Text),
                    QuantityInStock = int.Parse(quentityEdit.Text),

                });
                MessageBox.Show("המוצר עודכן בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListProd_Click(object sender, EventArgs e)
        {
            List<BO.Product> list = _bl.Product.ReadAll();
            listProd.DataSource = null;
            listProd.Items.Clear();
            listProd.DataSource = list.SelectMany(p => p.ToString().Split("\n")).ToList();

        }

        private void btnsearchById_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product p = _bl.Product.Read(int.Parse(searchId.Text));
                lblfoundId.Text = p.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<BO.Product> list = _bl.Product.ReadAll(p => p.Price < 50);
            listSearch.Items.Clear();
            listSearch.DataSource = list.SelectMany(p => p.ToString().Split("\n")).ToList();
        }
    }
}
