using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using support;

namespace Asset_Control
{
    public partial class Add : Form
    {
        String Elcreate = @"CREATE TABLE IF NOT EXISTS [Electronics](
                                           [Quantity] INT NOT NULL,
                                           [Code] VARCHAR(2048)  NOT NULL  PRIMARY KEY,
                                           [Name] VARCHAR(2048)  NOT NULL,
                                           [Description] VARCHAR(2048) NULL,
                                           [Make&Model] VARCHAR(2048) NULL,
                                           [Serial#] VARCHAR(2048) NULL,
                                           [OwnerShip] VARCHAR(2048) NULL,
                                           [Cost] INT NULL,
                                           [Remarks] VARCHAR(2048) NULL,
                                           [Catergory] VARCHAR(2048) NULL,
                                           [Date] VARCHAR(2048) NULL                                                          
                                           )";
        String Lcreate = @"CREATE TABLE IF NOT EXISTS [location](
                                           [Location] VARCHAR(2048) NOT NULL  PRIMARY KEY,
                                           [num] INT AUTO_INCREMENT NULL                                                     
                                           )";



        public DataTable loadData(string createQuery, string execQuery, string server, string name)
        {
           
            dbmanager manager = new dbmanager();
            manager.create(createQuery, server, name);
             return manager.execQuery(execQuery);
          

        }

        void addData()

        {
          

            int lastval = 0;
            Random q = new Random();
            int num = 0;
            DataTable dt = loadData(Elcreate, "Select * From Electronics Where Code like '%TA - " + location.Text.Trim() + " - 000%'", "supportfiles.db3", "Electronics");
            while (lastval != 1)
            {
                num = q.Next(1, 100);
                if (
        dt.Rows.Count <= 0 ||
        (
            dt.Rows.Count > 0 &&
                        null == dt.AsEnumerable().Where
                            (
                                r => r.Field<String>("Code") == ""+num
                             )
                             .FirstOrDefault())){
                    // No duplicate found so insert the data into the data table
                    DateTime dateDate = date.Value.Date;
                    string strDate = String.Format("{0:dd/MM/yy}", date.Value);
                    loadData(Elcreate, "INSERT INTO Electronics VALUES('" + int.Parse(quantity.Text) + "','TA-" + location.Text.Trim() + "-000" + num + "','" + name.Text + "','" + Description.Text + "','" + model.Text + "','" + serial_num.Text + "','" + ownership.Text + "','" + int.Parse(cost.Text)+ "','" + remarks.Text + "','" + catergory.Text + "','" + strDate + "')", "supportfiles.db3", "Electronics");

                    clear_data();
                    lastval = 1;

                }


            }
            


        }

        public Add()
        {
            InitializeComponent();

            dbmanager manager = new dbmanager();
            manager.create(Lcreate, "supportfiles.db3", "location");
            DataTable Dt = manager.execQuery("SELECT * FROM location ");
            location.DisplayMember = "Location";
            location.DataSource = Dt;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addData();
        }

        private void clear_data()
        {
            quantity.Text = "";
            location.Text = "";
            date.Text = "";
            model.Text = "";
            cost.Text = "";
            name.Text = "";
            serial_num.Text = "";
            ownership.Text = "";
            Description.Text = "";
            remarks.Text = "";
            catergory.Text = "";



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Explore ef = new Explore();
            ef.Show();
        }
    }
}
