using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public string MSNV
        {
            get { return txtMSNV.Text; }
            set { txtMSNV.Text = value; }
        }

        public string TenNhanVien
        {
            get { return txtTenNhanVien.Text; }
            set { txtTenNhanVien.Text = value; }
        }

        public string LuongCoBan
        {
            get { return txtLuongCoBan.Text; }
            set { txtLuongCoBan.Text = value; }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
