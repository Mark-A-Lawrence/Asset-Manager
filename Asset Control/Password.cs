using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Control
{
    public partial class Password : Form
    {
        Thread th;
        string hash = "f0xle@rn";
        public Password()
        {
            InitializeComponent();
        }



        String decrypt(String pass)
        {
            string de = null;
            byte[] data = Convert.FromBase64String(pass);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    de = UTF8Encoding.UTF8.GetString(results);

                }
            }

            return de;

        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                String pass = (String)Properties.Settings.Default["password"];
                if (textBox1.Text.Equals(decrypt(pass)))
                {

                    this.Close();
                    th = new Thread(startHome);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                {
                    MessageBox.Show("Incorrect Password try again");
                }
            }
        }
        private void startHome()
        {
            Application.Run(new home());
        }
    }
}
