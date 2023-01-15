
namespace Tuzoltosag_v1
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.bExit = new System.Windows.Forms.Button();
            this.bBackup = new System.Windows.Forms.Button();
            this.lTime = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.Timer(this.components);
            this.lDate = new System.Windows.Forms.Label();
            this.bPractice = new System.Windows.Forms.Button();
            this.bAlert = new System.Windows.Forms.Button();
            this.bProbaAlert = new System.Windows.Forms.Button();
            this.bDeleteAlert = new System.Windows.Forms.Button();
            this.bOutsideLoud = new System.Windows.Forms.Button();
            this.bAlertLamp = new System.Windows.Forms.Button();
            this.bAlertSound = new System.Windows.Forms.Button();
            this.bSzolagatp = new System.Windows.Forms.Button();
            this.bChangeBegin = new System.Windows.Forms.Button();
            this.bChangeEnd = new System.Windows.Forms.Button();
            this.bWakeup = new System.Windows.Forms.Button();
            this.tConnection = new System.Windows.Forms.Timer(this.components);
            this.pAlarm = new System.Windows.Forms.Panel();
            this.lAlarmText = new System.Windows.Forms.Label();
            this.tBlink = new System.Windows.Forms.Timer(this.components);
            this.bUtanfuto = new System.Windows.Forms.Button();
            this.bSpecErdoszer = new System.Windows.Forms.Button();
            this.bErdoszer = new System.Windows.Forms.Button();
            this.bAll = new System.Windows.Forms.Button();
            this.bFire = new System.Windows.Forms.Button();
            this.bFecskendo1 = new System.Windows.Forms.Button();
            this.tSPort = new System.Windows.Forms.Timer(this.components);
            this.bSettings = new System.Windows.Forms.Button();
            this.bFecskendo2 = new System.Windows.Forms.Button();
            this.pAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bExit.AutoSize = true;
            this.bExit.BackColor = System.Drawing.Color.Red;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.Location = new System.Drawing.Point(592, 923);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(110, 45);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Kilépés";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bBackup
            // 
            this.bBackup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bBackup.AutoSize = true;
            this.bBackup.BackColor = System.Drawing.Color.Lime;
            this.bBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBackup.Location = new System.Drawing.Point(505, 170);
            this.bBackup.Margin = new System.Windows.Forms.Padding(2);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(283, 45);
            this.bBackup.TabIndex = 3;
            this.bBackup.Text = "Műszaki mentéshez";
            this.bBackup.UseVisualStyleBackColor = false;
            this.bBackup.Click += new System.EventHandler(this.bBackup_Click);
            this.bBackup.Paint += new System.Windows.Forms.PaintEventHandler(this.bBackup_Paint);
            // 
            // lTime
            // 
            this.lTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTime.ForeColor = System.Drawing.Color.White;
            this.lTime.Location = new System.Drawing.Point(922, 9);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(0, 91);
            this.lTime.TabIndex = 5;
            // 
            // tTime
            // 
            this.tTime.Enabled = true;
            this.tTime.Interval = 500;
            this.tTime.Tick += new System.EventHandler(this.tTime_Tick);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDate.ForeColor = System.Drawing.Color.White;
            this.lDate.Location = new System.Drawing.Point(76, 23);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(0, 46);
            this.lDate.TabIndex = 6;
            // 
            // bPractice
            // 
            this.bPractice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bPractice.AutoSize = true;
            this.bPractice.BackColor = System.Drawing.Color.Blue;
            this.bPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPractice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bPractice.Location = new System.Drawing.Point(505, 744);
            this.bPractice.Margin = new System.Windows.Forms.Padding(2);
            this.bPractice.Name = "bPractice";
            this.bPractice.Size = new System.Drawing.Size(283, 45);
            this.bPractice.TabIndex = 8;
            this.bPractice.Text = "Gyakorlat";
            this.bPractice.UseVisualStyleBackColor = false;
            this.bPractice.Click += new System.EventHandler(this.bPractice_Click);
            // 
            // bAlert
            // 
            this.bAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAlert.AutoSize = true;
            this.bAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAlert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAlert.Location = new System.Drawing.Point(83, 804);
            this.bAlert.Margin = new System.Windows.Forms.Padding(2);
            this.bAlert.Name = "bAlert";
            this.bAlert.Size = new System.Drawing.Size(269, 45);
            this.bAlert.TabIndex = 13;
            this.bAlert.Text = "Riasztás";
            this.bAlert.UseVisualStyleBackColor = false;
            this.bAlert.Click += new System.EventHandler(this.bAlert_Click);
            // 
            // bProbaAlert
            // 
            this.bProbaAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bProbaAlert.AutoSize = true;
            this.bProbaAlert.BackColor = System.Drawing.Color.Green;
            this.bProbaAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProbaAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bProbaAlert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bProbaAlert.Location = new System.Drawing.Point(83, 864);
            this.bProbaAlert.Margin = new System.Windows.Forms.Padding(2);
            this.bProbaAlert.Name = "bProbaAlert";
            this.bProbaAlert.Size = new System.Drawing.Size(269, 45);
            this.bProbaAlert.TabIndex = 14;
            this.bProbaAlert.Text = "Próbariasztás";
            this.bProbaAlert.UseVisualStyleBackColor = false;
            this.bProbaAlert.Click += new System.EventHandler(this.bProbaAlert_Click);
            // 
            // bDeleteAlert
            // 
            this.bDeleteAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDeleteAlert.AutoSize = true;
            this.bDeleteAlert.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bDeleteAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDeleteAlert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDeleteAlert.Location = new System.Drawing.Point(83, 923);
            this.bDeleteAlert.Margin = new System.Windows.Forms.Padding(2);
            this.bDeleteAlert.Name = "bDeleteAlert";
            this.bDeleteAlert.Size = new System.Drawing.Size(269, 45);
            this.bDeleteAlert.TabIndex = 15;
            this.bDeleteAlert.Text = "Riasztás törlése";
            this.bDeleteAlert.UseVisualStyleBackColor = false;
            this.bDeleteAlert.Click += new System.EventHandler(this.bDeleteAlert_Click);
            // 
            // bOutsideLoud
            // 
            this.bOutsideLoud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bOutsideLoud.AutoSize = true;
            this.bOutsideLoud.BackColor = System.Drawing.Color.Blue;
            this.bOutsideLoud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOutsideLoud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOutsideLoud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bOutsideLoud.Location = new System.Drawing.Point(925, 106);
            this.bOutsideLoud.Margin = new System.Windows.Forms.Padding(2);
            this.bOutsideLoud.Name = "bOutsideLoud";
            this.bOutsideLoud.Size = new System.Drawing.Size(267, 45);
            this.bOutsideLoud.TabIndex = 16;
            this.bOutsideLoud.Text = "Kültéri hangos";
            this.bOutsideLoud.UseVisualStyleBackColor = false;
            this.bOutsideLoud.Click += new System.EventHandler(this.bOutsideLoud_Click);
            this.bOutsideLoud.Paint += new System.Windows.Forms.PaintEventHandler(this.bOutsideLoud_Paint);
            // 
            // bAlertLamp
            // 
            this.bAlertLamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAlertLamp.AutoSize = true;
            this.bAlertLamp.BackColor = System.Drawing.Color.OrangeRed;
            this.bAlertLamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlertLamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAlertLamp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAlertLamp.Location = new System.Drawing.Point(925, 170);
            this.bAlertLamp.Margin = new System.Windows.Forms.Padding(2);
            this.bAlertLamp.Name = "bAlertLamp";
            this.bAlertLamp.Size = new System.Drawing.Size(267, 45);
            this.bAlertLamp.TabIndex = 17;
            this.bAlertLamp.Text = "Riadólámpa";
            this.bAlertLamp.UseVisualStyleBackColor = false;
            this.bAlertLamp.Click += new System.EventHandler(this.bAlertLamp_Click);
            this.bAlertLamp.Paint += new System.Windows.Forms.PaintEventHandler(this.bAlertLamp_Paint);
            // 
            // bAlertSound
            // 
            this.bAlertSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAlertSound.AutoSize = true;
            this.bAlertSound.BackColor = System.Drawing.Color.OrangeRed;
            this.bAlertSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlertSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAlertSound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAlertSound.Location = new System.Drawing.Point(925, 234);
            this.bAlertSound.Margin = new System.Windows.Forms.Padding(2);
            this.bAlertSound.Name = "bAlertSound";
            this.bAlertSound.Size = new System.Drawing.Size(267, 45);
            this.bAlertSound.TabIndex = 18;
            this.bAlertSound.Text = "Riadóhang";
            this.bAlertSound.UseVisualStyleBackColor = false;
            this.bAlertSound.Click += new System.EventHandler(this.bAlertSound_Click);
            // 
            // bSzolagatp
            // 
            this.bSzolagatp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSzolagatp.AutoSize = true;
            this.bSzolagatp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bSzolagatp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSzolagatp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSzolagatp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSzolagatp.Location = new System.Drawing.Point(925, 745);
            this.bSzolagatp.Margin = new System.Windows.Forms.Padding(2);
            this.bSzolagatp.Name = "bSzolagatp";
            this.bSzolagatp.Size = new System.Drawing.Size(267, 45);
            this.bSzolagatp.TabIndex = 19;
            this.bSzolagatp.Text = "Szolgálatparancsnok";
            this.bSzolagatp.UseVisualStyleBackColor = false;
            this.bSzolagatp.Click += new System.EventHandler(this.bSzolagatp_Click);
            // 
            // bChangeBegin
            // 
            this.bChangeBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bChangeBegin.AutoSize = true;
            this.bChangeBegin.BackColor = System.Drawing.Color.RoyalBlue;
            this.bChangeBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChangeBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bChangeBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bChangeBegin.Location = new System.Drawing.Point(925, 804);
            this.bChangeBegin.Margin = new System.Windows.Forms.Padding(2);
            this.bChangeBegin.Name = "bChangeBegin";
            this.bChangeBegin.Size = new System.Drawing.Size(267, 45);
            this.bChangeBegin.TabIndex = 20;
            this.bChangeBegin.Text = "Váltás kezdete";
            this.bChangeBegin.UseVisualStyleBackColor = false;
            this.bChangeBegin.Click += new System.EventHandler(this.bChangeBegin_Click);
            // 
            // bChangeEnd
            // 
            this.bChangeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bChangeEnd.AutoSize = true;
            this.bChangeEnd.BackColor = System.Drawing.Color.RoyalBlue;
            this.bChangeEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChangeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bChangeEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bChangeEnd.Location = new System.Drawing.Point(925, 864);
            this.bChangeEnd.Margin = new System.Windows.Forms.Padding(2);
            this.bChangeEnd.Name = "bChangeEnd";
            this.bChangeEnd.Size = new System.Drawing.Size(267, 45);
            this.bChangeEnd.TabIndex = 21;
            this.bChangeEnd.Text = "Váltás vége";
            this.bChangeEnd.UseVisualStyleBackColor = false;
            this.bChangeEnd.Click += new System.EventHandler(this.bChangeEnd_Click);
            // 
            // bWakeup
            // 
            this.bWakeup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bWakeup.AutoSize = true;
            this.bWakeup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bWakeup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bWakeup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bWakeup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bWakeup.Location = new System.Drawing.Point(925, 923);
            this.bWakeup.Margin = new System.Windows.Forms.Padding(2);
            this.bWakeup.Name = "bWakeup";
            this.bWakeup.Size = new System.Drawing.Size(267, 45);
            this.bWakeup.TabIndex = 22;
            this.bWakeup.Text = "Ébresztő";
            this.bWakeup.UseVisualStyleBackColor = false;
            this.bWakeup.Click += new System.EventHandler(this.bWakeup_Click);
            // 
            // tConnection
            // 
            this.tConnection.Enabled = true;
            this.tConnection.Interval = 20000;
            this.tConnection.Tick += new System.EventHandler(this.tConnection_Tick);
            // 
            // pAlarm
            // 
            this.pAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAlarm.AutoSize = true;
            this.pAlarm.BackColor = System.Drawing.Color.Red;
            this.pAlarm.Controls.Add(this.lAlarmText);
            this.pAlarm.Location = new System.Drawing.Point(1272, 0);
            this.pAlarm.Name = "pAlarm";
            this.pAlarm.Size = new System.Drawing.Size(1284, 1033);
            this.pAlarm.TabIndex = 23;
            this.pAlarm.Visible = false;
            this.pAlarm.Click += new System.EventHandler(this.pAlarm_Click);
            this.pAlarm.Paint += new System.Windows.Forms.PaintEventHandler(this.pAlarm_Paint);
            // 
            // lAlarmText
            // 
            this.lAlarmText.AutoSize = true;
            this.lAlarmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAlarmText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lAlarmText.Location = new System.Drawing.Point(474, 344);
            this.lAlarmText.Name = "lAlarmText";
            this.lAlarmText.Size = new System.Drawing.Size(526, 135);
            this.lAlarmText.TabIndex = 0;
            this.lAlarmText.Text = "Riasztás";
            // 
            // tBlink
            // 
            this.tBlink.Enabled = true;
            this.tBlink.Interval = 500;
            this.tBlink.Tick += new System.EventHandler(this.tBlink_Tick);
            // 
            // bUtanfuto
            // 
            this.bUtanfuto.AutoSize = true;
            this.bUtanfuto.BackColor = System.Drawing.Color.Green;
            this.bUtanfuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUtanfuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bUtanfuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bUtanfuto.Location = new System.Drawing.Point(83, 358);
            this.bUtanfuto.Margin = new System.Windows.Forms.Padding(2);
            this.bUtanfuto.Name = "bUtanfuto";
            this.bUtanfuto.Size = new System.Drawing.Size(269, 45);
            this.bUtanfuto.TabIndex = 12;
            this.bUtanfuto.Text = "Utánfutó";
            this.bUtanfuto.UseVisualStyleBackColor = false;
            this.bUtanfuto.Click += new System.EventHandler(this.bUtanfuto_Click);
            this.bUtanfuto.Paint += new System.Windows.Forms.PaintEventHandler(this.bUtanfuto_Paint);
            // 
            // bSpecErdoszer
            // 
            this.bSpecErdoszer.AutoSize = true;
            this.bSpecErdoszer.BackColor = System.Drawing.Color.Green;
            this.bSpecErdoszer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSpecErdoszer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSpecErdoszer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSpecErdoszer.Location = new System.Drawing.Point(83, 298);
            this.bSpecErdoszer.Margin = new System.Windows.Forms.Padding(2);
            this.bSpecErdoszer.Name = "bSpecErdoszer";
            this.bSpecErdoszer.Size = new System.Drawing.Size(269, 45);
            this.bSpecErdoszer.TabIndex = 11;
            this.bSpecErdoszer.Text = "Speciális Erdőszer";
            this.bSpecErdoszer.UseVisualStyleBackColor = false;
            this.bSpecErdoszer.Click += new System.EventHandler(this.bSpecErdoszer_Click);
            this.bSpecErdoszer.Paint += new System.Windows.Forms.PaintEventHandler(this.bSpecErdoszer_Paint);
            // 
            // bErdoszer
            // 
            this.bErdoszer.AutoSize = true;
            this.bErdoszer.BackColor = System.Drawing.Color.Green;
            this.bErdoszer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bErdoszer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bErdoszer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bErdoszer.Location = new System.Drawing.Point(83, 234);
            this.bErdoszer.Margin = new System.Windows.Forms.Padding(2);
            this.bErdoszer.Name = "bErdoszer";
            this.bErdoszer.Size = new System.Drawing.Size(269, 45);
            this.bErdoszer.TabIndex = 10;
            this.bErdoszer.Text = "Erdőszer";
            this.bErdoszer.UseVisualStyleBackColor = false;
            this.bErdoszer.Click += new System.EventHandler(this.bErdoszer_Click);
            this.bErdoszer.Paint += new System.Windows.Forms.PaintEventHandler(this.bErdoszer_Paint);
            // 
            // bAll
            // 
            this.bAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bAll.AutoSize = true;
            this.bAll.BackColor = System.Drawing.Color.Green;
            this.bAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAll.Location = new System.Drawing.Point(505, 234);
            this.bAll.Margin = new System.Windows.Forms.Padding(2);
            this.bAll.Name = "bAll";
            this.bAll.Size = new System.Drawing.Size(283, 45);
            this.bAll.TabIndex = 7;
            this.bAll.Text = "Összes szer";
            this.bAll.UseVisualStyleBackColor = false;
            this.bAll.Click += new System.EventHandler(this.bAll_Click);
            this.bAll.Paint += new System.Windows.Forms.PaintEventHandler(this.bAll_Paint);
            // 
            // bFire
            // 
            this.bFire.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bFire.AutoSize = true;
            this.bFire.BackColor = System.Drawing.Color.Red;
            this.bFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bFire.Location = new System.Drawing.Point(505, 106);
            this.bFire.Margin = new System.Windows.Forms.Padding(2);
            this.bFire.Name = "bFire";
            this.bFire.Size = new System.Drawing.Size(283, 45);
            this.bFire.TabIndex = 2;
            this.bFire.Text = "Tűzesethez";
            this.bFire.UseVisualStyleBackColor = true;
            this.bFire.Click += new System.EventHandler(this.bFire_Click);
            this.bFire.Paint += new System.Windows.Forms.PaintEventHandler(this.bFire_Paint);
            // 
            // bFecskendo1
            // 
            this.bFecskendo1.AutoSize = true;
            this.bFecskendo1.BackColor = System.Drawing.Color.Green;
            this.bFecskendo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFecskendo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFecskendo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bFecskendo1.Location = new System.Drawing.Point(83, 106);
            this.bFecskendo1.Margin = new System.Windows.Forms.Padding(2);
            this.bFecskendo1.Name = "bFecskendo1";
            this.bFecskendo1.Size = new System.Drawing.Size(269, 45);
            this.bFecskendo1.TabIndex = 9;
            this.bFecskendo1.Text = "1. Fecskendő";
            this.bFecskendo1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bFecskendo1.UseVisualStyleBackColor = false;
            this.bFecskendo1.Click += new System.EventHandler(this.bFecskendo1_Click);
            this.bFecskendo1.Paint += new System.Windows.Forms.PaintEventHandler(this.bFecskendo1_Paint);
            // 
            // tSPort
            // 
            this.tSPort.Enabled = true;
            this.tSPort.Interval = 300;
            this.tSPort.Tick += new System.EventHandler(this.tSPort_Tick);
            // 
            // bSettings
            // 
            this.bSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSettings.AutoSize = true;
            this.bSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSettings.Image = ((System.Drawing.Image)(resources.GetObject("bSettings.Image")));
            this.bSettings.Location = new System.Drawing.Point(592, 850);
            this.bSettings.Margin = new System.Windows.Forms.Padding(2);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(110, 59);
            this.bSettings.TabIndex = 24;
            this.bSettings.UseVisualStyleBackColor = false;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // bFecskendo2
            // 
            this.bFecskendo2.AutoSize = true;
            this.bFecskendo2.BackColor = System.Drawing.Color.Green;
            this.bFecskendo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFecskendo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFecskendo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bFecskendo2.Location = new System.Drawing.Point(84, 170);
            this.bFecskendo2.Margin = new System.Windows.Forms.Padding(2);
            this.bFecskendo2.Name = "bFecskendo2";
            this.bFecskendo2.Size = new System.Drawing.Size(269, 45);
            this.bFecskendo2.TabIndex = 25;
            this.bFecskendo2.Text = "2. Fecskendő";
            this.bFecskendo2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bFecskendo2.UseVisualStyleBackColor = false;
            this.bFecskendo2.Click += new System.EventHandler(this.bFecskendo2_Click);
            this.bFecskendo2.Paint += new System.Windows.Forms.PaintEventHandler(this.bFecskendo2_Paint);
            // 
            // Alarm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1277, 1029);
            this.Controls.Add(this.pAlarm);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.bWakeup);
            this.Controls.Add(this.bChangeEnd);
            this.Controls.Add(this.bChangeBegin);
            this.Controls.Add(this.bSzolagatp);
            this.Controls.Add(this.bAlertSound);
            this.Controls.Add(this.bAlertLamp);
            this.Controls.Add(this.bOutsideLoud);
            this.Controls.Add(this.bDeleteAlert);
            this.Controls.Add(this.bProbaAlert);
            this.Controls.Add(this.bAlert);
            this.Controls.Add(this.bUtanfuto);
            this.Controls.Add(this.bSpecErdoszer);
            this.Controls.Add(this.bErdoszer);
            this.Controls.Add(this.bPractice);
            this.Controls.Add(this.bAll);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.bBackup);
            this.Controls.Add(this.bFire);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bFecskendo1);
            this.Controls.Add(this.bFecskendo2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alarm";
            this.Text = "Tűzoltóság";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alarm_FormClosing);
            this.pAlarm.ResumeLayout(false);
            this.pAlarm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bFire;
        private System.Windows.Forms.Button bBackup;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Timer tTime;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Button bAll;
        private System.Windows.Forms.Button bPractice;
        private System.Windows.Forms.Button bFecskendo1;
        private System.Windows.Forms.Button bErdoszer;
        private System.Windows.Forms.Button bSpecErdoszer;
        private System.Windows.Forms.Button bUtanfuto;
        private System.Windows.Forms.Button bAlert;
        private System.Windows.Forms.Button bProbaAlert;
        private System.Windows.Forms.Button bDeleteAlert;
        private System.Windows.Forms.Button bOutsideLoud;
        private System.Windows.Forms.Button bAlertLamp;
        private System.Windows.Forms.Button bAlertSound;
        private System.Windows.Forms.Button bSzolagatp;
        private System.Windows.Forms.Button bChangeBegin;
        private System.Windows.Forms.Button bChangeEnd;
        private System.Windows.Forms.Button bWakeup;
        private System.Windows.Forms.Timer tConnection;
        private System.Windows.Forms.Panel pAlarm;
        private System.Windows.Forms.Label lAlarmText;
        private System.Windows.Forms.Timer tBlink;
        private System.Windows.Forms.Timer tSPort;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Button bFecskendo2;
    }
}

