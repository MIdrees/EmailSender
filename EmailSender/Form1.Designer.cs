namespace EmailSender
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtBC = new System.Windows.Forms.TextBox();
            this.lblBC = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.tpEmail = new System.Windows.Forms.TabPage();
            this.txtBodyE = new System.Windows.Forms.TextBox();
            this.lblBodyE = new System.Windows.Forms.Label();
            this.txtSubjectE = new System.Windows.Forms.TextBox();
            this.lblSubjectE = new System.Windows.Forms.Label();
            this.txtBCE = new System.Windows.Forms.TextBox();
            this.lblBCE = new System.Windows.Forms.Label();
            this.txtCCE = new System.Windows.Forms.TextBox();
            this.lblCCE = new System.Windows.Forms.Label();
            this.txtToE = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblToE = new System.Windows.Forms.Label();
            this.rdbEOD = new System.Windows.Forms.RadioButton();
            this.rdbBOD = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tpEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Controls.Add(this.tpEmail);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.txtBody);
            this.tpSettings.Controls.Add(this.lblBody);
            this.tpSettings.Controls.Add(this.txtSubject);
            this.tpSettings.Controls.Add(this.lblSubject);
            this.tpSettings.Controls.Add(this.txtBC);
            this.tpSettings.Controls.Add(this.lblBC);
            this.tpSettings.Controls.Add(this.txtCC);
            this.tpSettings.Controls.Add(this.lblCC);
            this.tpSettings.Controls.Add(this.txtTo);
            this.tpSettings.Controls.Add(this.btnSave);
            this.tpSettings.Controls.Add(this.lblTo);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(548, 413);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(77, 122);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(453, 233);
            this.txtBody.TabIndex = 10;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(20, 129);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 9;
            this.lblBody.Text = "Body";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(77, 96);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(453, 20);
            this.txtSubject.TabIndex = 8;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(20, 103);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Subject";
            // 
            // txtBC
            // 
            this.txtBC.Location = new System.Drawing.Point(77, 70);
            this.txtBC.Name = "txtBC";
            this.txtBC.Size = new System.Drawing.Size(453, 20);
            this.txtBC.TabIndex = 6;
            // 
            // lblBC
            // 
            this.lblBC.AutoSize = true;
            this.lblBC.Location = new System.Drawing.Point(20, 77);
            this.lblBC.Name = "lblBC";
            this.lblBC.Size = new System.Drawing.Size(21, 13);
            this.lblBC.TabIndex = 5;
            this.lblBC.Text = "BC";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(77, 44);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(453, 20);
            this.txtCC.TabIndex = 4;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(20, 51);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(21, 13);
            this.lblCC.TabIndex = 3;
            this.lblCC.Text = "CC";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(77, 18);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(453, 20);
            this.txtTo.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(20, 25);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To";
            // 
            // tpEmail
            // 
            this.tpEmail.Controls.Add(this.rdbBOD);
            this.tpEmail.Controls.Add(this.rdbEOD);
            this.tpEmail.Controls.Add(this.txtBodyE);
            this.tpEmail.Controls.Add(this.lblBodyE);
            this.tpEmail.Controls.Add(this.txtSubjectE);
            this.tpEmail.Controls.Add(this.lblSubjectE);
            this.tpEmail.Controls.Add(this.txtBCE);
            this.tpEmail.Controls.Add(this.lblBCE);
            this.tpEmail.Controls.Add(this.txtCCE);
            this.tpEmail.Controls.Add(this.lblCCE);
            this.tpEmail.Controls.Add(this.txtToE);
            this.tpEmail.Controls.Add(this.btnSend);
            this.tpEmail.Controls.Add(this.lblToE);
            this.tpEmail.Location = new System.Drawing.Point(4, 22);
            this.tpEmail.Name = "tpEmail";
            this.tpEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmail.Size = new System.Drawing.Size(548, 413);
            this.tpEmail.TabIndex = 1;
            this.tpEmail.Text = "Email";
            this.tpEmail.UseVisualStyleBackColor = true;
            // 
            // txtBodyE
            // 
            this.txtBodyE.Location = new System.Drawing.Point(76, 122);
            this.txtBodyE.Multiline = true;
            this.txtBodyE.Name = "txtBodyE";
            this.txtBodyE.Size = new System.Drawing.Size(453, 193);
            this.txtBodyE.TabIndex = 21;
            // 
            // lblBodyE
            // 
            this.lblBodyE.AutoSize = true;
            this.lblBodyE.Location = new System.Drawing.Point(19, 129);
            this.lblBodyE.Name = "lblBodyE";
            this.lblBodyE.Size = new System.Drawing.Size(31, 13);
            this.lblBodyE.TabIndex = 20;
            this.lblBodyE.Text = "Body";
            // 
            // txtSubjectE
            // 
            this.txtSubjectE.Location = new System.Drawing.Point(76, 96);
            this.txtSubjectE.Name = "txtSubjectE";
            this.txtSubjectE.Size = new System.Drawing.Size(453, 20);
            this.txtSubjectE.TabIndex = 19;
            // 
            // lblSubjectE
            // 
            this.lblSubjectE.AutoSize = true;
            this.lblSubjectE.Location = new System.Drawing.Point(19, 103);
            this.lblSubjectE.Name = "lblSubjectE";
            this.lblSubjectE.Size = new System.Drawing.Size(43, 13);
            this.lblSubjectE.TabIndex = 18;
            this.lblSubjectE.Text = "Subject";
            // 
            // txtBCE
            // 
            this.txtBCE.Location = new System.Drawing.Point(76, 70);
            this.txtBCE.Name = "txtBCE";
            this.txtBCE.Size = new System.Drawing.Size(453, 20);
            this.txtBCE.TabIndex = 17;
            // 
            // lblBCE
            // 
            this.lblBCE.AutoSize = true;
            this.lblBCE.Location = new System.Drawing.Point(19, 77);
            this.lblBCE.Name = "lblBCE";
            this.lblBCE.Size = new System.Drawing.Size(21, 13);
            this.lblBCE.TabIndex = 16;
            this.lblBCE.Text = "BC";
            // 
            // txtCCE
            // 
            this.txtCCE.Location = new System.Drawing.Point(76, 44);
            this.txtCCE.Name = "txtCCE";
            this.txtCCE.Size = new System.Drawing.Size(453, 20);
            this.txtCCE.TabIndex = 15;
            // 
            // lblCCE
            // 
            this.lblCCE.AutoSize = true;
            this.lblCCE.Location = new System.Drawing.Point(19, 51);
            this.lblCCE.Name = "lblCCE";
            this.lblCCE.Size = new System.Drawing.Size(21, 13);
            this.lblCCE.TabIndex = 14;
            this.lblCCE.Text = "CC";
            // 
            // txtToE
            // 
            this.txtToE.Location = new System.Drawing.Point(76, 18);
            this.txtToE.Name = "txtToE";
            this.txtToE.Size = new System.Drawing.Size(453, 20);
            this.txtToE.TabIndex = 13;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(22, 372);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblToE
            // 
            this.lblToE.AutoSize = true;
            this.lblToE.Location = new System.Drawing.Point(19, 25);
            this.lblToE.Name = "lblToE";
            this.lblToE.Size = new System.Drawing.Size(20, 13);
            this.lblToE.TabIndex = 11;
            this.lblToE.Text = "To";
            // 
            // rdbEOD
            // 
            this.rdbEOD.AutoSize = true;
            this.rdbEOD.Location = new System.Drawing.Point(76, 344);
            this.rdbEOD.Name = "rdbEOD";
            this.rdbEOD.Size = new System.Drawing.Size(48, 17);
            this.rdbEOD.TabIndex = 22;
            this.rdbEOD.TabStop = true;
            this.rdbEOD.Text = "EOD";
            this.rdbEOD.UseVisualStyleBackColor = true;
            this.rdbEOD.CheckedChanged += new System.EventHandler(this.rdbEOD_CheckedChanged);
            // 
            // rdbBOD
            // 
            this.rdbBOD.AutoSize = true;
            this.rdbBOD.Location = new System.Drawing.Point(76, 321);
            this.rdbBOD.Name = "rdbBOD";
            this.rdbBOD.Size = new System.Drawing.Size(48, 17);
            this.rdbBOD.TabIndex = 23;
            this.rdbBOD.TabStop = true;
            this.rdbBOD.Text = "BOD";
            this.rdbBOD.UseVisualStyleBackColor = true;
            this.rdbBOD.CheckedChanged += new System.EventHandler(this.rdbBOD_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 463);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.tpEmail.ResumeLayout(false);
            this.tpEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpEmail;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtBC;
        private System.Windows.Forms.Label lblBC;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtBodyE;
        private System.Windows.Forms.Label lblBodyE;
        private System.Windows.Forms.TextBox txtSubjectE;
        private System.Windows.Forms.Label lblSubjectE;
        private System.Windows.Forms.TextBox txtBCE;
        private System.Windows.Forms.Label lblBCE;
        private System.Windows.Forms.TextBox txtCCE;
        private System.Windows.Forms.Label lblCCE;
        private System.Windows.Forms.TextBox txtToE;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblToE;
        private System.Windows.Forms.RadioButton rdbBOD;
        private System.Windows.Forms.RadioButton rdbEOD;
    }
}

