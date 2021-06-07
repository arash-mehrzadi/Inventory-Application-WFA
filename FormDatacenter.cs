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
    public partial class FormDatacenter : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        //CurrencyManager cr;
        public FormDatacenter()
        {
            InitializeComponent();
        }
        void fillgrid(string s = "select * from Part",string t = "t1")
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

        private void FormDatacenter_Load(object sender, EventArgs e)
        {
            cmbtable.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();
            fillgrid();
        }

        private void cmbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string T="t1";
            if(cmbtable.Text=="Part")
            {
                T = "t1";
            }
            if(cmbtable.Text=="Shipment")
            {
                T = "t2";
            }
            if(cmbtable.Text=="Supplier")
            {
                T = "t3";
            }
            fillgrid("select * from " + cmbtable.Text,T);
        }
    }
}
