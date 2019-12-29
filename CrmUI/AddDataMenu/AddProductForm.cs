using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class AddProductForm : Form
    {
        public Product Product { get; set; }
        public AddProductForm()
        {
            InitializeComponent();
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Product = new Product()
            { Name = this.textBox1.Text,
            Price=this.numericUpDown1.Value,
            Count=Convert.ToInt32(this.numericUpDown2.Value)
            };
            Close();   
        }

      
    }
}
