using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Notepad
{
    public partial class Form1 : Form
    {
        bool isBold;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")

                toolStripStatusLabel3.Text = "Status ";

            else

                toolStripStatusLabel3.Text = "Started typing...   ";
            string text = richTextBox1.Text;

            char[] separator = { ' ' };

            int wordcount = text.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;

            toolStripStatusLabel2.Text = wordcount.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Font.Bold == true)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12);
            }
            else { 
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12, FontStyle.Bold);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Italic == true)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12, FontStyle.Italic);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Underline == true)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12, FontStyle.Underline);
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|PDF file|*.pdfx`|Word File|*.doc";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void exittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
