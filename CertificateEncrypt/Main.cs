using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateEncrypt
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			chooseCertFile.ShowDialog();

			lblCertFile.Text = chooseCertFile.FileName;
		}

		private static string Encrypt(string text, string certFileName, string certPassword)
		{
			var certificate = new X509Certificate2(certFileName, certPassword);
			var rsa = (RSACryptoServiceProvider)certificate.PrivateKey;
			var bytes = Encoding.UTF8.GetBytes(text);

			var encrypted = rsa.Encrypt(bytes, true);
			return Convert.ToBase64String(encrypted);
		}

		private static string Decrypt(string text, string certFileName, string certPassword)
		{
			var bytes = Convert.FromBase64String(text);
			var certificate = new X509Certificate2(certFileName, certPassword);
			var rsa = (RSACryptoServiceProvider)certificate.PrivateKey;

			var decrypted = rsa.Decrypt(bytes, true);

			return Encoding.UTF8.GetString(decrypted);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(lblCertFile.Text))
			{
				MessageBox.Show("Please specify a certificate");
				return;
			}

			if (string.IsNullOrWhiteSpace(tbPassword.Text))
			{
				MessageBox.Show("Please specify a password");
				return;
			}

			if (string.IsNullOrWhiteSpace(tbSource.Text))
			{
				MessageBox.Show("Please specify source text");
				return;
			}

			try
			{
				tbResult.Text = cbAction.SelectedItem == "Encrypt"
					? Encrypt(tbSource.Text, lblCertFile.Text, tbPassword.Text)
					: Decrypt(tbSource.Text, lblCertFile.Text, tbPassword.Text);


			}
			catch (Exception ex)
			{
				MessageBox.Show("Error encrypting string: " + ex.Message);
			}
		}
	}
}
