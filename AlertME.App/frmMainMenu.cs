using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlertME.App
{
    public partial class frmMainMenu : Form
    {
        public frmReminding frmRemindingHelper; // bu bizim arayüzümüz tek bir nesne olarak tutyoruzki sürekli yenilenip veri kaybı yaşamayalım diye
        public bool firstClick = true; // ilk menünün açılışı ve kapanışı için kullandığımız bir bayrak
        public frmMainMenu()
        {
            InitializeComponent();
            
        }

        private void btnReminding_Click(object sender, EventArgs e)
        {
            // menü ile hatırlatma arayüzü arasındaki köprüyü kuruyor ve böylece verileri program ayaktayken korumuş oluyoruz
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
