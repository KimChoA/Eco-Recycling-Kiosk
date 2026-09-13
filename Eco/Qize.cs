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
    public partial class Qize : Form
    {
        private int timeLeft = 10;
        private Timer timer = new Timer();
        private bool isCorrectAnswer = true; 

        public bool IsCorrect { get; private set; } = false;
        public Qize()
        {
            InitializeComponent();
            SetupQuiz();
            InitTimer();
        }

        private void SetupQuiz()
        {
            this.Text = " AI 분석 맞춤 10초 퀴즈!";
            this.Size = new Size(629, 873);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            lblQuestion.Text = "Q. 페트병은 라벨(비닐)을 제거하고 \n     내용물을 비운 뒤 배출해야 할까요?";
            isCorrectAnswer = true;
        }

        private void InitTimer()
        {
            timer.Interval = 1000;

         
            timer.Tick += (s, e) =>
            {
                timeLeft--;
                UpdateTimerText();

                if (timeLeft <= 0)
                {
                    timer.Stop();
                    MessageBox.Show("⏰ 제한 시간이 초과되었습니다!\n아쉽지만 퀴즈 포인트는 적립되지 않습니다.", "시간 초과", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsCorrect = false;
                    this.Close();
                }
            };

            timer.Start();
            UpdateTimerText();
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            CheckAnswer(true);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            CheckAnswer(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            UpdateTimerText();

            if (timeLeft <= 0)
            {
                timer.Stop();
                MessageBox.Show("⏰ 제한 시간이 초과되었습니다!\n아쉽지만 퀴즈 포인트는 적립되지 않습니다.", "시간 초과", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsCorrect = false;
                this.Close();
            }
        }
        private void UpdateTimerText()
        {
            lblTimer.Text = $"⏰ 남은 시간: {timeLeft}초";
            if (timeLeft <= 3)
            {
                lblTimer.ForeColor = Color.Red;
            }
        }
        private void CheckAnswer(bool userChoice)
        {
            timer.Stop();

            if (userChoice == isCorrectAnswer)
            {
                IsCorrect = true; 
                MessageBox.Show("🎉 정답입니다!\n퀴즈 보너스 +50p가 적립됩니다!", "정답 확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IsCorrect = false;
                MessageBox.Show("💡 아쉽네요, 오답입니다!\n페트병은 라벨을 떼서 비닐로 따로 배출해야 합니다.", "오답 확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
