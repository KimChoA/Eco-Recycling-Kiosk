using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            
        }
        public Receipt(string receiptText)
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(271, 388);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            this.MaximizeBox = false;


            this.StartPosition = FormStartPosition.CenterParent;
            lblReceipt.Text = receiptText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
