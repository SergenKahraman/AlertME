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
    public partial class frmDisplayAlarmProperties : Form
    {
        public Alarms alarm1;
        public bool flagOfSaveButtonClicked = false;
        public frmDisplayAlarmProperties()
        {
            InitializeComponent();
        }

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

        private void dudMunitesChange_Leave(object sender, EventArgs e)
        {
            var frmRmd = new frmReminding();
            frmRmd.dud_Leave(sender, e);
        }


        
    }
}
