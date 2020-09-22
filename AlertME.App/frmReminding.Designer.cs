namespace AlertME.App
{
    partial class frmReminding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMesssage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dudHours = new System.Windows.Forms.DomainUpDown();
            this.dudMunites = new System.Windows.Forms.DomainUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lstPassive = new System.Windows.Forms.ListBox();
            this.lstOldAlarms = new System.Windows.Forms.ListBox();
            this.lstAktive = new System.Windows.Forms.ListBox();
            this.erpWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpWarning)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMesssage
            // 
            this.txtMesssage.Location = new System.Drawing.Point(11, 49);
            this.txtMesssage.MaxLength = 200;
            this.txtMesssage.Multiline = true;
            this.txtMesssage.Name = "txtMesssage";
            this.txtMesssage.Size = new System.Drawing.Size(305, 137);
            this.txtMesssage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hatırlatılmasını istediğiniz mesajı giriniz.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMesssage);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(41, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesaj";
            // 
            // dtpDate
            // 
            this.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDate.Location = new System.Drawing.Point(41, 355);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(329, 29);
            this.dtpDate.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(41, 449);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(329, 48);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "KUR";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dudHours
            // 
            this.dudHours.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dudHours.Location = new System.Drawing.Point(136, 400);
            this.dudHours.Name = "dudHours";
            this.dudHours.Size = new System.Drawing.Size(57, 33);
            this.dudHours.TabIndex = 3;
            this.dudHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dudHours.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dudHours.Wrap = true;
            this.dudHours.Click += new System.EventHandler(this.EnterOrCLickADomainUpDown);
            this.dudHours.Enter += new System.EventHandler(this.EnterOrCLickADomainUpDown);
            this.dudHours.Leave += new System.EventHandler(this.dud_Leave);
            // 
            // dudMunites
            // 
            this.dudMunites.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dudMunites.Location = new System.Drawing.Point(199, 400);
            this.dudMunites.Name = "dudMunites";
            this.dudMunites.Size = new System.Drawing.Size(57, 33);
            this.dudMunites.TabIndex = 4;
            this.dudMunites.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dudMunites.Wrap = true;
            this.dudMunites.Click += new System.EventHandler(this.EnterOrCLickADomainUpDown);
            this.dudMunites.Enter += new System.EventHandler(this.EnterOrCLickADomainUpDown);
            this.dudMunites.Leave += new System.EventHandler(this.dud_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnEnable);
            this.groupBox2.Controls.Add(this.btnDisable);
            this.groupBox2.Controls.Add(this.lstPassive);
            this.groupBox2.Controls.Add(this.lstOldAlarms);
            this.groupBox2.Controls.Add(this.lstAktive);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(407, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 519);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kurulmuş Hatırlatmalar";
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(456, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Kaldır";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.ForeColor = System.Drawing.Color.Black;
            this.btnEnable.Location = new System.Drawing.Point(206, 16);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(97, 28);
            this.btnEnable.TabIndex = 1;
            this.btnEnable.Text = "Aç";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.ForeColor = System.Drawing.Color.Black;
            this.btnDisable.Location = new System.Drawing.Point(331, 16);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(97, 28);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Kapat";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lstPassive
            // 
            this.lstPassive.ForeColor = System.Drawing.Color.DimGray;
            this.lstPassive.FormattingEnabled = true;
            this.lstPassive.ItemHeight = 21;
            this.lstPassive.Location = new System.Drawing.Point(396, 49);
            this.lstPassive.Name = "lstPassive";
            this.lstPassive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstPassive.Size = new System.Drawing.Size(355, 193);
            this.lstPassive.TabIndex = 0;
            this.lstPassive.Click += new System.EventHandler(this.lstPassive_Click);
            this.lstPassive.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPassive_MouseDoubleClick);
            // 
            // lstOldAlarms
            // 
            this.lstOldAlarms.BackColor = System.Drawing.SystemColors.Window;
            this.lstOldAlarms.ForeColor = System.Drawing.Color.Salmon;
            this.lstOldAlarms.FormattingEnabled = true;
            this.lstOldAlarms.ItemHeight = 21;
            this.lstOldAlarms.Location = new System.Drawing.Point(203, 281);
            this.lstOldAlarms.Name = "lstOldAlarms";
            this.lstOldAlarms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstOldAlarms.Size = new System.Drawing.Size(355, 193);
            this.lstOldAlarms.TabIndex = 0;
            this.lstOldAlarms.Click += new System.EventHandler(this.lstOldAlarms_Click);
            this.lstOldAlarms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstOldAlarms_MouseDoubleClick);
            // 
            // lstAktive
            // 
            this.lstAktive.FormattingEnabled = true;
            this.lstAktive.ItemHeight = 21;
            this.lstAktive.Location = new System.Drawing.Point(6, 49);
            this.lstAktive.Name = "lstAktive";
            this.lstAktive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstAktive.Size = new System.Drawing.Size(355, 193);
            this.lstAktive.TabIndex = 0;
            this.lstAktive.Click += new System.EventHandler(this.lstAktive_Click);
            this.lstAktive.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAktive_MouseDoubleClick);
            // 
            // erpWarning
            // 
            this.erpWarning.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAddName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(41, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 97);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adı";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(63, 49);
            this.txtAddName.MaxLength = 30;
            this.txtAddName.Multiline = true;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(191, 26);
            this.txtAddName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "lütfen hatırlatmanın adını giriniz.";
            // 
            // frmReminding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(177)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1176, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dudMunites);
            this.Controls.Add(this.dudHours);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReminding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hatırlatma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReminding_FormClosing);
            this.Load += new System.EventHandler(this.frmReminding_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpWarning)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesssage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DomainUpDown dudHours;
        private System.Windows.Forms.DomainUpDown dudMunites;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstAktive;
        private System.Windows.Forms.ErrorProvider erpWarning;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.ListBox lstPassive;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstOldAlarms;
    }
}