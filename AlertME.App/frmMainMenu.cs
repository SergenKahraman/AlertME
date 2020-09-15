using System;
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
    }
}
