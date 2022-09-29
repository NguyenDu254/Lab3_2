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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblThem_Click(object sender, EventArgs e)
        {
            frmThemSV f = new frmThemSV();
            //f.Show();
            if (f.ShowDialog() == DialogResult.OK)//phải set Dialogresult = OK
            {
                try
                {
                    if (f.Ma == "" || f.Ten == "" || f.Diem == "" )
                        throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng!!");
                    else
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = (lvDs.Items.Count + 1).ToString();
                        lvDs.Items.Add(lvi);
                        ListViewItem.ListViewSubItem lvitems = new ListViewItem.ListViewSubItem(lvi, (f.Ma));
                        lvi.SubItems.Add(lvitems);
                        f.Ma = null;
                        lvitems = new ListViewItem.ListViewSubItem(lvi, (f.Ten));
                        lvi.SubItems.Add(lvitems);
                        f.Ten = null;
                        lvitems = new ListViewItem.ListViewSubItem(lvi, (f.Khoa));
                        lvi.SubItems.Add(lvitems);
                        f.Khoa = null;
                        lvitems = new ListViewItem.ListViewSubItem(lvi, (f.Diem));
                        lvi.SubItems.Add(lvitems);
                        f.Diem = null;
                    }
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    frmSV f = new frmSV();
        //    if(f.ShowDialog() == DialogResult.OK)
        //    {
        //        dataGridView1.
        //    }
        //}
    }
}
