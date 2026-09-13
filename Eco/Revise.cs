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
    public partial class Revise : Form
    {
        public UserInfo CurrentUser { get; set; }

      
        public Dictionary<string, UserInfo> MainUserList { get; set; }
        public Revise()
        {
            InitializeComponent();
        }
        // 폼이 로드될 때 기존 유저 정보를 텍스트박스에 표시
        private void EditForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                textBox2.Text = CurrentUser.Name;
                textBox1.Text = CurrentUser.PhoneNumber;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string newName = textBox2.Text.Trim();
            string newTel = textBox1.Text.Trim().Replace("-", "").Replace(" ", "");

            
            if (string.IsNullOrEmpty(newName) || newTel.Length < 10)
            {
                MessageBox.Show("이름과 전화번호를 올바르게 입력해 주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            string oldTel = CurrentUser.PhoneNumber;

            if (oldTel != newTel)
            {
                
                if (MainUserList != null && MainUserList.ContainsKey(newTel))
                {
                    MessageBox.Show("이미 존재하거나 사용 중인 전화번호입니다.", "중복 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (MainUserList != null && MainUserList.ContainsKey(oldTel))
                {
                    MainUserList.Remove(oldTel);
                    CurrentUser.PhoneNumber = newTel;
                    MainUserList.Add(newTel, CurrentUser);
                }
            }
            CurrentUser.Name = newName;

            MessageBox.Show("회원정보가 성공적으로 수정되었습니다!", "수정 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK; 
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
