using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco
{
    public partial class Sign_Up : Form
    {
        public Dictionary<string, UserInfo> MainUserList { get; set; }
        public Sign_Up()
        {
            InitializeComponent();
        }

        public Sign_Up(Dictionary<string, UserInfo> mainUserList)
        {
            InitializeComponent();
            this.MainUserList = mainUserList;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string tel = tbTel.Text.Trim();

            if (string.IsNullOrEmpty(name) || tel.Length < 10)
            {
                MessageBox.Show("이름 및 전화번호 입력을 다시 확인해주세요.");
                return;
            }

            if (!checkBox1.Checked)
            {
                MessageBox.Show("개인정보수집에 동의해 주세요.");
                return;
            }

           
            if (MainUserList != null)
            {
                if (MainUserList.ContainsKey(tel))
                {
                    MessageBox.Show("이미 가입된 전화번호입니다.");
                    return;
                }

                // 1000p 보너스와 함께 저장
                MainUserList.Add(tel, new UserInfo(name, tel, 1000, 0));

                MessageBox.Show($"🎉 {name}님 회원가입 완료! (축하 포인트 1,000p 적립)");
                this.Close();
            }
            else
            {
                MessageBox.Show("회원 목록 데이터 연결에 실패했습니다.");
            }
        }
    }
}
