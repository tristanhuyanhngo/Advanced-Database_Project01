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
        DataTable table_DoanhThuTheoThang = new DataTable();
        string str = @"Data Source=DESKTOP-3218CJS;Initial Catalog=ADB1_6_DATH1;Integrated Security=True";

        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM HOADON";
            adapter.SelectCommand = command;
            table_DSHoaDon.Clear();
            adapter.Fill(table_DSHoaDon);
            DGV_DanhSachHoaDon.DataSource = table_DSHoaDon;

            // Doanh Thu theo thang
            /*
            command = connection.CreateCommand();
            command.CommandText = "";
            adapter.SelectCommand = command;
            table_DoanhThuTheoThang.Clear();
            adapter.Fill(table_DoanhThuTheoThang);
            DGV_DoanhThuTheoThang.DataSource = table_DoanhThuTheoThang;
             */
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

        private void DGV_DanhSachHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = DGV_DanhSachHoaDon.CurrentRow.Index;
            Input_MaHoaDon.Text = DGV_DanhSachHoaDon.Rows[index].Cells[0].Value.ToString();
            Input_MaKhachHang.Text = DGV_DanhSachHoaDon.Rows[index].Cells[1].Value.ToString();
            Input_NgayLap.Text = DGV_DanhSachHoaDon.Rows[index].Cells[2].Value.ToString();
            Input_TongTien.Text = DGV_DanhSachHoaDon.Rows[index].Cells[3].Value.ToString();
        }

        private void button_ThemMoiHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "INSERT INTO HoaDon VALUES ('"+Input_MaHoaDon.Text+"','"+Input_MaKhachHang.Text+"','"+Input_NgayLap.Text+ "','" + Input_TongTien.Text + "')";
            command.ExecuteNonQuery();
            LoadData();
        }
    }
}
