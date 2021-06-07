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
    public partial class FormAddData : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataAdapter d1 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        Region x = new Region();
        SqlCommand ccc2 = new SqlCommand();
        public FormAddData()
        {
            InitializeComponent();
        }
        void fillgrid(string s = "select * from Part")
        {
            cmd1.CommandText = s;
            cmd1.Connection = conn;
            d1.SelectCommand = cmd1;
            ds.Clear();
            d1.Fill(ds, "T1");
            txtpnameresult.DataBindings.Clear();
            txtpnameresult.DataBindings.Add("text", ds, "T1.PName");
            txtpnameresult.Text = txtpnameresult.Text;
            txtpidresult.DataBindings.Clear();
            txtpidresult.DataBindings.Add("text", ds, "T1.PID");
        }
        void UPD(string s = "select * from Shipment")
        {
            string qty;
            int output;
            cmd1.CommandText = s;
            cmd1.Connection = conn;
            d1.SelectCommand = cmd1;
            //ds.Clear();
            d1.Fill(ds, "T2");
            //txtqty.DataBindings.Clear();
            //txtqty.DataBindings.Add("text", ds, "T2.Qty");
            qty = cmd1.ExecuteScalar().ToString();
            output = Convert.ToInt32(qty);
            output += Convert.ToInt32(txtqty.Text);
            //MessageBox.Show(output.ToString());
            cmd1.CommandText = "update Shipment set Qty=@p1 where SID=@p2 and PID=@p3";
            cmd1.Parameters.AddWithValue("p1", output);
            cmd1.Parameters.AddWithValue("p2", txtsid.Text);
            cmd1.Parameters.AddWithValue("p3", txtpid.Text);
            cmd1.ExecuteNonQuery();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                fillgrid("select PID,PName from Part where PID="+txtpid.Text+"");
                txtresult.Text = "Accepted!";
                txtresult.ForeColor = Color.Green;
                UPD("select Qty from Shipment where PID='"+ txtpid.Text +"' and SID='"+txtsid.Text+"'");
            }
            catch
            {
                txtresult.Text = "Denied!";
                MessageBox.Show("Invalid Input");
            }
        }

        private void FormAddData_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();
        }
    }
}
