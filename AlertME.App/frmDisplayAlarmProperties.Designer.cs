namespace AlertME.App
{
    partial class frmDisplayAlarmProperties
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameChange = new System.Windows.Forms.TextBox();
            this.txtMessageChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateChange = new System.Windows.Forms.DateTimePicker();
            this.dudHoursChange = new System.Windows.Forms.DomainUpDown();
            this.dudMunitesChange = new System.Windows.Forms.DomainUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.erpWarningFrmChange = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpWarningFrmChange)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesaj";
            // 
            // txtNameChange
            // 
            this.txtNameChange.Location = new System.Drawing.Point(105, 28);
            this.txtNameChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameChange.MaxLength = 30;
            this.txtNameChange.Name = "txtNameChange";
            this.txtNameChange.Size = new System.Drawing.Size(281, 27);
            this.txtNameChange.TabIndex = 0;
            // 
            // txtMessageChange
            // 
            this.txtMessageChange.Location = new System.Drawing.Point(105, 85);
            this.txtMessageChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessageChange.MaxLength = 200;
            this.txtMessageChange.Multiline = true;
            this.txtMessageChange.Name = "txtMessageChange";
            this.txtMessageChange.Size = new System.Drawing.Size(281, 204);
            this.txtMessageChange.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saat";
            // 
            // dtpDateChange
            // 
            this.dtpDateChange.Location = new System.Drawing.Point(105, 319);
            this.dtpDateChange.Name = "dtpDateChange";
            this.dtpDateChange.Size = new System.Drawing.Size(281, 27);
            this.dtpDateChange.TabIndex = 2;
            // 
            // dudHoursChange
            // 
            this.dudHoursChange.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dudHoursChange.Location = new System.Drawing.Point(105, 359);
            this.dudHoursChange.Name = "dudHoursChange";
            this.dudHoursChange.Size = new System.Drawing.Size(57, 33);
            this.dudHoursChange.TabIndex = 3;
            this.dudHoursChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dudHoursChange.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dudHoursChange.Click += new System.EventHandler(this.EnterOrClickADomainUpDown_forThisForm);
            this.dudHoursChange.Enter += new System.EventHandler(this.EnterOrClickADomainUpDown_forThisForm);
            this.dudHoursChange.Leave += new System.EventHandler(this.dudMunitesChange_Leave);
            // 
            // dudMunitesChange
            // 
            this.dudMunitesChange.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dudMunitesChange.Location = new System.Drawing.Point(168, 359);
            this.dudMunitesChange.Name = "dudMunitesChange";
            this.dudMunitesChange.Size = new System.Drawing.Size(57, 33);
            this.dudMunitesChange.TabIndex = 4;
            this.dudMunitesChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dudMunitesChange.Click += new System.EventHandler(this.EnterOrClickADomainUpDown_forThisForm);
            this.dudMunitesChange.Enter += new System.EventHandler(this.EnterOrClickADomainUpDown_forThisForm);
            this.dudMunitesChange.Leave += new System.EventHandler(this.dudMunitesChange_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // erpWarningFrmChange
            // 
            this.erpWarningFrmChange.ContainerControl = this;
            // 
            // frmDisplayAlarmProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 467);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dudMunitesChange);
            this.Controls.Add(this.dudHoursChange);
            this.Controls.Add(this.dtpDateChange);
            this.Controls.Add(this.txtMessageChange);
            this.Controls.Add(this.txtNameChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDisplayAlarmProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alarm Bilgisi";
            this.Load += new System.EventHandler(this.frmDisplayAlarmProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpWarningFrmChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameChange;
        private System.Windows.Forms.TextBox txtMessageChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateChange;
        private System.Windows.Forms.DomainUpDown dudHoursChange;
        private System.Windows.Forms.DomainUpDown dudMunitesChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider erpWarningFrmChange;
    }
}