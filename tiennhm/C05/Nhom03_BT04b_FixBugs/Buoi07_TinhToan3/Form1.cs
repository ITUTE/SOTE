using System;
using System.Windows.Forms;

namespace Buoi07_TinhToan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSo1.Text = txtSo2.Text = "0";
            radCong.Checked = true;             //đầu tiên chọn phép cộng
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có thực sự muốn thoát không?",
                                 "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            //Khai báo
            double so1, so2, kq = 0;
            //Lấy giá trị num1
            so1 = double.Parse(txtSo1.Text);
            //Lấy giá trị num2
            so2 = double.Parse(txtSo2.Text);
            //Thực hiện phép tính dựa vào phép toán được chọn
            if (radCong.Checked) kq = so1 + so2;
            else if (radTru.Checked) kq = so1 - so2;
            else if (radNhan.Checked) kq = so1 * so2;
            else if (radChia.Checked)
            {
                if (so2 == 0)
                {
                    MessageBox.Show("Số chia phải là một số khác không. Vui lòng nhập lại", "Số chia khác không", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtSo2.Clear();
                    txtSo2.Focus();
                    return;
                } 
                else
                    kq = so1 / so2; 
            }
            //Hiển thị kết quả lên trên ô kết quả
            txtKq.Text = kq.ToString();
        }

        private void txtSo1_Leave(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá trị đầu vào cho num1 phải là số. Vui lòng nhập lại", "Lỗi định dạng", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSo1.Clear();
                txtSo1.Focus();
                return;
            }
        }

        private void txtSo2_Leave(object sender, EventArgs e)
        {
            try
            {
                double so2 = double.Parse(txtSo2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá trị đầu vào cho num2 phải là số. Vui lòng nhập lại", "Lỗi định dạng",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSo2.Clear();
                txtSo2.Focus();
                return;
            }
        }
        private void txtSo1_Focus(object sender, EventArgs e)
        {
            txtSo1.Clear();
        }
        private void txtSo2_Focus(object sender, EventArgs e)
        {
            txtSo2.Clear();
        }
    }
}
