using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp.AllUserControl
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM Room";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            cbbTypeRoom.SelectedIndex = 0;
        }

        private void btnAddiRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNum.Text != "" && txtPriceRoom.Text != "" && cbbTypeRoom.Text != "")
            {
                String roomNum = txtRoomNum.Text;
                String roomType = cbbTypeRoom.Text;
                float roomPrice = float.Parse(txtPriceRoom.Text);

                query = "INSERT INTO Room (num, type, price) values ('" + roomNum + "' , '" + roomType + "' , '" + roomPrice + "')";
                fn.setData(query, "Đã thêm phòng");
                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tạo phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtRoomNum.Clear();
            txtPriceRoom.Clear();
            txtNumBed.Clear();
            cbbTypeRoom.SelectedIndex = 0;
        }


    }
}
