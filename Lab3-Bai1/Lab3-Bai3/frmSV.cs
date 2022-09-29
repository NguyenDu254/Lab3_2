using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai3
{
    public partial class frmThemSV : Form
    {
        public frmThemSV()
        {
            InitializeComponent();
        }

        public string Ma
        {
            get { return txtMssv.Text; }
            set { txtMssv.Text = value; }
        }
        public string Ten
        {
            get { return txtTen.Text; }
            set { txtTen.Text = value; }
        }
        public string Diem
        {
            get { return txtDiem.Text; }
            set { txtDiem.Text = value; }
        }

        public string Khoa
        {
            get { return cmbKhoa.Text; }
            set { cmbKhoa.Text = value; }
        }

        private void frmThemSV_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedIndex = 0;
        }
    }
}
