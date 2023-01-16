using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_DNF48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ultraGrid1.DataSource = GetData();
            ultraGrid1.DataBind();
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Col1", typeof(String));
            dt.Columns.Add("Col2", typeof(String));

            for(int i = 0; i < 5; i++)
            {
                dt.Rows.Add(new object[] { i, "aaa", "bbb" });
            }

            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };

            return dt;
        }
    }
}
