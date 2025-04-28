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
    public partial class shop : Form
    {
        public shop()
        {
            InitializeComponent();
        }

        private void enterManager_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            m.ShowDialog();
        }

        private void enterCashier_Click(object sender, EventArgs e)
        {
            EnterToOrder enterToOrder = new EnterToOrder();
            enterToOrder.ShowDialog();
        }
    }
}
