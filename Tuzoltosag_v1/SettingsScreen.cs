using System;
using System.Windows.Forms;

namespace Tuzoltosag_v1
{
    public partial class SettingsScreen : Form
    {
        public SettingsScreen()
        {
            InitializeComponent();

            cBAlertSounds.Items.Add("bevezeto_dvorak.wav");
            cBAlertSounds.Items.Add("bevezeto_lgt.wav");
            cBAlertSounds.Items.Add("bevezeto_morricone.wav");
            cBAlertSounds.Text = Properties.Settings.Default.AlertSound;

            cBWakeupSounds.Items.Add("ebreszto.wav");
            cBWakeupSounds.Items.Add("ebreszto_2.wav");
            cBWakeupSounds.Text = Properties.Settings.Default.WakeupSound;

            cBTestSounds.Items.Add("bevezeto_dvorak.wav");
            cBTestSounds.Items.Add("bevezeto_lgt.wav");
            cBTestSounds.Items.Add("bevezeto_morricone.wav");
            cBTestSounds.Text = Properties.Settings.Default.TestSound;

            lUpdate.Visible = ApplicationUpdate.UpdateRequired;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            SoundPlayer.Stop();
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlertSound = cBAlertSounds.Text;
            Properties.Settings.Default.WakeupSound = cBWakeupSounds.Text;
            Properties.Settings.Default.TestSound = cBTestSounds.Text;
            Properties.Settings.Default.Save();
            SoundPlayer.Stop();
            this.Close();
        }

        private void bAlertSound_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] { cBAlertSounds.Text }, false);
        }

        private void bWakeupSound_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] { cBWakeupSounds.Text }, false);
        }

        private void bTestSound_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] { cBTestSounds.Text }, false);
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            ApplicationUpdate.InstallUpdateSyncWithInfo();
        }
    }
}
