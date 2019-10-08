using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallBounce
{
    class Block :Label
    {
        Image pic;
        
        public Block(int x , int y , string name="" , int h=30 , int w=50)
        {
          
            this.Left=x;
            this.Top = y;
            this.Width = w;
            this.Height = h;
            pic= Image.FromFile(name+".jpg");
          

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
                                        }
    }
   
}
