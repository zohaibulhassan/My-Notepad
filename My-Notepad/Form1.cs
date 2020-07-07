using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "open  document";
            open.Filter = " text document(*.txt)|*.txt|All Files(.)| . ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save  document";
            save.Filter = " text document(*.txt)|*.txt|All Files(.)| . ";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

            FontDialog f = new FontDialog();
            f.Font = richTextBox1.SelectionFont;
            if (f.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = f.Font;

            }

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

            ColorDialog c = new ColorDialog();
            c.Color = richTextBox1.SelectionColor;
            if (c.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = c.Color;

            }

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "open  document";
            open.Filter = " text document(*.txt)|*.txt|All Files(.)| . ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save  document";
            save.Filter = " text document(*.txt)|*.txt|All Files(.)| . ";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string[] words = pictureBox12.Text.Split(',');
            foreach (string word in words)
            {
                int startindex = 0;
                while (startindex < richTextBox2.TextLength)
                {
                    int wordstartIndex = richTextBox2.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        richTextBox1.SelectionStart = wordstartIndex;
                        richTextBox1.SelectionLength = word.Length;
                        richTextBox1.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;
                    startindex += wordstartIndex + word.Length;
                }
            }
        }
    }
}
