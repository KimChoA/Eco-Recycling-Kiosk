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
    public partial class IsSingUp : Form
    {
        public Dictionary<string, UserInfo> MainUserList { get; set; }
        public IsSingUp()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Sign_Up newForm = new Sign_Up();

          
            newForm.MainUserList = this.MainUserList;

            this.Close(); 

            newForm.ShowDialog(); 
        }

        
    }
}
