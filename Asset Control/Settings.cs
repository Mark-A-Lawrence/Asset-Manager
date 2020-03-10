using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_Control.Properties;
using Microsoft.VisualBasic;
using support;

namespace Asset_Control
{
    public partial class Settings : Form
    {
        String Lcreate = @"CREATE TABLE IF NOT EXISTS [location](
                                           [Location] VARCHAR(2048) NOT NULL  PRIMARY KEY,
                                           [num] INT AUTO_INCREMENT NULL                                                     
                                           )";

        public Settings()
        {
            InitializeComponent();
            populate();
            bool back = (bool)Properties.Settings.Default["background"];
            bool binfo = (bool)Properties.Settings.Default["buttoninfo"];
            bool usp = (bool)Properties.Settings.Default["usep"];
            if (back == true)
            {
                background.Checked = true;
            }
            else
            {
                background.Checked = false;
            }
            if (binfo == true)
            {
                Bi.Checked = true;
            }
            else
            {
                Bi.Checked = false;
            }
            if (usp == true)
            {
                usep.Checked = true;
            }
            else
            {
                usep.Checked = false;
            }


        }

        private void Button5_Click(object sender, EventArgs e)
        {
            importxcell im = new importxcell();
            im.Show();
        }
         void populate()
        {
            dbmanager manager = new dbmanager();
            manager.create(Lcreate, "supportfiles.db3", "location");
            DataTable Dt = manager.execQuery("SELECT * FROM location ");
            listBox1.DisplayMember = "Location";
            listBox1.DataSource = Dt;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save Changes?", "Yes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                
            

            if (background.Checked == true)
            {
                Properties.Settings.Default["background"] = true;
            }
            else
            {
                Properties.Settings.Default["background"] = false;
            }
            if(Bi.Checked == true)
            {
                Properties.Settings.Default["buttoninfo"] = true;
            }
            else
            {
                Properties.Settings.Default["buttoninfo"] = false;
            }
                Properties.Settings.Default.Save();

                MessageBox.Show("Changes will be made on restart");

            }
            else
            {

            }
        }
        string hash = "f0xle@rn";
        String encrypt(String pass)
        {
            string en =null;
            byte[] data = UTF8Encoding.UTF8.GetBytes(pass);
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    en = Convert.ToBase64String(results, 0, results.Length);

                }
            }

            return en;

        }


        private void Button4_Click(object sender, EventArgs e)
        {
            if (password1.Text.Equals(password2.Text) && password2.Text.ToCharArray().Length >= 8)
            {

                Properties.Settings.Default["password"] = encrypt(password2.Text);
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Invalid Password Ensure passwords match and Has over 8 charactars");
            }
        }

        private void Usep_CheckStateChanged(object sender, EventArgs e)
        {
            if (usep.Checked)
            {
                button4.Enabled = true;
                password1.ReadOnly = false;
                password2.ReadOnly = false;
                Properties.Settings.Default["usep"] = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                button4.Enabled = false;
                password1.ReadOnly = true;
                password2.ReadOnly = true;
                Properties.Settings.Default["usep"] = false;
                Properties.Settings.Default.Save();
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dbmanager manager = new dbmanager();
            manager.create(Lcreate, "supportfiles.db3", "location");
            String input = Interaction.InputBox("Enter Location", "", "", -1, -1);
            if (input != "")
            {
                DataTable Dt = manager.execQuery("Insert Into location(Location) Values('" + input + "')");
                populate();
            }
            else
            {

            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String value = listBox1.GetItemText(listBox1.SelectedItem);
            dbmanager manager = new dbmanager();
            manager.create(Lcreate, "supportfiles.db3", "location");
            DataTable Dt = manager.execQuery("Delete From location Where Location like '%"+value+"%'");
            populate();
        }
    }
}
