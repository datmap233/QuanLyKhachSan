﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fSpecialRequirement : Form
    {
        private string connetionString = DataConnection.sqlConn;

        private string maphieudatphong = "";
        private string tenKH = "";
        private string maKh = "";

        private bool isCreateRequired = false;
        public bool IsCreateRequired
        {
            get { return isCreateRequired; }
            set { isCreateRequired = value; }
        }

        public fSpecialRequirement()
        {
            InitializeComponent();
        }
        public fSpecialRequirement(string Message1, string Message2, string Message3) : this()
        {
            maphieudatphong = Message1;
            maKh = Message2;
            tenKH = Message3;
            maphieu.Text = maphieudatphong;
            textTenKhachHang.Text = tenKH;
        }

        private void ExecuteSql(string queryString)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(queryString, cnn);
            int result = cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            if (textNoidung.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn với lựa chọn của mình chưa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ExecuteSql("INSERT INTO dbo.PHIEUYEUCAU(MaKH, NoiDung) VALUES ('" + maKh + "',N'" +
                        textNoidung.Text + "')");
                    isCreateRequired = true;
                    textNoidung.Text = "";
                    this.Close();
                }
                else
                    MessageBox.Show("Chưa chọn phòng nào cả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn chưa nhập thông tin nào cả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
