using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai2
{
    public partial class Form1 : Form
    {
      //  MemoryStream Input = new MemoryStream();
        public Form1()
        {
            InitializeComponent();
        }
        private string fileOpen = "";
        private string fontName = "Tahoma";
        private float fontSize = 14f;
        private FontStyle fontStyle = FontStyle.Regular;

        private void btnDinhDang_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDlg.Color;
                richTextBox1.Font = fontDlg.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbFonts.Items.Add(font.Name);
            }
            for (int i = 8; i <= 72; i += 2)
            {
                cmbSize.Items.Add(i);
            }
            //cmbFonts.SelectedIndex = 234;
            //cmbSize.SelectedIndex = 3;
            //richTextBox1.SelectionFont = new Font("Tahoma", 14);
            cmbFonts.Text = fontName;
            cmbSize.Text = fontSize.ToString(); 
            richTextBox1.Font = new Font(fontName, fontSize, fontStyle);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialog opentext = new OpenFileDialog();
            //if (opentext.ShowDialog() == DialogResult.OK)
            //{
            //    System.IO.StreamReader sr = new System.IO.StreamReader(opentext.FileName);
            //    richTextBox1.Text = sr.ReadToEnd();
            //    sr.Close();
            //}
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF File|*.rtf|TXT File|*.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileOpen = openFileDialog.FileName;
                richTextBox1.LoadFile(fileOpen);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //this.richTextBox1.Clear();
            //cmbFonts.SelectedIndex = 234;
            //cmbSize.SelectedIndex = 3;
            //richTextBox1.SelectionFont = new Font("Tahoma", 14);
            fontName = "Tahoma";
            fontSize = 14f;
            fontStyle = FontStyle.Regular;
            richTextBox1.Text = "";
            cmbFonts.Text = fontName;
            cmbSize.Text = fontSize.ToString();
            richTextBox1.Font = new Font (fontName, fontSize, fontStyle);
        }

        private void btnNewIcon_Click(object sender, EventArgs e)
        {
            fontName = "Tahoma";
            fontSize = 14f;
            fontStyle = FontStyle.Regular;
            richTextBox1.Text = "";
            cmbFonts.Text = fontName;
            cmbSize.Text = fontSize.ToString();
            richTextBox1.Font = new Font(fontName, fontSize, fontStyle);
        }

        private void btnSaveIcon_Click(object sender, EventArgs e)
        {
            //SaveFileDialog savefile = new SaveFileDialog();
            //savefile.DefaultExt = "*.doc";
            //savefile.Filter = "DOC Files|*.doc";
            //if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            //   savefile.FileName.Length > 0)
            //{
            //    richTextBox1.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
            //    MessageBox.Show("Lưu thành công", "Địa chỉ File : " + savefile.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            if(fileOpen == "")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileOpen = openFileDialog.FileName;
                    richTextBox1.SaveFile(fileOpen);
                }
            }
            else
            {
                richTextBox1.SaveFile(fileOpen);
                MessageBox.Show("Lưu Thành Công");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SaveFileDialog savefile = new SaveFileDialog();
            //savefile.DefaultExt = "*.doc";
            //savefile.Filter = "DOC Files|*.doc";
            //if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            //   savefile.FileName.Length > 0)
            //{
            //    richTextBox1.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
            //    MessageBox.Show("Lưu thành công", "Địa chỉ File : " + savefile.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            if (fileOpen == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileOpen = saveFileDialog.FileName;
                    richTextBox1.SaveFile(fileOpen);
                }
            }
            else
            {
                richTextBox1.SaveFile(fileOpen);
                MessageBox.Show("Lưu Thành Công");
            }
        }

            private void btnBold_Click(object sender, EventArgs e)
        {
            Font seletedFont = richTextBox1.SelectionFont;
            if(seletedFont != null)
            {
                richTextBox1.SelectionFont = new Font(seletedFont, seletedFont.Style ^ FontStyle.Bold);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            Font seletedFont = richTextBox1.SelectionFont;
            if (seletedFont != null)
            {
                richTextBox1.SelectionFont = new Font(seletedFont, seletedFont.Style ^ FontStyle.Italic);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Font seletedFont = richTextBox1.SelectionFont;
            if (seletedFont != null)
            {
                richTextBox1.SelectionFont = new Font(seletedFont, seletedFont.Style ^ FontStyle.Underline);
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSize.Text!= "")
              richTextBox1.SelectionFont = new Font(cmbFonts.Text, float.Parse(cmbSize.Text));
        }
    }
}

