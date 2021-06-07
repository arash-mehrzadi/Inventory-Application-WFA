using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadino_trade
{
    public partial class Report : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string T = "t1";
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            cmbtable.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();
            
        }
        void fillgrid(string s = "select * from Part", string t = "t1")
        {
            cmd.CommandText = s;
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds, t);
            dgv.DataBindings.Clear();
            dgv.DataBindings.Add("datasource", ds, t);
            //cr = (CurrencyManager)this.BindingContext[ds, "t1"];
        }
        private void cmbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtable.Text == "Return Product")
            {
                T = "t1";
            }
            
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            fillgrid("find " + txtpid.Text, T);
        }
    }
}
