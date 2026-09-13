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
    public partial class Cupon : Form
    {
        public Cupon()
        {
            InitializeComponent();
        }

        public Cupon(List<string> couponList)
        {
            InitializeComponent();

            // 전달받은 쿠폰 리스트를 ListBox에 표시
            if (couponList != null && couponList.Count > 0)
            {
                foreach (string coupon in couponList)
                {
                    listBox1.Items.Add(coupon);
                }
            }
            else
            {
                listBox1.Items.Add("보유 중인 쿠폰이 없습니다.");
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

        
            e.DrawBackground();

            
            string text = listBox1.Items[e.Index].ToString();

         
            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds.X + 5, e.Bounds.Y + 4);
            }

            
            using (Pen linePen = new Pen(Color.LightGray, 1)) 
            {
                
                int yPosition = e.Bounds.Bottom - 1;
                e.Graphics.DrawLine(linePen, e.Bounds.Left, yPosition, e.Bounds.Right, yPosition);
            }

            
            e.DrawFocusRectangle();
        }
    }
}
