using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco
{
    
    public partial class main : Form
    {

        public Dictionary<string, UserInfo> userList = new Dictionary<string, UserInfo>();
        public main()
        {
            InitializeComponent();
            InitUserData();
        }
        private void InitUserData()
        {
            userList.Add("01012341234", new UserInfo("김지구","01012341234", 10000, 5000, 15.5, 2.3)); 
            userList.Add("01056785678", new UserInfo("박우주","01056785678", 2300, 150000, 42.0, 6.3)); 
            userList.Add("01012345678", new UserInfo("이사랑","01012345678", 50000, 2000, 8.2, 1.2));   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string inputPhone = textBox1.Text.Trim().Replace("-", "").Replace(" ", "");

            if (inputPhone.Length < 10)
            {
                MessageBox.Show("전화번호를 올바르게 입력해 주세요.", "알림");
                return;
            }

            if (userList.ContainsKey(inputPhone))
            {
                UserInfo loginUser = userList[inputPhone];

                MainForm mainForm = new MainForm(loginUser, this);
                mainForm.Show();

                this.Hide();
            }
            else
            {
                
                IsSingUp form2 = new IsSingUp();
                form2.MainUserList = this.userList; 
                form2.ShowDialog(); 
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Sign_Up newForm = new Sign_Up();

           
            newForm.MainUserList = this.userList;

            this.Hide();

            newForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            newForm.Show();
        }
    }
}
