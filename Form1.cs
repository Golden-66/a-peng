using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int count = 0;//表示得分
        int time = 0;//时间
        
        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            label3.Text = "游戏时间：20";
            label4.Text = "游戏得分：0";
           
            label1.Text = "打地鼠";
            count = 0;
            time = 30;

        }
        private void invisiable()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[0];
            pictureBox3.Image = imageList1.Images[0];
            pictureBox4.Image = imageList1.Images[0];
            pictureBox5.Image = imageList1.Images[0];
            pictureBox6.Image = imageList1.Images[0];
            flag = 0;
        }
        private void delay(int k)
        {
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < k; j++) ;
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            delay(1000);
            Random rd = new Random();//Random.Next(Int) 返回一个小于所指定最大值的非负随机数
            int num = rd.Next(6);
            
            switch (num)
            { 
                case 0: invisiable(); pictureBox1.Visible = true; break;     
                case 1: invisiable(); pictureBox2.Visible = true; break;
                case 2: invisiable(); pictureBox3.Visible = true; break;
                case 3: invisiable(); pictureBox4.Visible = true; break;
                case 4: invisiable(); pictureBox5.Visible = true; break;
                case 5: invisiable(); pictureBox6.Visible = true; break;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = imageList1.Images[1];            
            if (flag == 0)
            {
                flag = 1;
                count++;
                label4.Text = "游戏得分： " + count;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (time == 0)
            {
                
                timer1.Enabled = false;
                invisiable();
                label1.Text = "游戏结束";
                button1.Visible = true;
                button1.Text = "再来一次";

            }
            else
            {
                time--;
                label3.Text = "游戏时间： " + time;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = imageList1.Images[1];
            if (flag == 0)
            {
                flag = 1;
                count++;
                label4.Text = "游戏得分： " + count;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = imageList1.Images[1];
            if (flag == 0)
            {
                flag = 1;
                count++;
                label4.Text = "游戏得分： " + count;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = imageList1.Images[1];
            if (flag == 0)
            {
                flag = 1;
                count++;
                label4.Text = "游戏得分： " + count;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = imageList1.Images[1];
            if (flag == 0)
            {
                flag = 1;
                count++;
                label4.Text = "游戏得分： " + count;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = imageList1.Images[1];
            if (flag == 0)
            {
                flag = 1;
                count++;
                label4.Text = "游戏得分： " + count;
            }
        }
    }
}//为使加载的图片自使用控件尺寸，可以分别对pictureBox控件设置BackGroundImageLayout=Stretch，SizeMode=StretchImage
//winform中picturebox自适应图片大小
//添加图片window窗体，lmagelist；
//添加From背景使用Backgroundlmge；
