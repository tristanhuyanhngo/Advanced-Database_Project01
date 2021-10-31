using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table_DSHoaDon = new DataTable();
        string str = @"Data Source=DESKTOP-SFNTJJK\SQLEXPRESS;Initial Catalog=ADB1_6_DATH1;Integrated Security=True";

        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM HOADON";
            adapter.SelectCommand = command;
            table_DSHoaDon.Clear();
            adapter.Fill(table_DSHoaDon);
            DGV_DanhSachHoaDon.DataSource = table_DSHoaDon;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
