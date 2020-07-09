namespace Email
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsender = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtreceiver = new System.Windows.Forms.TextBox();
            this.txtportnumber = new System.Windows.Forms.TextBox();
            this.txtsmtp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.rtbody = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chckssl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receiver E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SMTP Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sender Password";
            // 
            // txtsender
            // 
            this.txtsender.Location = new System.Drawing.Point(128, 23);
            this.txtsender.Name = "txtsender";
            this.txtsender.Size = new System.Drawing.Size(177, 20);
            this.txtsender.TabIndex = 5;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(128, 71);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(177, 20);
            this.txtpassword.TabIndex = 6;
            // 
            // txtreceiver
            // 
            this.txtreceiver.Location = new System.Drawing.Point(128, 234);
            this.txtreceiver.Name = "txtreceiver";
            this.txtreceiver.Size = new System.Drawing.Size(177, 20);
            this.txtreceiver.TabIndex = 7;
            // 
            // txtportnumber
            // 
            this.txtportnumber.Location = new System.Drawing.Point(128, 178);
            this.txtportnumber.Name = "txtportnumber";
            this.txtportnumber.Size = new System.Drawing.Size(177, 20);
            this.txtportnumber.TabIndex = 8;
            // 
            // txtsmtp
            // 
            this.txtsmtp.Location = new System.Drawing.Point(128, 117);
            this.txtsmtp.Name = "txtsmtp";
            this.txtsmtp.Size = new System.Drawing.Size(177, 20);
            this.txtsmtp.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Subject";
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(412, 23);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(177, 20);
            this.txtsubject.TabIndex = 11;
            // 
            // rtbody
            // 
            this.rtbody.Location = new System.Drawing.Point(353, 98);
            this.rtbody.Name = "rtbody";
            this.rtbody.Size = new System.Drawing.Size(302, 359);
            this.rtbody.TabIndex = 12;
            this.rtbody.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(102, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 73);
            this.button1.TabIndex = 13;
            this.button1.Text = "Send E-Mail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Body";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "File Attachment";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chckssl
            // 
            this.chckssl.AutoSize = true;
            this.chckssl.Location = new System.Drawing.Point(128, 211);
            this.chckssl.Name = "chckssl";
            this.chckssl.Size = new System.Drawing.Size(46, 17);
            this.chckssl.TabIndex = 18;
            this.chckssl.Text = "SSL";
            this.chckssl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 480);
            this.Controls.Add(this.chckssl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbody);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsmtp);
            this.Controls.Add(this.txtportnumber);
            this.Controls.Add(this.txtreceiver);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtsender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsender;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtreceiver;
        private System.Windows.Forms.TextBox txtportnumber;
        private System.Windows.Forms.TextBox txtsmtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.RichTextBox rtbody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chckssl;
    }
}

