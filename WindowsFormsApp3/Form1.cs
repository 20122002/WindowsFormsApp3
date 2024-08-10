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
    public partial class Form1 : Form
    {
        private FormNhanVien formNhanVien;
        public Form1()
        {
            InitializeComponent();
            formNhanVien = new FormNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            formNhanVien.ShowDialog();
            if (formNhanVien.DialogResult == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(formNhanVien.MSNV);
                item.SubItems.Add(formNhanVien.TenNhanVien);
                item.SubItems.Add(formNhanVien.LuongCoBan);
                listViewNhanVien.Items.Add(item);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewNhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn một nhân viên để sửa.");
                return;
            }

            var selectedItem = listViewNhanVien.SelectedItems[0];
            formNhanVien.MSNV = selectedItem.SubItems[0].Text;
            formNhanVien.TenNhanVien = selectedItem.SubItems[1].Text;
            formNhanVien.LuongCoBan = selectedItem.SubItems[2].Text;

            formNhanVien.ShowDialog();
            if (formNhanVien.DialogResult == DialogResult.OK)
            {
                selectedItem.SubItems[0].Text = formNhanVien.MSNV;
                selectedItem.SubItems[1].Text = formNhanVien.TenNhanVien;
                selectedItem.SubItems[2].Text = formNhanVien.LuongCoBan;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listViewNhanVien.SelectedItems.Count > 0)
            {
                listViewNhanVien.Items.Remove(listViewNhanVien.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chọn một nhân viên để xóa.");
            }
        }
    }
}
