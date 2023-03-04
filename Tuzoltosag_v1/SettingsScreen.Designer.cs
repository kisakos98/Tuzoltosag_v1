namespace Tuzoltosag_v1
{
    partial class SettingsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsScreen));
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.lAlertSound = new System.Windows.Forms.Label();
            this.cBAlertSounds = new System.Windows.Forms.ComboBox();
            this.gBSound = new System.Windows.Forms.GroupBox();
            this.Delay_nUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bTestSound = new System.Windows.Forms.Button();
            this.cBTestSounds = new System.Windows.Forms.ComboBox();
            this.lTestSound = new System.Windows.Forms.Label();
            this.bWakeupSound = new System.Windows.Forms.Button();
            this.cBWakeupSounds = new System.Windows.Forms.ComboBox();
            this.lWakeupSound = new System.Windows.Forms.Label();
            this.bAlertSound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.lUpdate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AlertTurnoffDelay_nUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.gBSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delay_nUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlertTurnoffDelay_nUD)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancel.AutoSize = true;
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancel.Location = new System.Drawing.Point(11, 482);
            this.bCancel.Margin = new System.Windows.Forms.Padding(2);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(110, 59);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Mégse";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.AutoSize = true;
            this.bSave.BackColor = System.Drawing.Color.Green;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.Location = new System.Drawing.Point(679, 482);
            this.bSave.Margin = new System.Windows.Forms.Padding(2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(110, 59);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Mentés";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lAlertSound
            // 
            this.lAlertSound.AutoSize = true;
            this.lAlertSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAlertSound.Location = new System.Drawing.Point(12, 40);
            this.lAlertSound.Name = "lAlertSound";
            this.lAlertSound.Size = new System.Drawing.Size(168, 29);
            this.lAlertSound.TabIndex = 4;
            this.lAlertSound.Text = "Riasztási hang";
            // 
            // cBAlertSounds
            // 
            this.cBAlertSounds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBAlertSounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBAlertSounds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBAlertSounds.FormattingEnabled = true;
            this.cBAlertSounds.Location = new System.Drawing.Point(195, 43);
            this.cBAlertSounds.Name = "cBAlertSounds";
            this.cBAlertSounds.Size = new System.Drawing.Size(203, 26);
            this.cBAlertSounds.TabIndex = 5;
            // 
            // gBSound
            // 
            this.gBSound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gBSound.Controls.Add(this.Delay_nUD);
            this.gBSound.Controls.Add(this.label2);
            this.gBSound.Controls.Add(this.bTestSound);
            this.gBSound.Controls.Add(this.cBTestSounds);
            this.gBSound.Controls.Add(this.lTestSound);
            this.gBSound.Controls.Add(this.bWakeupSound);
            this.gBSound.Controls.Add(this.cBWakeupSounds);
            this.gBSound.Controls.Add(this.lWakeupSound);
            this.gBSound.Controls.Add(this.bAlertSound);
            this.gBSound.Controls.Add(this.lAlertSound);
            this.gBSound.Controls.Add(this.cBAlertSounds);
            this.gBSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBSound.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gBSound.Location = new System.Drawing.Point(130, 77);
            this.gBSound.Name = "gBSound";
            this.gBSound.Size = new System.Drawing.Size(539, 284);
            this.gBSound.TabIndex = 6;
            this.gBSound.TabStop = false;
            this.gBSound.Text = "Hang";
            // 
            // Delay_nUD
            // 
            this.Delay_nUD.Location = new System.Drawing.Point(348, 234);
            this.Delay_nUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Delay_nUD.Name = "Delay_nUD";
            this.Delay_nUD.Size = new System.Drawing.Size(50, 24);
            this.Delay_nUD.TabIndex = 15;
            this.Delay_nUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hang késleltetés [mp]";
            // 
            // bTestSound
            // 
            this.bTestSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTestSound.AutoSize = true;
            this.bTestSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bTestSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTestSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bTestSound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bTestSound.Image = ((System.Drawing.Image)(resources.GetObject("bTestSound.Image")));
            this.bTestSound.Location = new System.Drawing.Point(429, 158);
            this.bTestSound.Margin = new System.Windows.Forms.Padding(2);
            this.bTestSound.Name = "bTestSound";
            this.bTestSound.Size = new System.Drawing.Size(67, 49);
            this.bTestSound.TabIndex = 13;
            this.bTestSound.UseVisualStyleBackColor = false;
            this.bTestSound.Click += new System.EventHandler(this.bTestSound_Click);
            // 
            // cBTestSounds
            // 
            this.cBTestSounds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBTestSounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTestSounds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBTestSounds.FormattingEnabled = true;
            this.cBTestSounds.Location = new System.Drawing.Point(195, 171);
            this.cBTestSounds.Name = "cBTestSounds";
            this.cBTestSounds.Size = new System.Drawing.Size(203, 26);
            this.cBTestSounds.TabIndex = 12;
            // 
            // lTestSound
            // 
            this.lTestSound.AutoSize = true;
            this.lTestSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTestSound.Location = new System.Drawing.Point(13, 166);
            this.lTestSound.Name = "lTestSound";
            this.lTestSound.Size = new System.Drawing.Size(173, 29);
            this.lTestSound.TabIndex = 11;
            this.lTestSound.Text = "Gyakorlat hang";
            // 
            // bWakeupSound
            // 
            this.bWakeupSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bWakeupSound.AutoSize = true;
            this.bWakeupSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bWakeupSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bWakeupSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bWakeupSound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bWakeupSound.Image = ((System.Drawing.Image)(resources.GetObject("bWakeupSound.Image")));
            this.bWakeupSound.Location = new System.Drawing.Point(429, 95);
            this.bWakeupSound.Margin = new System.Windows.Forms.Padding(2);
            this.bWakeupSound.Name = "bWakeupSound";
            this.bWakeupSound.Size = new System.Drawing.Size(67, 49);
            this.bWakeupSound.TabIndex = 10;
            this.bWakeupSound.UseVisualStyleBackColor = false;
            this.bWakeupSound.Click += new System.EventHandler(this.bWakeupSound_Click);
            // 
            // cBWakeupSounds
            // 
            this.cBWakeupSounds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBWakeupSounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBWakeupSounds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBWakeupSounds.FormattingEnabled = true;
            this.cBWakeupSounds.Location = new System.Drawing.Point(195, 108);
            this.cBWakeupSounds.Name = "cBWakeupSounds";
            this.cBWakeupSounds.Size = new System.Drawing.Size(203, 26);
            this.cBWakeupSounds.TabIndex = 9;
            // 
            // lWakeupSound
            // 
            this.lWakeupSound.AutoSize = true;
            this.lWakeupSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lWakeupSound.Location = new System.Drawing.Point(12, 103);
            this.lWakeupSound.Name = "lWakeupSound";
            this.lWakeupSound.Size = new System.Drawing.Size(167, 29);
            this.lWakeupSound.TabIndex = 8;
            this.lWakeupSound.Text = "Ébresztő hang";
            // 
            // bAlertSound
            // 
            this.bAlertSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAlertSound.AutoSize = true;
            this.bAlertSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAlertSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlertSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAlertSound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAlertSound.Image = ((System.Drawing.Image)(resources.GetObject("bAlertSound.Image")));
            this.bAlertSound.Location = new System.Drawing.Point(429, 32);
            this.bAlertSound.Margin = new System.Windows.Forms.Padding(2);
            this.bAlertSound.Name = "bAlertSound";
            this.bAlertSound.Size = new System.Drawing.Size(67, 49);
            this.bAlertSound.TabIndex = 7;
            this.bAlertSound.UseVisualStyleBackColor = false;
            this.bAlertSound.Click += new System.EventHandler(this.bAlertSound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Beállítások";
            // 
            // bUpdate
            // 
            this.bUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpdate.AutoSize = true;
            this.bUpdate.BackColor = System.Drawing.Color.Blue;
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bUpdate.Location = new System.Drawing.Point(599, 13);
            this.bUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(190, 59);
            this.bUpdate.TabIndex = 15;
            this.bUpdate.Text = "Frissítés keresése";
            this.bUpdate.UseVisualStyleBackColor = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // lUpdate
            // 
            this.lUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lUpdate.AutoSize = true;
            this.lUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lUpdate.Location = new System.Drawing.Point(545, 20);
            this.lUpdate.Name = "lUpdate";
            this.lUpdate.Size = new System.Drawing.Size(31, 46);
            this.lUpdate.TabIndex = 16;
            this.lUpdate.Text = "!";
            this.lUpdate.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.AlertTurnoffDelay_nUD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(131, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 99);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Riasztás";
            // 
            // AlertTurnoffDelay_nUD
            // 
            this.AlertTurnoffDelay_nUD.Location = new System.Drawing.Point(347, 42);
            this.AlertTurnoffDelay_nUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AlertTurnoffDelay_nUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AlertTurnoffDelay_nUD.Name = "AlertTurnoffDelay_nUD";
            this.AlertTurnoffDelay_nUD.Size = new System.Drawing.Size(50, 24);
            this.AlertTurnoffDelay_nUD.TabIndex = 15;
            this.AlertTurnoffDelay_nUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lekapcsolási idő [p]";
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lUpdate);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBSound);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancel);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsScreen";
            this.gBSound.ResumeLayout(false);
            this.gBSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delay_nUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlertTurnoffDelay_nUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lAlertSound;
        private System.Windows.Forms.ComboBox cBAlertSounds;
        private System.Windows.Forms.GroupBox gBSound;
        private System.Windows.Forms.Button bAlertSound;
        private System.Windows.Forms.Button bWakeupSound;
        private System.Windows.Forms.ComboBox cBWakeupSounds;
        private System.Windows.Forms.Label lWakeupSound;
        private System.Windows.Forms.Button bTestSound;
        private System.Windows.Forms.ComboBox cBTestSounds;
        private System.Windows.Forms.Label lTestSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Label lUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Delay_nUD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown AlertTurnoffDelay_nUD;
        private System.Windows.Forms.Label label3;
    }
}