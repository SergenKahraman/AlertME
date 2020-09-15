using System;
using System.Windows.Forms;

namespace AlertME.App
{
    public partial class frmDisplayAlarmProperties : Form   //Alarmların bilgilerinin gösterildiği ve değiştirildiği arayüz
    {
        public Alarms alarm1;
        public bool flagOfSaveButtonClicked = false;
        public frmDisplayAlarmProperties()
        {
            InitializeComponent();
        }



        //Methods For Events

        /// <summary>
        /// frmDisplayAlarmProperties_Load
        /// </summary>
        ///     . Bu form yüklendiğinde domainUpDown'ların İtem'leri atanır.
        ///     . frmReminding formundan aldığımız alarm bilgisini alarm1 field'ında tutar ve
        ///         bunu ekrandaki uygun componentlere yazar
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDisplayAlarmProperties_Load(object sender, EventArgs e)
        {
            for (int i = 23; i > -1; i--)
            {
                if (i < 10)
                {
                    dudHoursChange.Items.Add($"0{i}");

                }
                else
                {
                    dudHoursChange.Items.Add($"{i}");
                }

            }
            for (int i = 59; i > -1; i--)
            {
                if (i < 10)
                {
                    dudMunitesChange.Items.Add($"0{i}");

                }
                else
                {
                    dudMunitesChange.Items.Add($"{i}");
                }

            }
            var count1 = dudHoursChange.Items.Count - 1;
            var count2 = dudMunitesChange.Items.Count - 1;
            txtNameChange.Text = alarm1.Name;
            txtMessageChange.Text = alarm1.MessageInTxt;
            dtpDateChange.Value = alarm1.date;
            dudHoursChange.SelectedItem = dudHoursChange.Items[count1 - alarm1.Hours];
            dudMunitesChange.SelectedItem = dudMunitesChange.Items[count2 - alarm1.Munites];
        }

        /// <summary>
        /// btnSave_Click
        /// </summary>
        ///     . Kaydet butonuna basıldığında değişiklikleri kaydetmek amacıyla yeni bir alarm oluşturulur
        ///     . ve form kapatılır.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                alarm1 = new Alarms(dtpDateChange.Value.Year, dtpDateChange.Value.Month, dtpDateChange.Value.Day, Convert.ToInt32(dudHoursChange.SelectedItem), Convert.ToInt32(dudMunitesChange.SelectedItem), txtMessageChange.Text, txtNameChange.Text);
                flagOfSaveButtonClicked = true;
            }
            catch
            {
                erpWarningFrmChange.SetError(dudMunitesChange, "Daha ileri bir tarih giriniz!");
                return;
             
            }
            
            this.Close();
        }

        /// <summary>
        /// dudMunitesChange_Leave
        /// </summary>
        ///     . frmRiminding formunda kullandığımız leave eventine ait dudLeave fonksiyonunu çalıştıran ve
        ///         gene leave eventi sırasında tetiklenen bir method
        ///     . domainUpDownların içeriğini kontrol etmek için kullanıyoruz.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dudMunitesChange_Leave(object sender, EventArgs e)
        {
            var frmRmd = new frmReminding();
            frmRmd.dud_Leave(sender, e);
        }

        /// <summary>
        /// EnterOrClickADomainUpDown_forThisForm
        /// </summary>
        ///     . kullanıcı domainUpDownlara tıkladığında veya tab ile üstlerine geldiğinde
        ///         var olan textin seçili olmasını sağlar.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterOrClickADomainUpDown_forThisForm(object sender, EventArgs e)
        {
            var frmRmd = new frmReminding();
            frmRmd.EnterOrCLickADomainUpDown(sender, e);
        }
    }
}
