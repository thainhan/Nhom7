using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MIclient
{
    public partial class Lyric : Form
    {
        int current = 0;
        static int firstTime = 0;
        static string destination = "";
        public Lyric()
        {
            InitializeComponent();
        }

        private void Lyric_Load(object sender, EventArgs e)
        {
            this.textBox1.SelectionStart = 0;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void save()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = "D:";
                save.ShowHelp = true;
                save.RestoreDirectory = true;
                save.Title = "Save Notepad file";
                save.Filter = "Text Document (*.txt)|*.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter write = new StreamWriter(save.FileName, true))
                    {
                        write.Write(textBox1.Text);
                    }
                }
                destination = save.FileName;
                changeName(destination);
            }
            catch { }
        }

        public void changeName(string path)
        {
            try
            {
                char[] fileName;
                fileName = path.ToCharArray();
                path = "";
                for (int i = fileName.Length - 1; i >= 0; i--)
                {
                    if (fileName[i] == '\\')
                    {
                        for (int j = i + 1; j < fileName.Length; j++)
                        {
                            path += fileName[j];
                        }
                        break;
                    }
                }
                this.Text = path;
            }
            catch { }
        }

        public void wantToSave()
        {
            try
            {
                DialogResult saveVar;
                saveVar = MessageBox.Show("Bạn Muốn Save Không ?", "Lưu", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Yes == saveVar)
                {
                    save();
                    textBox1.Text = "";
                    this.Text = "";
                    current = 0;
                    this.Visible = false;
                }
                if (DialogResult.No == saveVar)
                {
                    textBox1.Text = "";
                    this.Text = "";
                    current = 0;
                    this.Visible = false;
                }
            }
            catch { }
        }

        

        public void getly(TextBox txtForm1)
        {
            textBox1.Text = txtForm1.Text;
        }
        public void getti(TextBox txtForm1)
        {
            this.Text ="Lời Bài Hát - "+ txtForm1.Text;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult saveVar;
                saveVar = MessageBox.Show("Bạn Muốn Save Không ?", "Lưu", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Yes == saveVar)
                {
                    save();
                    textBox1.Text = "";
                    this.Text = "";
                    current = 0;
                    Lyric ly = new Lyric();
                    ly.Show();
                    this.Visible = false;
                }
                if (DialogResult.No == saveVar)
                {
                    textBox1.Text = "";
                    this.Text = "";
                    current = 0;
                    Lyric ly = new Lyric();
                    ly.Show();
                    this.Visible = false;
                }
            }
            catch { }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();

                open.InitialDirectory = "C:";
                open.Multiselect = true;
                open.RestoreDirectory = true;
                open.Title = "Open Notepad file";
                open.Filter = "Text Document (*.txt)|*.txt";
                if (open.ShowDialog() == DialogResult.Cancel)
                {
                    string path = open.FileName;
                    changeName(path);
                    //exit();
                }
                else
                {
                    using (StreamReader read = new StreamReader(open.FileName, false))
                    {
                        textBox1.Text = read.ReadToEnd();
                    }
                }
                timer1.Enabled = true;
            }
            catch { }
        }

       
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch { }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstTime == 0)
                {
                    save();
                }
                else
                {
                    using (StreamWriter write = new StreamWriter(destination, true))
                    {
                        write.Write(textBox1.Text);
                    }
                }
                firstTime++;
            }
            catch { }
        }


    }
}
