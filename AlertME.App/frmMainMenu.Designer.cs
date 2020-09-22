namespace AlertME.App
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButtonReminding = new System.Windows.Forms.Panel();
            this.btnReminding = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxForNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxButtonOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxButtonClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlButtonReminding.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ctxForNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(418, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "written by Sergen KAHRAMAN";
            // 
            // pnlButtonReminding
            // 
            this.pnlButtonReminding.BackColor = System.Drawing.Color.Black;
            this.pnlButtonReminding.Controls.Add(this.btnReminding);
            this.pnlButtonReminding.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonReminding.Name = "pnlButtonReminding";
            this.pnlButtonReminding.Size = new System.Drawing.Size(632, 341);
            this.pnlButtonReminding.TabIndex = 2;
            // 
            // btnReminding
            // 
            this.btnReminding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(177)))), ((int)(((byte)(149)))));
            this.btnReminding.BackgroundImage = global::AlertME.App.Properties.Resources.reminder__3_;
            this.btnReminding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReminding.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReminding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReminding.ImageIndex = 0;
            this.btnReminding.Location = new System.Drawing.Point(504, 213);
            this.btnReminding.Name = "btnReminding";
            this.btnReminding.Size = new System.Drawing.Size(128, 128);
            this.btnReminding.TabIndex = 1;
            this.btnReminding.UseVisualStyleBackColor = false;
            this.btnReminding.Click += new System.EventHandler(this.btnReminding_Click);
            this.btnReminding.MouseEnter += new System.EventHandler(this.btnReminding_MouseEnter);
            this.btnReminding.MouseLeave += new System.EventHandler(this.btnReminding_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(632, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 341);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(70)))), ((int)(((byte)(61)))));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(0, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 128);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 341);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(63)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(504, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 128);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.label1);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(632, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 341);
            this.panel4.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnExit.BackgroundImage = global::AlertME.App.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 128);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.ctxForNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AlertME";
            this.notifyIcon1.Visible = true;
            // 
            // ctxForNotifyIcon
            // 
            this.ctxForNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxButtonOpen,
            this.ctxButtonClose});
            this.ctxForNotifyIcon.Name = "ctxForNotifyIcon";
            this.ctxForNotifyIcon.Size = new System.Drawing.Size(105, 48);
            // 
            // ctxButtonOpen
            // 
            this.ctxButtonOpen.Name = "ctxButtonOpen";
            this.ctxButtonOpen.Size = new System.Drawing.Size(104, 22);
            this.ctxButtonOpen.Text = "Aç";
            this.ctxButtonOpen.Click += new System.EventHandler(this.ctxButtonOpen_Click);
            // 
            // ctxButtonClose
            // 
            this.ctxButtonClose.Name = "ctxButtonClose";
            this.ctxButtonClose.Size = new System.Drawing.Size(104, 22);
            this.ctxButtonClose.Text = "Kapat";
            this.ctxButtonClose.Click += new System.EventHandler(this.ctxButtonClose_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlButtonReminding);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertME";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pnlButtonReminding.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ctxForNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReminding;
        private System.Windows.Forms.Panel pnlButtonReminding;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ctxForNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem ctxButtonOpen;
        private System.Windows.Forms.ToolStripMenuItem ctxButtonClose;
    }
}

