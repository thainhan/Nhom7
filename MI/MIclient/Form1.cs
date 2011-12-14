using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
namespace MIclient
{
    using MiService;
    using DevExpress.Utils;
    using System.Drawing.Drawing2D;
    public partial class Form1 : Form
    {
      MiServiceClient client = new MiServiceClient();
      
        public Form1()
        {
            InitializeComponent();
            this.tbTimkiem.Click+=new EventHandler(this.tbTimkiem_Click);
            this.Click+=new EventHandler(this.Form1_Click);
           
        }
        public void doiten()
        {
            layoutView1.Columns["aTitle"].Caption = "Tên Bài";
            layoutView1.Columns["cSinger"].Caption = "Ca Sĩ";
            layoutView1.Columns["Id"].Visible = false;
            layoutView1.Columns["Instrument"].Caption = "Nhạc Cụ";
            layoutView1.Columns["Lang"].Caption = "Quốc Gia";
            layoutView1.Columns["eGenre"].Caption = "Thể Loại";
            layoutView1.Columns["dPublish"].Caption = "Phát Hành";
            layoutView1.Columns["bAuthor"].Caption = "Nhạc Sĩ";
            layoutView1.Columns["aTitle"].Caption = "Tiêu Đề";
            layoutView1.Columns["vote"].Caption = "Vote";
            gridView1.Columns["cSinger"].Caption = "Ca Sĩ";

            layoutView2.Columns["aSingername"].Caption = "Nghệ Danh";
            layoutView2.Columns["cSingerday"].Caption = "Ngày Sinh";
            layoutView2.Columns["eSingercom"].Caption = "Công Ty Đại Diện";
            layoutView2.Columns["dCountry"].Caption = "Quốc Tịch";
            layoutView2.Columns["bSingerreal"].Caption = "Tên Thật";
            layoutView2.Columns["fSingeravatar"].Visible = false;
            layoutView2.Columns["cSingerday"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            gridControl2.DataSource = client.getall();
            gridControl1.DataSource = gridControl2.DataSource;
            gridControl3.DataSource = client.Getsinger(gridView1.GetFocusedRowCellValue("cSinger").ToString());
            gridView1.Columns["Id"].Visible = false;
            gridView1.Columns["Instrument"].Visible = false;
            gridView1.Columns["Lang"].Visible = false;
            gridView1.Columns["Lyric"].Visible = false;
            gridView1.Columns["eGenre"].Visible = false;
            gridView1.Columns["dPublish"].Visible = false;
            gridView1.Columns["Karaoke"].Visible = false;
            gridView1.Columns["Emotion"].Visible = false;
            gridView1.Columns["bAuthor"].Visible = false;
            gridView1.Columns["vote"].Visible = false;
            gridView1.Columns["avatar"].Visible = false;
            gridView1.Columns["aTitle"].Caption = "Tên Bài Hát";
            gridView1.Columns["cSinger"].Caption = "Ca Sĩ";
            gridView1.Columns["aTitle"].VisibleIndex = 0;

            layoutView1.Columns["Lyric"].Visible = false;
            layoutView1.Columns["avatar"].Visible = false;
            layoutView1.Columns["vote"].Visible = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            doiten();
        }
        public delegate void lyricdata(TextBox text);
        public delegate void titledata(TextBox text);


        private void tbTimkiem_Click(object sender, EventArgs e)
        {
            
            tbTimkiem.Clear();
            tbTimkiem.ForeColor = Color.Black;
        
        }
        private void tbTimkiem_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, EventArgs e)
        { gridControl2.DataSource = client.getall(); }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                string lt = "", tg = "", qg = "", tt = "";
                try
                {
                    lt = loctheo.Text;
                    tg = thoigian.Text;
                    qg = quocgia.Text;
                    tt = tamtrang.Text;

                }
                catch { }
                MiServiceClient client = new MiServiceClient();
                if (karaoke.Checked==true)
                {
                    try
                    {
                        gridControl2.DataSource = client.musickaraoke(tbTimkiem.Text, lt, tg, qg, tt);
                    }
                    catch { gridControl2.DataSource = client.getall(); }
                }
                if (ten.Checked==true)
                {
                    try
                    {
                        gridControl2.DataSource = client.musicten(tbTimkiem.Text, lt, tg, qg, tt);
                    }
                    catch { gridControl2.DataSource = client.getall(); }
                }
                if (loi.Checked==true)
                {
                    try
                    {
                        gridControl2.DataSource = client.musicloi(tbTimkiem.Text, lt, tg, qg, tt);
                    }
                    catch { gridControl2.DataSource = client.getall(); }
                }
                if (casi.Checked==true)
                {
                    try
                    {
                        gridControl2.DataSource = client.musiccasi(tbTimkiem.Text, lt, tg, qg, tt);
                    }
                    catch { gridControl2.DataSource = client.getall(); }
                }
                if (nhacsi.Checked == true)
                {
                    try
                    {
                        gridControl2.DataSource = client.musicnhacsi(tbTimkiem.Text, lt, tg, qg, tt);
                    }
                    catch { gridControl2.DataSource = client.getall(); }
                }
                gridControl1.DataSource = gridControl2.DataSource;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {   
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = gridView1.GetFocusedRowCellValue("aTitle").ToString();
            try
            {   gridControl3.DataSource = client.Getsinger(gridView1.GetFocusedRowCellValue("cSinger").ToString());
            
            pictureBox2.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + layoutView2.GetFocusedRowCellValue("fSingeravatar").ToString();
            
                gridView1.GetFocusedRowCellValue("Lyric").ToString();
                textBox1.Text += gridView1.GetFocusedRowCellValue("Lyric").ToString();
            }
            catch
            {
                textBox1.Text = "Bài Hát Này Chưa Có Lời";
            }
            
        }

        private void tamtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = client.Getemotion(tamtrang.SelectedItem.ToString()).Substring
                    (12, client.Getemotion(tamtrang.SelectedItem.ToString()).Length - 13);
            }
            catch { }

        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Lyric ly = new Lyric();

                lyricdata a = new lyricdata(ly.getly);
                titledata b = new titledata(ly.getti);

                a(this.textBox1);
                b(this.textBox2);
                ly.Show();
            }
            catch { }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {   int sao=0;
        try
        {
            if (comboBox1.SelectedIndex == 0)
            {
                sao = 5;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                sao = 4;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                sao = 3;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                sao = 2;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                sao = 1;
            }
            client.setvote(Int16.Parse(gridView1.GetFocusedRowCellValue("Id").ToString()), sao);
            MessageBox.Show("Bạn Đã Vote: " + sao + " sao");
        }
        catch { }
        }

        private void xtraTabControl1_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
              dataGridView1.DataSource = client.gettop();
            try
            {
                pictureBox3.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[0].Cells[7].Value;
                p2.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[1].Cells[7].Value;
                p3.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[2].Cells[7].Value;
                p4.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[3].Cells[7].Value;
                p5.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[4].Cells[7].Value;
                p6.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[5].Cells[7].Value;
                p7.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[6].Cells[7].Value;
                p8.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[7].Cells[7].Value;
                p9.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[8].Cells[7].Value;
                p10.ImageLocation = Application.StartupPath.Substring(0, Application.StartupPath.Length - 19) + @"\MI\Images\" + dataGridView1.Rows[9].Cells[7].Value;
                
                textBox4.Text = dataGridView1.Rows[0].Cells[6].Value.ToString() +"- Ca Sĩ:"+ dataGridView1.Rows[0].Cells[9].Value.ToString();
                label1.Text = dataGridView1.Rows[0].Cells[12].Value.ToString();
                tb2.Text = dataGridView1.Rows[1].Cells[6].Value.ToString() + "- Ca Sĩ:" + dataGridView1.Rows[1].Cells[9].Value.ToString();
                tb3.Text ="3.\n"+ dataGridView1.Rows[2].Cells[6].Value.ToString() + "- Ca Sĩ:" + dataGridView1.Rows[2].Cells[9].Value.ToString();
                tb4.Text ="4.\n"+ dataGridView1.Rows[3].Cells[6].Value.ToString() + "- Ca Sĩ:" + dataGridView1.Rows[3].Cells[9].Value.ToString();
                tb5.Text ="5.\n"+ dataGridView1.Rows[4].Cells[6].Value.ToString() + "- Ca Sĩ:" + dataGridView1.Rows[4].Cells[9].Value.ToString();
                tb6.Text ="6.\n"+ dataGridView1.Rows[5].Cells[6].Value.ToString() + "- Ca Sĩ:" + dataGridView1.Rows[5].Cells[9].Value.ToString();
                tb7.Text ="7.\n"+ dataGridView1.Rows[6].Cells[6].Value.ToString() + "- Ca Sĩ:" + dataGridView1.Rows[6].Cells[9].Value.ToString();
                tb8.Text = "8.\n" + dataGridView1.Rows[7].Cells[6].Value.ToString() + "- Ca Sĩ:" + dataGridView1.Rows[7].Cells[9].Value.ToString();
                tb9.Text = "9.\n" + dataGridView1.Rows[8].Cells[6].Value.ToString() + "- Ca Sĩ:" + dataGridView1.Rows[8].Cells[9].Value.ToString();
                tb10.Text = "10.\n" + dataGridView1.Rows[9].Cells[6].Value.ToString() + "- Ca Sĩ:" + dataGridView1.Rows[9].Cells[9].Value.ToString();
                
            }
            catch
            {}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = client.getall();
            gridControl1.DataSource = gridControl2.DataSource;
        }

       
    }
}
