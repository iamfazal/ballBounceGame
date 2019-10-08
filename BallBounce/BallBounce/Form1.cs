using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallBounce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            setBlogs();
            
        }
         Random r = new Random(); Block racket, ball;
        int ballx = 210; int bally = 450; int dx = 3; int dy = 2;
        ArrayList blogList = new ArrayList();

       
        public void setBlogs()
        {
            Block blog;
            MessageBox.Show("" + r.Next(1, 8) + ".jpg");
            for (int j = 30; j <= 150; j += 50)
            {
                for (int i = 50; i < 200; i += 60)
                {
                    blog = new Block(i, j, r.Next(1, 8) + ".jpg");
                   
                    this.Controls.Add(blog);
                    blogList.Add(blog);

                }
            }
            for (int j = 30; j <= 150; j += 50)
            {
                for (int k = 300; k < 480; k += 60)
                {
                    blog = new Block(k, j, r.Next(1, 8) + ".jpg");
                    this.Controls.Add(blog);
                    blogList.Add(blog);
                }
            }
            for (int j = 200; j <= 300; j += 50)
            {
                for (int k = 180; k < 330; k += 60)
                {
                    blog = new Block(k, j, r.Next(1, 8) + ".jpg");
                    this.Controls.Add(blog);
                    blogList.Add(blog);
                }
            }

            ball = new Block(ballx, bally, "ball.png", 30, 30);
            this.Controls.Add(ball);
            racket = new Block(230, 490, "rac.png", 30, 107);
            this.Controls.Add(racket);

      }
       
        }
    }

