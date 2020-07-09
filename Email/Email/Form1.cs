using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Net;
using System.Net.Mail;
using System.Linq.Expressions;

namespace Email
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofdAttachment;
        string fileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "Images(.jpg,.png)|*.png;*.jpg;|pdf Files|*.pdf";
                if (ofdAttachment.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdAttachment.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //smtp client Details
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(txtportnumber.Text.Trim());
                clientDetails.Host = txtsmtp.Text.Trim();  //smtp server name eg- smtp.gmail.com
                clientDetails.EnableSsl = chckssl.Checked;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.Credentials = new NetworkCredential(txtsender.Text.Trim(), txtpassword.Text.Trim());

                //message Details
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(txtsender.Text.Trim());
                mailDetails.To.Add(txtreceiver.Text.Trim());

                mailDetails.Subject = txtsubject.Text.Trim(); //subject of the message
                mailDetails.Body = rtbody.Text.Trim();

                //to file attachments
                if (fileName.Length > 0)
                {
                    Attachment attachment = new Attachment(fileName);
                    mailDetails.Attachments.Add(attachment);
                }

                clientDetails.Send(mailDetails);
                MessageBox.Show("Your Message has been sent!!");
                fileName = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
    }
}
