namespace Eco
{
    partial class Sign_Up
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(159, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원가입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(29, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름(name)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "전화번호(tel)";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEnter.Location = new System.Drawing.Point(208, 625);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(190, 73);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "가입하기";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbName.Location = new System.Drawing.Point(236, 324);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(389, 48);
            this.tbName.TabIndex = 4;
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTel.Location = new System.Drawing.Point(236, 429);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(387, 48);
            this.tbTel.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.Location = new System.Drawing.Point(140, 535);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(326, 39);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "개인정보수집 동의";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(637, 913);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}