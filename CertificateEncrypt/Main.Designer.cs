namespace CertificateEncrypt
{
	partial class Main
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
			this.tbSource = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblCertFile = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.chooseCertFile = new System.Windows.Forms.OpenFileDialog();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.cbAction = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbSource
			// 
			this.tbSource.Location = new System.Drawing.Point(18, 127);
			this.tbSource.Multiline = true;
			this.tbSource.Name = "tbSource";
			this.tbSource.Size = new System.Drawing.Size(487, 214);
			this.tbSource.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Source Text";
			// 
			// tbResult
			// 
			this.tbResult.Location = new System.Drawing.Point(21, 411);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.Size = new System.Drawing.Size(487, 214);
			this.tbResult.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 395);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Resulting Test";
			// 
			// lblCertFile
			// 
			this.lblCertFile.AutoSize = true;
			this.lblCertFile.Location = new System.Drawing.Point(23, 10);
			this.lblCertFile.Name = "lblCertFile";
			this.lblCertFile.Size = new System.Drawing.Size(0, 13);
			this.lblCertFile.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 26);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Select Certificate File";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Certificate Password";
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(224, 362);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
			this.btnEncrypt.TabIndex = 8;
			this.btnEncrypt.Text = "Go!";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// chooseCertFile
			// 
			this.chooseCertFile.FileName = "openFileDialog1";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(24, 81);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(228, 20);
			this.tbPassword.TabIndex = 9;
			// 
			// cbAction
			// 
			this.cbAction.FormattingEnabled = true;
			this.cbAction.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
			this.cbAction.Location = new System.Drawing.Point(319, 81);
			this.cbAction.Name = "cbAction";
			this.cbAction.Size = new System.Drawing.Size(135, 21);
			this.cbAction.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(316, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Action";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 637);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbAction);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblCertFile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbSource);
			this.Name = "Main";
			this.Text = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblCertFile;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.OpenFileDialog chooseCertFile;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.ComboBox cbAction;
		private System.Windows.Forms.Label label4;
	}
}