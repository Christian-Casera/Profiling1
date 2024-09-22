using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMonitoring
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    //BookID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //    //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //}
            ////panel3.Visible = true;
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = "server =127.0.0.1;user=root;database=profiling;";
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Connection = con;


            //cmd.CommandText = "select * from attendance";
            //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            ////rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            ////dataGridView1.DataSource = ds.Tables[0];
            ////txtbookname.Text = ds.Tables[0].Rows[0][1].ToString();
            ////txtbookauthor.Text = ds.Tables[0].Rows[0][2].ToString();
            ////txtbookpublication.Text = ds.Tables[0].Rows[0][3].ToString();
            ////dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
            ////txtbookprice.Text = ds.Tables[0].Rows[0][5].ToString();
            ////txtbookquantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

            //panel3.Visible = true;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server =127.0.0.1;user=root;database=Profiling;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from attendance";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

