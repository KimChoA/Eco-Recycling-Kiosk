namespace Eco
{
    partial class IsSingUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_no = new System.Windows.Forms.RadioButton();
            this.radio_yes = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원정보를 찾을 수 없습니다.\r\n\r\n회원가입을 하시겠습니까?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_no);
            this.groupBox1.Controls.Add(this.radio_yes);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(20, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원가입";
            // 
            // radio_no
            // 
            this.radio_no.AutoSize = true;
            this.radio_no.Location = new System.Drawing.Point(178, 31);
            this.radio_no.Name = "radio_no";
            this.radio_no.Size = new System.Drawing.Size(73, 20);
            this.radio_no.TabIndex = 1;
            this.radio_no.TabStop = true;
            this.radio_no.Text = "아니요";
            this.radio_no.UseVisualStyleBackColor = true;
            // 
            // radio_yes
            // 
            this.radio_yes.AutoSize = true;
            this.radio_yes.Location = new System.Drawing.Point(29, 31);
            this.radio_yes.Name = "radio_yes";
            this.radio_yes.Size = new System.Drawing.Size(41, 20);
            this.radio_yes.TabIndex = 0;
            this.radio_yes.TabStop = true;
            this.radio_yes.Text = "네";
            this.radio_yes.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEnter.Location = new System.Drawing.Point(337, 145);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "확인";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 214);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_no;
        private System.Windows.Forms.RadioButton radio_yes;
        private System.Windows.Forms.Button btnEnter;
    }
}