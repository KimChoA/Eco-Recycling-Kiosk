namespace Eco
{
    partial class Qize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnO = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblQuestion.Location = new System.Drawing.Point(26, 194);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(78, 31);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTimer.Location = new System.Drawing.Point(26, 298);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(83, 31);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "label2";
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.White;
            this.btnO.FlatAppearance.BorderSize = 0;
            this.btnO.Font = new System.Drawing.Font("Noto Sans KR Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnO.ForeColor = System.Drawing.Color.Green;
            this.btnO.Location = new System.Drawing.Point(114, 375);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(134, 126);
            this.btnO.TabIndex = 2;
            this.btnO.Text = "⭕";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.Font = new System.Drawing.Font("굴림체", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(377, 379);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(134, 126);
            this.btnX.TabIndex = 3;
            this.btnX.Text = "✖";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Qize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 834);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Qize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Timer timer1;
    }
}