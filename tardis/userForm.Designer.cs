namespace tardis
{
    partial class userForm
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
            this.replyBx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chatBx = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipServertxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // replyBx
            // 
            this.replyBx.Location = new System.Drawing.Point(12, 489);
            this.replyBx.Name = "replyBx";
            this.replyBx.Size = new System.Drawing.Size(391, 20);
            this.replyBx.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Posalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chatBx
            // 
            this.chatBx.Location = new System.Drawing.Point(12, 95);
            this.chatBx.Name = "chatBx";
            this.chatBx.Size = new System.Drawing.Size(478, 386);
            this.chatBx.TabIndex = 3;
            this.chatBx.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connBtn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.ipServertxtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ipServertxtBx
            // 
            this.ipServertxtBx.Location = new System.Drawing.Point(67, 13);
            this.ipServertxtBx.Name = "ipServertxtBx";
            this.ipServertxtBx.Size = new System.Drawing.Size(100, 20);
            this.ipServertxtBx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP adresa:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // connBtn
            // 
            this.connBtn.Location = new System.Drawing.Point(173, 13);
            this.connBtn.Name = "connBtn";
            this.connBtn.Size = new System.Drawing.Size(61, 46);
            this.connBtn.TabIndex = 7;
            this.connBtn.Text = "Povezi se";
            this.connBtn.UseVisualStyleBackColor = true;
            this.connBtn.Click += new System.EventHandler(this.connBtn_Click);
            // 
            // userForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chatBx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.replyBx);
            this.Name = "userForm";
            this.Text = "userForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox replyBx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox chatBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ipServertxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}