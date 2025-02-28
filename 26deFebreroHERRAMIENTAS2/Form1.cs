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

        bool dir = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void TIMER_UNO_Tick(object sender, EventArgs e)
        {
            IMG1.Location = new Point(x, 20);
            if (dir)
            {
                x += 10;
            }
            else
            {
                x -= 10;
            }

            if (x >= this.Size.Width-IMG1.Width)
            {
                dir = false;
            }
            if (x <= 10)
            {
                dir = true;
            }
        }
        private void TMR_DESPLAZAR_Click(object sender, EventArgs e)
        {
            TIMER_UNO.Enabled = true;
            MessageBox.Show(this.IMG1.Size.Width.ToString());
        }
    }
}
