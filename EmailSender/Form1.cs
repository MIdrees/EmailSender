using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
//idrees - 2
namespace EmailSender
{
    public partial class Form1 : Form
    {
        #region DataMembers 
        SettingsManager settings = SettingsManager.Instance; 
        #endregion

        #region Ctor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }
        #endregion

        #region Control Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                MessageForm.Error(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SendEmail();
            }
            catch (Exception ex)
            {
                MessageForm.Error(ex.Message);
            }
        }
        #endregion

        #region Helpers
        private void Init()
        {
            LoadSettings();
            LoadEmail();

            SetSubject();

            tabControl1.SelectedTab = tpEmail;
        }

        private void SetSubject()
        {
            // 1 o'Clock noon.
            bool isFirstHalf = DateTime.Now.Hour <= 13;
            
            rdbBOD.Checked = isFirstHalf;
            rdbEOD.Checked = !rdbBOD.Checked;
        }

        private void LoadSettings()
        {
            txtTo.Text = settings.To;
            txtCC.Text = settings.CC;
            txtBC.Text = settings.BC;
            txtSubject.Text = settings.Subject;
            txtBody.Text = settings.Body;
        }

        private void LoadEmail()
        {
            txtToE.Text = settings.To;
            txtCCE.Text = settings.CC;
            txtBCE.Text = settings.BC;
            txtSubjectE.Text = settings.Subject;
            txtBodyE.Text = settings.Body;
        }

        private void UpdateSubect()
        {
            //BOD : 09:25 PM ( 08 April 2013 )
            string template = "{0} : " + DateTime.Now.ToString("hh:mm tt ( dd MMMM yyyy )");
            string subject = "";

            if (rdbBOD.Checked)
            {
                subject = string.Format(template, "BOD");
            }
            else if (rdbEOD.Checked)
            {
                subject = string.Format(template, "EOD");
            }

            txtSubjectE.Text = subject;
        }

        private void Save()
        {
            settings.To = txtTo.Text;
            settings.CC = txtCC.Text;
            settings.BC = txtBC.Text;
            settings.Subject = txtSubject.Text;
            settings.Body = txtBody.Text;

            settings.Save();

            MessageForm.Information("Settings saved successfully.");
        }

        private void SendEmail()
        {
            // Create the Outlook application by using inline initialization.
            Outlook.Application olApp = new Outlook.Application();

            //Create the new message by using the simplest approach.
            Outlook.MailItem olMsg = (Outlook.MailItem)olApp.CreateItem(Outlook.OlItemType.olMailItem);

            ////Add a recipient.
            //// TODO: Change the following recipient where appropriate.
            //Outlook.Recipient oRecip = (Outlook.Recipient)oMsg.Recipients.Add("idrees@test.com");
            //oRecip.Resolve();

            olMsg.To = txtToE.Text;
            olMsg.CC = txtCCE.Text;
            olMsg.BCC = txtBCE.Text;

            //Set the basic properties.
            olMsg.Subject = txtSubjectE.Text;
            olMsg.Body = txtBodyE.Text;

            ////Add an attachment.
            //// TODO: change file path where appropriate
            //String sSource = "C:\\setupxlg.txt";
            //String sDisplayName = "MyFirstAttachment";
            //int iPosition = (int)oMsg.Body.Length + 1;
            //int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
            //Outlook.Attachment oAttach = oMsg.Attachments.Add(sSource, iAttachType, iPosition, sDisplayName);

            // If you want to, display the message.
            // oMsg.Display(true);  //modal

            //Send the message.
            olMsg.Save();
            olMsg.Send();

            //Explicitly release objects.
            //oRecip = null;
            //oAttach = null;
            olMsg = null;
            olApp = null;

            MessageForm.Information("Email sent successfully.");
        }
        #endregion

        private void rdbEOD_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSubect();
        }

        private void rdbBOD_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSubect();
        }
    }
}
