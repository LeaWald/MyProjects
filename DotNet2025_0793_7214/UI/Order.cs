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
    public partial class Order : Form
    {
        private static BlApi.IBl _bl = BlApi.Factory.Get();
        private BO.Order _order = new BO.Order();
        private string custId;
        private bool isPreferredCustomer = false;
        public Order(string idCust)
        {
            InitializeComponent();
            try
            {
                custId = idCust;
                if (_bl.Customer.IsCustomerExist(int.Parse(idCust)))
                {
                    _order.PreferredCustomer = true;
                    isPreferredCustomer = true;
                    BO.Customer c = new BO.Customer();
                    c = _bl.Customer.Read(int.Parse(idCust));
                    lblHello.Text = c.CustomerName + " שלום ";
                }
                else
                {
                    lblHello.Text = "שלום לקוח מזדמן";
                }
                List<BO.Product> listProd = _bl.Product.ReadAll();
                foreach (BO.Product p in listProd)
                {
                    cbName.Items.Add(p.ProductName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try {
            List<BO.Product> listProd = _bl.Product.ReadAll();
            int code = listProd.Where(p => p.ProductName == cbName.Text).Select(c => c.Id).FirstOrDefault();
            _bl.Order.AddProductToOrder(_order, code, (int)nUDQuentity.Value);
            prodInOrd.Items.Clear();
            foreach (BO.ProductInOrder p in _order.ProductList)
            {
                prodInOrd.Items.Add(p.ProductName);
            }
            Products.DataSource = null;
            Products.Items.Clear();
            Products.DataSource = _order.ProductList.SelectMany(p => p.ToString().Split("\n")).ToList();
            toPay.Text = _order.FinalPrice.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            _bl.Order.DoOrder(_order);
            MessageBox.Show("ההזמנה הושלמה בהצלחה!", "הודעת הזמנה", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BO.ProductInOrder p = _order.ProductList.First(p => prodInOrd.Text == p.ProductName);
            Sales.DataSource = null;
            Sales.Items.Clear();
            if (p.ListSales.Count()==0)
            {
                MessageBox.Show("אין מבצעים למוצר זה", "הודעת הזמנה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Sales.DataSource = p.ListSales.SelectMany(s => s.ToString().Split("\n")).ToList();
        }
    }
}

