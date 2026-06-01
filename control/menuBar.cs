using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    public partial class menuBar : UserControl
    {
        public menuBar()
        {
            InitializeComponent();
            this.Resize += (s, e) => ReposionnerBoutons();
            this.Load += (s, e) => ReposionnerBoutons();
        }
        

        //merci stack overflow
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private void menuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.FindForm().Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void picMoins_Click(object sender, EventArgs e)
        {
            Form parent = this.FindForm();
            parent.WindowState = FormWindowState.Minimized;

        }

        private void picFermer_Click(object sender, EventArgs e)
        {
            Form parent = this.FindForm();
            parent.Close();
        }

        private void picFermer_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Size = new Size(pic.Size.Width +2, pic.Size.Height +2);
        }

        private void picFermer_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Size = new Size(pic.Size.Width -2, pic.Size.Height -2);

        }


        private void ReposionnerBoutons()
        {
            picFermer.Location = new Point(this.Width - 50, 3);
            picMoins.Location = new Point(this.Width - 108, 3);
        }
    }
}
