using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_Control.Properties;


namespace Asset_Control
{
    public partial class home : Form
    {

       
       
        public home()
        {
            InitializeComponent();
            bool back = (bool)Properties.Settings.Default["background"];
            bool binfo = (bool)Properties.Settings.Default["buttoninfo"];
            if (back == true)
            {
                this.BackgroundImage = Properties.Resources.back;
            }
            else
            {
                //this.BackgroundImage = null;
            }
            if (binfo == true)
            {

                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
            }
            else
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
            }

        }

        private void View_archive_Click(object sender, EventArgs e)
        {

            try
            {
                
                Explore show = new Explore();
                show.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Maintance_Click(object sender, EventArgs e)
        {
            maintain m = new maintain();
            m.Show();

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Settings sett = new Settings();
            sett.Show();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }
    }
}
