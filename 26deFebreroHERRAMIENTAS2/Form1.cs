using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26deFebreroHERRAMIENTAS2
{
    public partial class Form1 : Form
    {
        int x = 100;
        int y = 100;
        int velocidadX = 10;
        int velocidadY = 10;

        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            TIMER_UNO.Tick += new EventHandler(TIMER_UNO_Tick);
            TIMER_UNO.Enabled = false;
        }
        private void TIMER_UNO_Tick(object sender, EventArgs e)
        {
            x += velocidadX;
            y += velocidadY;
            Pelota.Location = new Point(x, y);
            if (y <= 0 || y >= this.ClientSize.Height - Pelota.Height)
            {
                velocidadY *= -1;
            }
            if (x <= 0)
            {
                velocidadX *= -1;
            }
            if (Pelota.Bounds.IntersectsWith(Raqueta.Bounds))
            {
                velocidadX *= -1;
                x = Raqueta.Left - Pelota.Width;
            }
            if (x >= this.ClientSize.Width - Pelota.Width)
            {
                TIMER_UNO.Enabled = false;
                MessageBox.Show("PERDISTE");
                ReiniciarJuego();
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int nuevaX = e.X - (Raqueta.Width / 2);
            int nuevaY = e.Y - (Raqueta.Height / 2);

            if (nuevaX < 0)
            {
                nuevaX = 0;
            }
            if (nuevaX > this.ClientSize.Width - Raqueta.Width)
            {
                nuevaX = this.ClientSize.Width - Raqueta.Width;
            }
            if (nuevaY < 0)
            {
                nuevaY = 0;
            }
            if (nuevaY > this.ClientSize.Height - Raqueta.Height)
            {
                nuevaY = this.ClientSize.Height - Raqueta.Height;
            }
            Raqueta.Location = new Point(nuevaX, nuevaY);
        }
        private void ReiniciarJuego()
        {
            x = 100;
            y = 100;
            Pelota.Location = new Point(x, y);
            velocidadX = 10;
            velocidadY = 10;
        }
        private void BTN_DESPLAZAR_Click(object sender, EventArgs e)
        {
            TIMER_UNO.Enabled = true;
            ReiniciarJuego();
        }
    }
}
