using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0628Project
{
    
    public partial class clickmouse : Form
    {
        static public string ooo;
        public int n;
        int timeLeft;
        string piclocation;
        public clickmouse()
        {
            InitializeComponent();
            label3.Text = "";
            pichide();
        }

        void picchange()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int randkey = r.Next(1,3);
            //pictureBox1.Image = Image.FromFile($@"D:\temp\bmp\project\{randkey}.png");
            //pictureBox2.Image = Image.FromFile($@"D:\temp\bmp\project\{randkey}.png");
            //pictureBox3.Image = Image.FromFile($@"D:\temp\bmp\project\{randkey}.png");
            //pictureBox4.Image = Image.FromFile($@"D:\temp\bmp\project\{randkey}.png");
            //pictureBox5.Image = Image.FromFile($@"D:\temp\bmp\project\{randkey}.png");
            //pictureBox6.Image = Image.FromFile($@"D:\temp\bmp\project\{randkey}.png");
            //pictureBox7.Image = Image.FromFile($@"D:\temp\bmp\project\{randkey}.png");
            //pictureBox8.Image = Image.FromFile($@"D:\temp\bmp\project\{randkey}.png");
            //pictureBox9.Image = Image.FromFile($@"D:\temp\bmp\project\{randkey}.png");
            //pictureBox1.ImageLocation = $@"D:\temp\bmp\project\{randkey}.png";
            //pictureBox2.ImageLocation = $@"D:\temp\bmp\project\{randkey}.png";
            //pictureBox3.ImageLocation = $@"D:\temp\bmp\project\{randkey}.png";
            //pictureBox4.ImageLocation = $@"D:\temp\bmp\project\{randkey}.png";
            //pictureBox5.ImageLocation = $@"D:\temp\bmp\project\{randkey}.png";
            //pictureBox6.ImageLocation = $@"D:\temp\bmp\project\{randkey}.png";
            //pictureBox7.ImageLocation = $@"D:\temp\bmp\project\{randkey}.png";
            //pictureBox8.ImageLocation = $@"D:\temp\bmp\project\{randkey}.png";
            //pictureBox9.ImageLocation = $@"D:\temp\bmp\project\{randkey}.png";
            piclocation = $@"D:\temp\bmp\project\{randkey}.png";
        }

        void pichide()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picchange();
            Random r = new Random(DateTime.Now.Millisecond);
            int randkey = r.Next(9);
            switch (randkey)
            {
                case 1:pictureBox1.ImageLocation = piclocation; pictureBox1.Visible = true; break;
                case 2:pictureBox2.ImageLocation = piclocation; pictureBox2.Visible = true; break;
                case 3:pictureBox3.ImageLocation = piclocation; pictureBox3.Visible = true; break;
                case 4:pictureBox4.ImageLocation = piclocation; pictureBox4.Visible = true; break;
                case 5:pictureBox5.ImageLocation = piclocation; pictureBox5.Visible = true; break;
                case 6:pictureBox6.ImageLocation = piclocation; pictureBox6.Visible = true; break;
                case 7:pictureBox7.ImageLocation = piclocation; pictureBox7.Visible = true; break;
                case 8:pictureBox8.ImageLocation = piclocation; pictureBox8.Visible = true; break;
                case 9:pictureBox9.ImageLocation = piclocation; pictureBox9.Visible = true; break;         
            }          
        }

        private void clickmouse_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap(@"D:\temp\bmp\project\project5.png");
            Cursor c = new Cursor(b.GetHicon());
            this.Cursor = c;
            int i = Convert.ToInt32((sender as PictureBox).Name.Substring(10, 1));
            switch(i)
            {
                case 1:
                    {   
                        int j = Convert.ToInt32(pictureBox1.ImageLocation.Substring(20,1));
                        if (j == 1)
                        {
                            n += 1;
                        }
                        else
                        {
                            n -= 1;
                        }
                        pictureBox1.Visible = false;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 2:
                    {
                        int j = Convert.ToInt32(pictureBox2.ImageLocation.Substring(20, 1));
                        if (j == 1)
                        {
                            n += 1;
                        }
                        else
                        {
                            n -= 1;
                        }
                        pictureBox2.Visible = false;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 3:
                    {
                        int j = Convert.ToInt32(pictureBox3.ImageLocation.Substring(20, 1));
                        if (j == 1)
                        {
                            n += 1;
                        }
                        else
                        {
                            n -= 1;
                        }
                        pictureBox3.Visible = false;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 4:
                    {
                        int j = Convert.ToInt32(pictureBox4.ImageLocation.Substring(20, 1));
                        if (j == 1)
                        {
                            n += 1;
                        }
                        else
                        {
                            n -= 1;
                        }
                        pictureBox4.Visible = false;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 5:
                    {
                        int j = Convert.ToInt32(pictureBox5.ImageLocation.Substring(20, 1));
                        if (j == 1)
                        {
                            n += 1;
                        }
                        else
                        {
                            n -= 1;
                        }
                        pictureBox5.Visible = false;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 6:
                    {
                        int j = Convert.ToInt32(pictureBox6.ImageLocation.Substring(20, 1));
                        if (j == 1)
                        {
                            n += 1;
                        }
                        else
                        {
                            n -= 1;
                        }
                        pictureBox6.Visible = false;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 7:
                    {
                        int j = Convert.ToInt32(pictureBox7.ImageLocation.Substring(20, 1));
                        if (j == 1)
                        {
                            n += 1;
                        }
                        else
                        {
                            n -= 1;
                        }
                        pictureBox7.Visible = false;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 8:
                    {
                        int j = Convert.ToInt32(pictureBox8.ImageLocation.Substring(20, 1));
                        if (j == 1)
                        {
                            n += 1;
                        }
                        else
                        {
                            n -= 1;
                        }
                        pictureBox8.Visible = false;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 9:
                    {
                        int j = Convert.ToInt32(pictureBox9.ImageLocation.Substring(20, 1));
                        if (j == 1)
                        {
                            n += 1;
                        }
                        else
                        {
                            n -= 1;
                        }
                        pictureBox9.Visible = false;
                        textBox1.Text = n.ToString();
                        break;
                    }
            }
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            n = 0;
            timeLeft = 5;
            Bitmap b = new Bitmap(@"D:\temp\bmp\project\project4.jpg");
            Cursor c = new Cursor(b.GetHicon());
            this.Cursor = c;
        }
        public string result;
        private void timer3_Tick(object sender, EventArgs e)
        {            
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                label1.Text = $"還剩 {timeLeft} 秒";
            }
            else
            {
                inputbox ipb = new inputbox();
                Bitmap b = new Bitmap(@"D:\temp\bmp\project\project4.jpg");
                Cursor c = new Cursor(b.GetHicon());
                this.Cursor = c;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                pichide();
                label1.Text = "Time's up";
                MessageBox.Show("遊戲結束!");
                ipb.ShowDialog();
                highscore();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }
        private void clickmouse_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap(@"D:\temp\bmp\project\project4.jpg");
            Cursor c = new Cursor(b.GetHicon());
            this.Cursor = c;
        }
        public void highscore()
        {
            if (this.label3.Text=="")
            {
                this.label3.Text = ooo;
                this.label5.Text = n.ToString();
            }
            else
            {
                
                int i = int.Parse(this.label5.Text.ToString());
                if ( i<n)
                {
                    MessageBox.Show("恭喜你獲得最高分!!!");
                    this.label3.Text = ooo;
                    this.label5.Text = n.ToString();
                }
            }
            this.listBox1.Items.Add($"姓名：{ooo} \n 分數：{n.ToString()}");
        }
    }
}
