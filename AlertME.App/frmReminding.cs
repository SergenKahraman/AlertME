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
    public partial class frmReminding : Form
    {
        public string MessageTxt;
        public Alarms[] alarms;
        public frmMainMenu frmMain = new frmMainMenu();

        public frmReminding()
        {
            InitializeComponent();

        }

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



        private void RefreshAll()
        {
            txtAddName.Clear();
            txtMesssage.Clear();
            dtpDate.Value = DateTime.Now;
            dudHours.SelectedIndex = 0;
            dudMunites.SelectedIndex = 0;
            txtAddName.Focus();
        }

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

        private void lstAktive_Click(object sender, EventArgs e)
        {
            lstPassive.SelectedIndex = -1;
            lstOldAlarms.SelectedIndex = -1;
        }

        private void lstPassive_Click(object sender, EventArgs e)
        {
            lstAktive.SelectedIndex = -1;
            lstOldAlarms.SelectedIndex = -1;
        }

        private void lstOldAlarms_Click(object sender, EventArgs e)
        {
            lstAktive.SelectedIndex = -1;
            lstPassive.SelectedIndex = -1;
        }

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

        //// burası önemli  domainUpDownları yönetmek için genel bir kod yazdık ve bütün domainUpDownlarda kullanacağız      
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





        // burası menü ile arayüz arasındaki köprüyü kuruyor
        private void frmReminding_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Visible = false;
            frmMain.Visible = true;
        }
    }
}
