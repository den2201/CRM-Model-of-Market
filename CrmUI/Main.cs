using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL;
using CrmBL.Model;

namespace CrmUI
{
    public partial class Main : Form
    {
        CrmBL.Model.Context db;
       
        public Main()
        {
            InitializeComponent();
            db = new CrmBL.Model.Context();
        }

        private void СущностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogPrduct = new Catalog<Product>(db.Products);
            catalogPrduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogPrduct = new Catalog<Seller>(db.Sellers);
            catalogPrduct.Show();
        }

      

        private void ReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogPrduct = new Catalog<Check>(db.Checks);
            catalogPrduct.Show();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new AddCustomerForm();
            if(form.ShowDialog()==DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }

        }

        private void ВывестиСпиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogPrduct = new Catalog<Customer>(db.Customers);
            catalogPrduct.Show();
        }
    }
}
