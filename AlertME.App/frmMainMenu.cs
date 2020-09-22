using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlertME.App
{
    public partial class frmMainMenu : Form
    {
        public frmReminding frmRemindingHelper; 
        public bool firstClick = true; 
        public frmMainMenu()
        {
            InitializeComponent();
            
        }


        //Methods For Events

        /// <summary>
        /// btnReminding_Click
        /// </summary>
        ///     . öncelikle bu butona ilk defa tıklandıysa Hatırlatma kurma arayüzünü boş yapılandırıyor
        ///     . ardına anamenunun görünürlüğünü false çekiyor yani bu formu görünmez yapıyor
        ///     . ana menüden hatırlatma arayüzüne bilgi akışı sağlanıyor.
        ///     . Bu algoritmanın amacı ana menü ile hatırlatma arayüzünde veri kaybı olmadan gidip gelmek
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReminding_Click(object sender, EventArgs e)
        {
            
            if (firstClick)
            {
                frmRemindingHelper = new frmReminding();
                this.Visible = false;
                frmRemindingHelper.frmMain = this;
                firstClick = false;
                frmRemindingHelper.ShowDialog();
            }
            else
            {
                this.Visible = false;
                frmRemindingHelper.ShowDialog();
            }

        }

        private void btnReminding_MouseEnter(object sender, EventArgs e)
        {
            pnlButtonReminding.BackColor = Color.FromArgb(245, 248, 177, 149);
        }

        private void btnReminding_MouseLeave(object sender, EventArgs e)
        {
            pnlButtonReminding.BackColor = Color.FromArgb(0,0,0);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(245 ,255, 94, 63);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(0,0,0);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(245, 201, 70, 61);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(0,0,0);
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(245, 150, 46, 64);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ctxButtonOpen_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ctxButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
            }   
        }
    }
}
