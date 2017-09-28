namespace tardis
{
    partial class adminForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.porttxtBx = new System.Windows.Forms.TextBox();
            this.ipServertxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.replyBx = new System.Windows.Forms.TextBox();
            this.chatBx = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.clientCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientList = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Controls.Add(this.porttxtBx);
            this.groupBox1.Controls.Add(this.ipServertxtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(158, 19);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(52, 46);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start server";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // porttxtBx
            // 
            this.porttxtBx.Location = new System.Drawing.Point(67, 45);
            this.porttxtBx.Name = "porttxtBx";
            this.porttxtBx.Size = new System.Drawing.Size(85, 20);
            this.porttxtBx.TabIndex = 2;
            // 
            // ipServertxtBx
            // 
            this.ipServertxtBx.Location = new System.Drawing.Point(67, 19);
            this.ipServertxtBx.Name = "ipServertxtBx";
            this.ipServertxtBx.Size = new System.Drawing.Size(85, 20);
            this.ipServertxtBx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP adresa:";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(396, 461);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(88, 20);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Posalji";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // replyBx
            // 
            this.replyBx.Location = new System.Drawing.Point(12, 461);
            this.replyBx.Name = "replyBx";
            this.replyBx.Size = new System.Drawing.Size(378, 20);
            this.replyBx.TabIndex = 2;
            // 
            // chatBx
            // 
            this.chatBx.Location = new System.Drawing.Point(12, 99);
            this.chatBx.Name = "chatBx";
            this.chatBx.Size = new System.Drawing.Size(472, 356);
            this.chatBx.TabIndex = 5;
            this.chatBx.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(731, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // clientCount
            // 
            this.clientCount.Name = "clientCount";
            this.clientCount.Size = new System.Drawing.Size(166, 17);
            this.clientCount.Text = "Trenutno povezanih klijenata: ";
            // 
            // clientList
            // 
            this.clientList.CheckBoxes = true;
            this.clientList.Location = new System.Drawing.Point(491, 99);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(121, 382);
            this.clientList.TabIndex = 8;
            this.clientList.UseCompatibleStateImageBehavior = false;
            this.clientList.View = System.Windows.Forms.View.List;
            // 
            // adminForm
            // 
            this.AcceptButton = this.sendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 508);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chatBx);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.replyBx);
            this.Controls.Add(this.groupBox1);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ipServertxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox porttxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox replyBx;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.RichTextBox chatBx;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel clientCount;
        private System.Windows.Forms.ListView clientList;
    }
}