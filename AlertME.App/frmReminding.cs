using System;
using System.Linq;
using System.Windows.Forms;

namespace AlertME.App
{// deneme 123
    public partial class frmReminding : Form //alarm kurulduğu ve yönetildiği arayüz
    {
        public Alarms[] alarms;
        public frmMainMenu frmMain = new frmMainMenu(); //ana menüden bilgi akışı sağlıyor

        public frmReminding()
        {
            InitializeComponent();
        }


        //Methods For Events

        /// <summary>
        /// frmReminding_Load
        /// </summary>
        /// 
        ///     . Bu event Method'u form yüklendiğinde önce domainUpDown componentlerinin
        ///         itemlerini atar.
        ///     . Refresh() methodunu çağırır ve formu temizler.
        ///         
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>            
        private void frmReminding_Load(object sender, EventArgs e)
        {
            
            for (int i = 23; i > -1; i--)
            {
                if (i < 10)
                {
                    dudHours.Items.Add($"0{i}");
                    
                }
                else
                {
                    dudHours.Items.Add($"{i}");
                }
                
            }
            for (int i = 59; i > -1; i--)
            {
                if (i < 10)
                {
                    dudMunites.Items.Add($"0{i}");

                }
                else
                {
                    dudMunites.Items.Add($"{i}");
                }

            }

            
            RefreshAll();




        }

        /// <summary>
        /// btnCreate_Click
        /// </summary>
        ///     . Kur butonuna basıldığında öncelikle hatırlatma isminin girildiği
        ///         txtAddName textBox'ını kontrol eder(isimsiz hatırlatma kurulamaz)
        ///     . Alarm sınıfından yeni bir nesne tanımlar
        ///     . Alarmın timer'ının Tick eventine tmr_tick methodunu atar
        ///     . en sonr refresh() methodu çağırılır ve herşey temizlenir
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            erpWarning.Clear();
            if (txtAddName.Text == "")
            {
                erpWarning.SetError(txtAddName, "Bu Alan Boş Bırakılamaz");
                return;
            }
            
           
            try
            {
                var Alarm = new Alarms(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, Convert.ToInt32(dudHours.SelectedItem), Convert.ToInt32(dudMunites.SelectedItem), txtMesssage.Text, txtAddName.Text);
                Alarm.tmr1.Tick += tmr_Tick;
                lstAktive.Items.Add(Alarm);
            }
            catch
            {
                erpWarning.SetError(dudMunites, "Lütfen ileri zaman tarih giriniz!!!");
                dudHours.Focus();
                return;
            }

            RefreshAll();

           
        }

        /// <summary>
        /// btnDisable_Click
        /// </summary>
        ///     . eğer lstActive listBox'ında bir item seçiliyse
        ///         o alarmı kaldırır lstPassive atar ve timer'ını durdurur
        ///     . bir alarmı pasif yapmak için yazılmıştır.
        ///        
        ///     
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (lstAktive.SelectedItem != null)
            {
                var alarm = lstAktive.SelectedItem as Alarms;
                lstAktive.Items.Remove(alarm);
                lstPassive.Items.Add(alarm);
                alarm.tmr1.Stop();
            }
        }

        /// <summary>
        /// btnEnable_Click
        /// </summary>
        ///     . lstPassive listBox'ındaki seçili alarmı kaldırıp lstActive geri atar
        ///     . pasif olan bir alarm'ı tekrar aktifleştirmek için kullanıldı.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (lstPassive.SelectedItem != null)
            {
                var alarm = lstPassive.SelectedItem as Alarms;
                lstPassive.Items.Remove(alarm);
                lstAktive.Items.Add(alarm);
                alarm.tmr1.Interval = Convert.ToInt32((alarm.date - DateTime.Now).TotalMilliseconds);
                alarm.tmr1.Start();
            }
            
        }

        /// <summary>
        /// btnRemove_Click
        /// </summary>
        ///     . Herhangi bir listBox'taki seçili elemanı liteden kaldırıp 
        ///         timer'ını dispose eder.
        ///     . herhangi bir alarmı kaldırmak için kullanıldı
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstAktive.SelectedItem != null)
            {
                var alarm = lstAktive.SelectedItem as Alarms;
                alarm.tmr1.Dispose();
                lstAktive.Items.Remove(alarm);
            }
            else if (lstPassive.SelectedItem != null)
            {
                var alarm = lstPassive.SelectedItem as Alarms;
                alarm.tmr1.Dispose();
                lstPassive.Items.Remove(alarm);
            }
            else if (lstOldAlarms.SelectedItem != null)
            {
                var alarm = lstOldAlarms.SelectedItem as Alarms;
                alarm.tmr1.Dispose();
                lstOldAlarms.Items.Remove(alarm);                
            }
        }

        /// <summary>
        /// lstAktive_Click
        /// </summary>
        ///     . lstActive listBox'ına tıklandığında 
        ///         diğer listBox'larda seçili bir itemin kalmaması için kullanıldı
        ///     
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstAktive_Click(object sender, EventArgs e)
        {
            lstPassive.SelectedIndex = -1;
            lstOldAlarms.SelectedIndex = -1;
        }

        /// <summary>
        /// lstPassive_Click
        /// </summary>
        ///     . lstPassive listBox'ına tıklandığında 
        ///         diğer listBox'larda seçili bir itemin kalmaması için kullanıldı
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPassive_Click(object sender, EventArgs e)
        {
            lstAktive.SelectedIndex = -1;
            lstOldAlarms.SelectedIndex = -1;
        }

        /// <summary>
        /// lstOLdAlarms_Click
        /// </summary>
        ///     . lstOldAlarms listBox'ına tıklandığında 
        ///         diğer listBox'larda seçili bir itemin kalmaması için kullanıldı
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstOldAlarms_Click(object sender, EventArgs e)
        {
            lstAktive.SelectedIndex = -1;
            lstPassive.SelectedIndex = -1;
        }

        /// <summary>
        /// tmr_Tick
        /// </summary>
        ///     . oluşan her timer için kullandığımız event methodudur.
        ///     . herhangi bir alarmın timer'ı tetiklendiğinde bu method çalışır ve
        ///         timer'ın enabled özelliği false'a çekilir.
        ///     . mesaj bastırılır.
        ///     . daha sonra lstActive listesini tarayıp timer'ı enabled özelliği false olanları
        ///         lstActive'den lstPassive'e taşıyoruz.
        ///     
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr_Tick(object sender, EventArgs e)
        {
            var tmr = sender as Timer;
            tmr.Enabled = false;
            MessageBox.Show(tmr.Tag.ToString(), "Hatırlatma!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            alarms = new Alarms[lstAktive.Items.Count];
            lstAktive.Items.CopyTo(alarms, 0);
            foreach (var item in alarms)
            {
                if (item.tmr1.Enabled == false)
                {
                    lstAktive.Items.Remove(item);
                    lstOldAlarms.Items.Add(item);
                }
            }
            
            
        }

        /// <summary>
        /// lstAktive_MouseDoubleClick
        /// </summary>
        ///     . lstActive listBox'ında bir alarm'a iki kere tıklandığında 
        ///         alarmın bilgilerini gözstermek için kullanıyoruz.
        ///     . Burada seçili alarmın bilgileri frmDisplayAlarmProperties sınıfına gönderiliyor
        ///     . eğer diğer formda değişiklik yapılıp veya yapılmayıp save butonuna basıldıysa
        ///         secili alarm kaldırılıp timer'ı dispose edilip yeni hali tekrar alarm olarak ekleniyor
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstAktive_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAktive.SelectedItem != null)
            {
                var selected = lstAktive.SelectedItem as Alarms;
                var frmChange = new frmDisplayAlarmProperties();
                frmChange.alarm1 = selected;
                frmChange.ShowDialog();
                if (frmChange.flagOfSaveButtonClicked)
                {
                    var index = lstAktive.Items.IndexOf(selected);
                    lstAktive.Items.RemoveAt(index);
                    selected.tmr1.Dispose();
                    frmChange.alarm1.tmr1.Tick += tmr_Tick;
                    lstAktive.Items.Insert(index, frmChange.alarm1);
                }
                
            }
            
        }

        /// <summary>
        /// lstOldAlarms_MouseDoubleClick
        /// </summary>
        ///     . lstOldAlarms listBox'ında bir alarm'a iki kere tıklandığında 
        ///         alarmın bilgilerini gözstermek için kullanıyoruz.
        ///     . Burada seçili alarmın bilgileri frmDisplayAlarmProperties sınıfına gönderiliyor
        ///     . eğer diğer formda değişiklik yapılıp veya yapılmayıp save butonuna basıldıysa
        ///         secili alarm kaldırılıp timer'ı dispose edilip yeni hali tekrar alarm olarak ekleniyor
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstOldAlarms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstOldAlarms.SelectedItem != null)
            {
                var selected = lstOldAlarms.SelectedItem as Alarms;
                var frmChange = new frmDisplayAlarmProperties();
                frmChange.alarm1 = selected;
                frmChange.ShowDialog();
                if (frmChange.flagOfSaveButtonClicked)
                {
                    var index = lstOldAlarms.Items.IndexOf(selected);
                    lstOldAlarms.Items.RemoveAt(index);
                    selected.tmr1.Dispose();
                    frmChange.alarm1.tmr1.Tick += tmr_Tick;
                    lstAktive.Items.Add(frmChange.alarm1);
                }
                
            }
        }

        /// <summary>
        /// lstPassive_MouseDoubleClick
        /// </summary>
        ///     . lstPassive listBox'ında bir alarm'a iki kere tıklandığında 
        ///         alarmın bilgilerini gözstermek için kullanıyoruz.
        ///     . Burada seçili alarmın bilgileri frmDisplayAlarmProperties sınıfına gönderiliyor
        ///     . eğer diğer formda değişiklik yapılıp veya yapılmayıp save butonuna basıldıysa
        ///         secili alarm kaldırılıp timer'ı dispose edilip yeni hali tekrar alarm olarak ekleniyor
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPassive_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstPassive.SelectedItem != null)
            {
                var selected = lstPassive.SelectedItem as Alarms;
                var frmChange = new frmDisplayAlarmProperties();
                frmChange.alarm1 = selected;
                frmChange.ShowDialog();
                if (frmChange.flagOfSaveButtonClicked)
                {
                    var index = lstPassive.Items.IndexOf(selected);
                    lstPassive.Items.RemoveAt(index);
                    selected.tmr1.Dispose();
                    frmChange.alarm1.tmr1.Tick += tmr_Tick;
                    lstAktive.Items.Add(frmChange.alarm1);
                }

            }
        }
 
        /// <summary>
        /// dud_Leave
        /// </summary>
        ///     . bu event methodunu bütün domainUpDownlar için kullanıyoruz
        ///     . bu method domainUpDownlardan ayrıldığımızada çalışmak üzere tasarlandı
        ///     . domainUpDownların text kutucuğuna elimizle bir sayı girdiğimizde girilen sayıyı yönetmek amaçlı yapılmıştır
        ///     
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dud_Leave(object sender, EventArgs e)
        {
            var dud = sender as DomainUpDown;
            try
            {
                if (Convert.ToInt32(dud.Text) > dud.Items.Count-1)
                {
                    dud.SelectedIndex = 0;
                }
                else if (Convert.ToInt32(dud.Text) < 0)
                {
                    dud.SelectedIndex = dud.Items.Count - 1;
                }
            }
            catch
            {
                dud.SelectedIndex = 0;
            }
            foreach (var item in dud.Items)
            {
                if (item.ToString() == dud.Text)
                {
                    dud.SelectedIndex = dud.Items.Count - 1 - Convert.ToInt32(dud.Text);
                }
            }
        }

        /// <summary>
        /// frmReminding_FormClosing
        /// </summary>
        ///     . içinde bulunduğumuz form kapanırken ana menünün açılması için kullanıyoruz
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReminding_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            frmMain.Visible = true;
        }

        /// <summary>
        /// EnterOrCLickADomainUpDown
        /// </summary>
        ///     . Bu method bütün domainUpDownlarda kullanılmak amaçlı oluşturulumuştur
        ///     . kullanıcı domainUpDownlara tıkladığında veya tab ile üstlerine geldiğinde
        ///         var olan textin seçili olmasını sağlar.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EnterOrCLickADomainUpDown(object sender, EventArgs e)
        {
            var domainUpDown = sender as DomainUpDown;
            domainUpDown.Select(0, domainUpDown.Text.Length);
        }
       



        // Methods For Other Purposes

        /// <summary>
        /// RefreshAll
        /// </summary>
        ///     . Formun üzerindeki controlleri istediğim düzeyde temizler
        private void RefreshAll()
        {
            txtAddName.Clear();
            txtMesssage.Clear();
            dtpDate.Value = DateTime.Now;
            dudHours.SelectedIndex = 0;
            dudMunites.SelectedIndex = 0;
            txtAddName.Focus();
        }

    }
}
