using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AE.Net.Mail;
using System.Net;
using System.Net.Http;
using System.Management;
using System.IO.Ports;
using System.IO;
using System.Deployment.Application;
using System.Threading;
using QRCoder;
using System.Collections.Generic;

namespace Tuzoltosag_v1
{    
    public partial class Alarm : Form
    {
        static Bitmap qrCodeImage = null;

        static SettingsScreen Settings = null;

        static readonly int Lamp1 = 4;
        static readonly int Loud1 = 5;

        static bool WirelessContoller = false;
        static bool WiredController = false;

        static bool fecskendo1 = false;
        static bool fecskendo2 = false;
        static bool erdoszer = false;
        static bool specErdoszer = false;
        static bool utanfuto = false;
        static bool osszesszer = false;
        static bool tuzesethez = false;
        static bool muszakiMenteshez = false;
        static bool riadolampa = false;
        static bool kulteriHangos = false;
        bool Fecskendo1
        {
            set
            {
                fecskendo1 = value;
                bFecskendo1.Invalidate();
            }
            get 
            {
                return fecskendo1;
            }
        }
        bool Fecskendo2
        {
            set
            {
                fecskendo2 = value;
                bFecskendo2.Invalidate();
            }
            get
            {
                return fecskendo2;
            }
        }
        bool Erdoszer
        {
            set
            {
                erdoszer = value;
                bErdoszer.Invalidate();
            }
            get
            {
                return erdoszer;
            }
        }
        bool SpecErdoszer
        {
            set
            {
                specErdoszer = value;
                bSpecErdoszer.Invalidate();
            }
            get
            {
                return specErdoszer;
            }
        }
        bool Utanfuto
        {
            set
            {
                utanfuto = value;
                bUtanfuto.Invalidate();
            }
            get
            {
                return utanfuto;
            }
        }
        bool Osszesszer
        {
            set
            {
                osszesszer = value;
                bAll.Invalidate();
            }
            get
            {
                return osszesszer;
            }
        }
        bool Tuzesethez
        {
            set
            {
                tuzesethez = value;
                bFire.Invalidate();
            }
            get
            {
                return tuzesethez;
            }
        }
        bool MuszakiMenteshez
        {
            set
            {
                muszakiMenteshez = value;
                bBackup.Invalidate();
            }
            get
            {
                return muszakiMenteshez;
            }
        }
        bool Riadolampa
        {
            set
            {
                riadolampa = value;
                bAlertLamp.Invalidate();
            }
            get
            {
                return riadolampa;
            }
        }
        bool KulteriHangos
        {
            set
            {
                kulteriHangos = value;
                bOutsideLoud.Invalidate();
            }
            get
            {
                return kulteriHangos;
            }
        }

        static ImapClient IC = null;
        static string ImapHost = "outlook.office365.com";
        static string ImapEmail = "riasztasszomolya@hotmail.com";
        static string ImapPassword = "rsygnofflpqrzuss";

        static SerialPort SPort = null;

        public Alarm()
        {
            InitializeComponent();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = Path.Combine(path, "tuzoltosag_logs.txt"); ;
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("This is a log file for the tuzoltosag app!");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Starting: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
            }

            lAlarmText.Location = new Point((ClientSize.Width / 2) - (lAlarmText.Width / 5), (ClientSize.Height / 3) - (lAlarmText.Height / 2));

            tSPort.Enabled = false;
            try
            {
                //IC = new ImapClient("imap.mail.yahoo.com", "riasztasszomolya@yahoo.com", "qmpshypkeccgveds", AuthMethods.Login, 993, true);
                IC = new ImapClient(ImapHost, ImapEmail, ImapPassword, AuthMethods.Login, 993, true);
                //IC = new ImapClient("imap-mail.outlook.com", "riasztasszomolya@hotmail.com", "rsygnofflpqrzuss", AuthMethods.Login, 993, true);
                //IC = new ImapClient("imap.gmail.com", "riasztasszomolya@gmail.com", "qldtwawscqpsvqbp", AuthMethods.Login, 993, true);
                IC.SelectMailbox("INBOX");
                IC.NewMessage += IC_NewMessage;
            }
            catch
            {
                MessageBox.Show("Nem sikerült kapcsolódni a kiszolgálóhoz.", "Kapcsolódási hiba!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Shown += new EventHandler(CloseOnStartup);
            }
            try
            {
                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
                {
                    var portnames = SerialPort.GetPortNames();
                    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                    var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                    foreach (string s in portList)
                    {
                        Console.WriteLine(s);
                        if (s.Contains("CP210"))
                        {
                            SPort = new SerialPort(s.Substring(0, s.IndexOf(" ")), 9600, Parity.None, 8, StopBits.One);
                            SPort.Open();
                            break;
                        }
                    }
                    if (SPort == null)
                        throw new Exception("Nincs ilyen COM port.");
                }
                WiredController = true;
            }
            catch
            {
                WiredController = false;
                try 
                {
                    SetLamp(Lamp1, Riadolampa);
                    SetLamp(Loud1, KulteriHangos);
                    WirelessContoller = true;
                }
                catch
                {
                    WirelessContoller = false;
                }
                if ((WiredController == false) && (WirelessContoller == false))
                {
                    MessageBox.Show("Nem sikerült kapcsolódni a lámpavezérlőhöz.", "Kapcsolódási hiba!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bOutsideLoud.BackColor = Color.Gray;
                    bOutsideLoud.Enabled = false;
                    bAlertLamp.BackColor = Color.Gray;
                    bAlertLamp.Enabled = false;
                    bOutsideLoud.Invalidate();
                    bAlertLamp.Invalidate();
                }
            }
            tSPort.Enabled = true;
            tSPort.Start();
            ApplicationUpdate.CheckForUpdates();
        }

        private void CloseOnStartup(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void CheckConnection()
        {
            try
            {
                if (IC != null)
                    IC.GetMessageCount();
                else
                {

                    //IC = new ImapClient("imap.mail.yahoo.com", "riasztasszomolya@yahoo.com", "qmpshypkeccgveds", AuthMethods.Login, 993, true);
                    IC = new ImapClient("outlook.office365.com", "riasztasszomolya@hotmail.com", "rsygnofflpqrzuss", AuthMethods.Login, 993, true);
                    //IC = new ImapClient("imap-mail.outlook.com", "riasztasszomolya@hotmail.com", "rsygnofflpqrzuss", AuthMethods.Login, 993, true);
                    //IC = new ImapClient("imap.gmail.com", "riasztasszomolya@gmail.com", "qldtwawscqpsvqbp", AuthMethods.Login, 993, true);
                    IC.SelectMailbox("INBOX");
                    IC.NewMessage += IC_NewMessage;
                }
            }
            catch
            {
                try
                {
                    //IC = new ImapClient("imap.mail.yahoo.com", "riasztasszomolya@yahoo.com", "qmpshypkeccgveds", AuthMethods.Login, 993, true);
                    IC = new ImapClient("outlook.office365.com", "riasztasszomolya@hotmail.com", "rsygnofflpqrzuss", AuthMethods.Login, 993, true);
                    //IC = new ImapClient("imap-mail.outlook.com", "riasztasszomolya@hotmail.com", "rsygnofflpqrzuss", AuthMethods.Login, 993, true); 
                    //IC = new ImapClient("imap.gmail.com", "riasztasszomolya@gmail.com", "qldtwawscqpsvqbp", AuthMethods.Login, 993, true);
                    IC.SelectMailbox("INBOX");
                    IC.NewMessage += IC_NewMessage;
                }
                catch
                {
                    MessageBox.Show("Nem sikerült kapcsolódni a kiszolgálóhoz.", "Kapcsolódási hiba!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void IC_NewMessage(object sender, AE.Net.Mail.Imap.MessageEventArgs e)
        {
            try
            {
                Thread.Sleep(200);
                var msg = IC.GetMessage(e.MessageCount - 1);
                //if (msg.Subject.Equals("Riasztási lap") && msg.From.Address.Equals("emailgw@katved.gov.hu"))
                if (msg.Subject.Equals("Riasztási lap"))
                {

                    // Get location

                    string cityLine = "Település/Szektor: ";
                    int from = msg.Body.IndexOf(cityLine);
                    from += cityLine.Length;
                    int len = 0;

                    for (int i = from; i < msg.Body.Length; i++)
                    {
                        if (msg.Body[i] == '\r')
                        {
                            break;
                        }
                        len++;
                    }
                    string city = msg.Body.Substring(from, len);

                    string addressLine = "Cím: ";
                    from = msg.Body.IndexOf(addressLine);
                    from += addressLine.Length;
                    len = 0;

                    for (int i = from; i < msg.Body.Length; i++)
                    {
                        if (msg.Body[i] == '\r')
                        {
                            break;
                        }
                        len++;
                    }
                    string address = msg.Body.Substring(from, len);

                    // Create QRcode

                    using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                    using (QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://www.google.hu/maps/search/" + city + " " + address, QRCodeGenerator.ECCLevel.Q))
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        qrCodeImage = qrCode.GetGraphic(5);
                    }

                    /*
                    int from = msg.Body.IndexOf("Káreset fajtája: ");
                    int to = msg.Body.LastIndexOf("Kategória:");
                    if ((from <= 0) || (to <= 0))
                    {
                        return;
                    }
                    string data = msg.Body.Substring(from, to - from).Replace("Káreset fajtája: ", "").Trim();
                    */
                    if (msg.Body.Contains("Tűzeset"))
                    {
                        Alarm_Fire();
                    }
                    else if (msg.Body.Contains("Műszaki mentés"))
                    {
                        Alarm_TechnicalBackup();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch
            {
                // :(
            }
        }

        private void Alarm_Fire()
        {
            Riadolampa = true;
            if (WirelessContoller)
            {
                try
                {
                    SetLamp(Lamp1, true);
                }
                catch
                {
                    WirelessContoller = false;
                    MessageBox.Show("Megszakadt a kapcsolat a lámpavezérlővel.", "Kapcsolódási hiba!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MethodInvoker methodInvokerDelegate = delegate ()
            {   pAlarm.Location = new Point(0, 0);
                pAlarm.BackColor = Color.Red;
                pAlarm.Visible = true; };

            Invoke(methodInvokerDelegate);

            SoundPlayer.Play(new string[] { Properties.Settings.Default.AlertSound, "figyelem_riasztas.wav", "figyelem_riasztas.wav", "tuzesethez.wav", "osszes_h.wav" }, true);
        }

        private void Alarm_TechnicalBackup()
        {
            Riadolampa = true;
            if (WirelessContoller)
            {
                try
                {
                    SetLamp(Lamp1, true);
                }
                catch
                {
                    WirelessContoller = false;
                    MessageBox.Show("Megszakadt a kapcsolat a lámpavezérlővel.", "Kapcsolódási hiba!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           

            MethodInvoker methodInvokerDelegate = delegate ()
            { pAlarm.Visible = true;
                pAlarm.BackColor = Color.Red;
                pAlarm.Location = new Point(0, 0); };

            Invoke(methodInvokerDelegate);

            SoundPlayer.Play(new string[] { Properties.Settings.Default.AlertSound, "figyelem_riasztas.wav", "figyelem_riasztas.wav", "karesethez.wav", "osszes_h.wav" }, true);
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bFire_Click(object sender, EventArgs e)
        {
            if (!Tuzesethez)
            {
                Tuzesethez = true;

                MuszakiMenteshez = false;
                bBackup.BackColor = Color.Lime;
            }
            else 
            {
                Tuzesethez = false;
                bFire.BackColor = Color.Red;
            }
        }

        private void bBackup_Click(object sender, EventArgs e)
        {
            if (!MuszakiMenteshez)
            {
                MuszakiMenteshez = true;

                Tuzesethez = false;
                bFire.BackColor = Color.Red;
            }
            else
            {
                MuszakiMenteshez = false;
                bBackup.BackColor = Color.Lime;
            }
        }

        private void tTime_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lDate.Text = DateTime.Now.ToString("yyyy. MMMM d. dddd");
        }

        private void bAll_Click(object sender, EventArgs e)
        {
            if (!Osszesszer)
            {
                Osszesszer = true;

                Fecskendo1 = true;

                Fecskendo2 = true;

                Erdoszer = true;

                SpecErdoszer = true;

                Utanfuto = false;
                bUtanfuto.BackColor = Color.Green;
            }
            else
            {
                Osszesszer = false;
                bAll.BackColor = Color.Green;

                Fecskendo1 = false;
                bFecskendo1.BackColor = Color.Green;

                Fecskendo2 = false;
                bFecskendo2.BackColor = Color.Green;

                Erdoszer = false;
                bErdoszer.BackColor = Color.Green;

                SpecErdoszer = false;
                bSpecErdoszer.BackColor = Color.Green;

                Utanfuto = false;
                bUtanfuto.BackColor = Color.Green;
            }
        }

        private void bPractice_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] { Properties.Settings.Default.TestSound, "figyelem_gyakorlat.wav", "figyelem_gyakorlat.wav", "osszes_h.wav" }, false);
        }

        private void bFecskendo1_Click(object sender, EventArgs e)
        {
            if (!Fecskendo1)
            {
                Fecskendo1 = true;
            }
            else 
            {
                Fecskendo1 = false;
                bFecskendo1.BackColor = Color.Green;

                Osszesszer = false;
                bAll.BackColor = Color.Green;
            }
        }

        private void bFecskendo2_Click(object sender, EventArgs e)
        {
            if (!Fecskendo2)
            {
                Fecskendo2 = true;
            }
            else
            {
                Fecskendo2 = false;
                bFecskendo2.BackColor = Color.Green;

                Osszesszer = false;
                bAll.BackColor = Color.Green;
            }
        }

        private void bErdoszer_Click(object sender, EventArgs e)
        {
            if (!Erdoszer)
            {
                Erdoszer = true;
            }
            else
            {
                Erdoszer = false;
                bErdoszer.BackColor = Color.Green;

                Osszesszer = false;
                bAll.BackColor = Color.Green;
            }
        }

        private void bSpecErdoszer_Click(object sender, EventArgs e)
        {
            if (!SpecErdoszer)
            {
                SpecErdoszer = true;
            }
            else
            {
                SpecErdoszer = false;
                bSpecErdoszer.BackColor = Color.Green;

                Osszesszer = false;
                bAll.BackColor = Color.Green;
            }
        }

        private void bUtanfuto_Click(object sender, EventArgs e)
        {
            if (!Utanfuto)
            {
                Utanfuto = true;
            }
            else
            {
                Utanfuto = false;
                bUtanfuto.BackColor = Color.Green;
            }
        }

        private void bAlert_Click(object sender, EventArgs e)
        {
            if (((Erdoszer) || (Fecskendo1) || (Fecskendo2) || (SpecErdoszer) || (Utanfuto)) && ((Tuzesethez) || (MuszakiMenteshez)))
            {
                Riadolampa = true;
                if (WirelessContoller)
                {
                    try
                    {
                        SetLamp(Lamp1, true);
                    }
                    catch
                    {
                        WirelessContoller = false;
                        MessageBox.Show("Megszakadt a kapcsolat a lámpavezérlővel.", "Kapcsolódási hiba!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (Fecskendo1)
                {
                    bFecskendo1.BackColor = Color.Red;
                }
                if (Fecskendo2)
                {
                    bFecskendo2.BackColor = Color.Red;
                }
                if (Erdoszer)
                {
                    bErdoszer.BackColor = Color.Red;
                }
                if (SpecErdoszer)
                {
                    bSpecErdoszer.BackColor = Color.Red;
                }
                if (Utanfuto)
                {
                    bUtanfuto.BackColor = Color.Red;
                }
                if (Tuzesethez)
                {
                    bFire.BackColor = Color.Red;
                }
                if (MuszakiMenteshez)
                {
                    bBackup.BackColor = Color.Red;
                }
                if (Osszesszer)
                {
                    bAll.BackColor = Color.Red;
                }

                bAlert.BackColor = Color.Red;

                List<string> soundlist = new List<string>();
                soundlist.Add(Properties.Settings.Default.AlertSound);
                soundlist.Add("figyelem_riasztas.wav");
                soundlist.Add("figyelem_riasztas.wav");

                if (Tuzesethez)
                    soundlist.Add("tuzesethez.wav");
                else
                    soundlist.Add("karesethez.wav");

                if (Osszesszer)
                {
                    soundlist.Add("osszes.wav");
                    soundlist.Add("osszes_h.wav");
                }
                else 
                {
                    if (Fecskendo1)
                    {
                        soundlist.Add("1.wav");
                        soundlist.Add("fecskendo.wav");
                        soundlist.Add("fecskendo_h.wav");
                    }

                    if (Fecskendo2)
                    {
                        soundlist.Add("2.wav");
                        soundlist.Add("fecskendo.wav");
                        soundlist.Add("h2.wav");
                        soundlist.Add("fecskendo_h.wav");
                    }

                    if (Erdoszer)
                    {
                        soundlist.Add("erdotuzes.wav");
                        soundlist.Add("erdotuzes_h.wav");
                    }

                    if (SpecErdoszer)
                    {
                        soundlist.Add("erdotuzes.wav");
                        soundlist.Add("muszakimento.wav");
                        soundlist.Add("muszakimento_h.wav");
                    }

                    if (Utanfuto)
                    {
                        soundlist.Add("utanfutoval.wav");
                        soundlist.Add("h3.wav");
                    }
                }

                SoundPlayer.Play(soundlist.ToArray(), true);
            }
        }

        private void bProbaAlert_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] { "figyelem_probariasztas.wav" }, false);
        }

        private void bDeleteAlert_Click(object sender, EventArgs e)
        {
            Riadolampa = false;
            if (WirelessContoller)
            {
                try
                {
                    SetLamp(Lamp1, false);
                }
                catch
                {
                    WirelessContoller = false;
                    MessageBox.Show("Megszakadt a kapcsolat a lámpavezérlővel.", "Kapcsolódási hiba!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            SoundPlayer.Stop();

            Tuzesethez = false;
            bFire.BackColor = Color.Red;

            Utanfuto = false;
            bUtanfuto.BackColor = Color.Green;

            SpecErdoszer = false;
            bSpecErdoszer.BackColor = Color.Green;

            Erdoszer = false;
            bErdoszer.BackColor = Color.Green;

            Fecskendo1 = false;
            bFecskendo1.BackColor = Color.Green;

            Fecskendo2 = false;
            bFecskendo2.BackColor = Color.Green;

            MuszakiMenteshez = false;
            bBackup.BackColor = Color.Lime;

            Osszesszer = false;
            bAll.BackColor = Color.Green;

            bAlert.BackColor = Color.FromArgb(255, 255, 128, 255);
        }

        private void bOutsideLoud_Click(object sender, EventArgs e)
        {
            if (!KulteriHangos)
            {
                KulteriHangos = true;
                if (WirelessContoller)
                {
                    try
                    {
                        SetLamp(Loud1, true);
                    }
                    catch
                    {
                        WirelessContoller = false;
                        MessageBox.Show("Megszakadt a kapcsolat a lámpavezérlővel.", "Kapcsolódási hiba!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                KulteriHangos = false;
                if (WirelessContoller)
                {
                    try
                    {
                        SetLamp(Loud1, false);
                    }
                    catch
                    {
                        WirelessContoller = false;
                        MessageBox.Show("Megszakadt a kapcsolat a lámpavezérlővel.", "Kapcsolódási hiba!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bAlertLamp_Click(object sender, EventArgs e)
        {
            if(!Riadolampa)
            {
                Riadolampa = true;
                if (WirelessContoller)
                {
                    try
                    {
                        SetLamp(Lamp1, true);
                    }
                    catch
                    {
                        WirelessContoller = false;
                        MessageBox.Show("Megszakadt a kapcsolat a lámpavezérlővel.", "Kapcsolódási hiba!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Riadolampa = false;
                if (WirelessContoller)
                {
                    try
                    {
                        SetLamp(Lamp1, false);
                    }
                    catch
                    {
                        WirelessContoller = false;
                        MessageBox.Show("Megszakadt a kapcsolat a lámpavezérlővel.", "Kapcsolódási hiba!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bAlertSound_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] { "h4.wav" }, false);
        }

        private void bSzolagatp_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] {"szolgalatparancsnok.wav", "h3.wav" }, false);
        }

        private void bChangeBegin_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] { "szolgalatvaltas_kezdete.wav" }, false);
        }

        private void bChangeEnd_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] { "szolgalatvaltas_vege.wav" }, false);
        }

        private void bWakeup_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play(new string[] { Properties.Settings.Default.WakeupSound }, false);
        }

        private void tConnection_Tick(object sender, EventArgs e)
        {
            CheckConnection();
        }

        private void pAlarm_Click(object sender, EventArgs e)
        {
            pAlarm.Visible = false;
        }

        private void tBlink_Tick(object sender, EventArgs e)
        {
            if (pAlarm.Visible)
            {
                if (pAlarm.BackColor == Color.Red)
                    pAlarm.BackColor = Color.Blue;
                else
                    pAlarm.BackColor = Color.Red;
            }
        }

        private static void SetLamp(int ID, bool state)
        {
            TimeSpan t = new TimeSpan(0, 0, 8);

            string url = ID.ToString();
            url += "/";
            if (state)
                url += "on";
            else
                url += "off";

            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };
            HttpClient client = new HttpClient(handler);
            client.Timeout = t;
            client.BaseAddress = new Uri("http://esp8266.local/");

            HttpResponseMessage response = client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
        }

        private void tSPort_Tick(object sender, EventArgs e)
        {
            try
            {
                if (SPort != null)
                {
                    if (SPort.IsOpen)
                    {
                        if (Riadolampa)
                            SPort.WriteLine(Lamp1.ToString() + "/1");
                        else
                            SPort.WriteLine(Lamp1.ToString() + "/0");
                        if (KulteriHangos)
                            SPort.WriteLine(Loud1.ToString() + "/1");
                        else
                            SPort.WriteLine(Loud1.ToString() + "/0");
                    }
                    else
                    {
                        SPort.Dispose();
                        SPort = null;
                    }
                }
                else if(SPort == null)
                {
                    using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
                    {
                        var portnames = SerialPort.GetPortNames();
                        var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                        var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                        foreach (string s in portList)
                        {
                            Console.WriteLine(s);
                            if (s.Contains("CP210"))
                            {
                                SPort = new SerialPort(s.Substring(0, s.IndexOf(" ")), 9600, Parity.None, 8, StopBits.One);
                                SPort.Open();
                                WiredController = true;
                                tSPort.Enabled = true;
                                tSPort.Start();
                                bOutsideLoud.BackColor = Color.Blue;
                                bOutsideLoud.Enabled = true;
                                bAlertLamp.BackColor = Color.OrangeRed;
                                bAlertLamp.Enabled = true;
                                bOutsideLoud.Invalidate();
                                bAlertLamp.Invalidate();
                                tSPort.Interval = 300;
                                break;
                            }
                        }
                        if (SPort == null)
                            throw new Exception("Nincs ilyen COM port.");
                        else if (!SPort.IsOpen)
                            throw new Exception("Nincs ilyen COM port.");
                    }
                }
            }
            catch
            {
                tSPort.Interval = 3000;
                if (WiredController)
                {
                    WiredController = false;
                    //tSPort.Enabled = false;
                    bOutsideLoud.BackColor = Color.Gray;
                    bOutsideLoud.Enabled = false;
                    bAlertLamp.BackColor = Color.Gray;
                    bAlertLamp.Enabled = false;
                    bOutsideLoud.Invalidate();
                    bAlertLamp.Invalidate();
                    MessageBox.Show("Megszakadt a kapcsolat a lámpavezérlővel.", "Kapcsolódási hiba!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            Settings = new SettingsScreen();
            Settings.ShowDialog();
        }

        private void bFecskendo1_Paint(object sender, PaintEventArgs e)
        {
            if (Fecskendo1)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bFecskendo1.Size.Width - 30, 1, 29, bFecskendo1.Size.Height - 2));
            }
        }

        private void bFecskendo2_Paint(object sender, PaintEventArgs e)
        {
            if (Fecskendo2)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bFecskendo2.Size.Width - 30, 1, 29, bFecskendo2.Size.Height - 2));
            }
        }

        private void bErdoszer_Paint(object sender, PaintEventArgs e)
        {
            if (Erdoszer)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bErdoszer.Size.Width - 30, 1, 29, bErdoszer.Size.Height - 2));
            }
        }

        private void bSpecErdoszer_Paint(object sender, PaintEventArgs e)
        {
            if (SpecErdoszer)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bSpecErdoszer.Size.Width - 30, 1, 29, bSpecErdoszer.Size.Height - 2));
            }
        }

        private void bUtanfuto_Paint(object sender, PaintEventArgs e)
        {
            if (Utanfuto)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bUtanfuto.Size.Width - 30, 1, 29, bUtanfuto.Size.Height - 2));
            }
        }

        private void bFire_Paint(object sender, PaintEventArgs e)
        {
            if (Tuzesethez)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bFire.Size.Width - 30, 1, 29, bFire.Size.Height - 2));
            }
        }

        private void bBackup_Paint(object sender, PaintEventArgs e)
        {
            if (MuszakiMenteshez)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bBackup.Size.Width - 30, 1, 29, bBackup.Size.Height - 2));
            }
        }

        private void bAll_Paint(object sender, PaintEventArgs e)
        {
            if (Osszesszer)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bAll.Size.Width - 30, 1, 29, bAll.Size.Height - 2));
            }
        }

        private void bOutsideLoud_Paint(object sender, PaintEventArgs e)
        {
            if (KulteriHangos && bOutsideLoud.Enabled)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bOutsideLoud.Size.Width - 30, 1, 29, bOutsideLoud.Size.Height - 2));
            }
        }

        private void bAlertLamp_Paint(object sender, PaintEventArgs e)
        {
            if (Riadolampa && bAlertLamp.Enabled)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.HotPink, new Rectangle(bAlertLamp.Size.Width - 30, 1, 29, bAlertLamp.Size.Height - 2));
            }
        }

        private void pAlarm_Paint(object sender, PaintEventArgs e)
        {
            if (qrCodeImage != null)
            {
                e.Graphics.DrawImage(qrCodeImage, (e.ClipRectangle.Width / 2) - (qrCodeImage.Width / 2), (e.ClipRectangle.Height / 2) + 50);
            }
        }

        private void Alarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Log Closing time
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = Path.Combine(path, "tuzoltosag_logs.txt"); ;
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("This is a log file for the tuzoltosag app!");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Closing: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
                sw.WriteLine("");
            }
        }
    }

    public static class ApplicationUpdate
    {
        private static Thread UpdateChecker = null;
        public static bool UpdateRequired
        {
            get
            {
                return Properties.Settings.Default.UpdateRequired;
            }
            set
            {
                Properties.Settings.Default.UpdateRequired = value;
                Properties.Settings.Default.Save();
            }
        }

        public static void CheckForUpdates()
        {
            if (UpdateChecker != null)
                if (UpdateChecker.IsAlive)
                {
                    UpdateChecker.Abort();
                    while (UpdateChecker.IsAlive) ;
                }
            UpdateChecker = new Thread(() => UpdateCheck());
            UpdateChecker.IsBackground = true;
            UpdateChecker.Start();
        }

        private static void UpdateCheck()
        {
            try
            {
                UpdateCheckInfo info = null;

                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                    try
                    {
                        info = ad.CheckForDetailedUpdate();

                    }
                    catch
                    {
                        return;
                    }

                    if (info.UpdateAvailable)
                    {
                        UpdateRequired = true;
                    }
                    else
                    {
                        UpdateRequired = false;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        public static void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("A program új verzióját jelenleg nem lehet letölteni. \n\nEllenőrizze az internet kapcsolatot, vagy próbálja meg később! Hiba: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Az új verzió keresése sikertelen. A ClickOnce csomag hibás. Please redeploy the application and try again. Hiba: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("Ezt az alkalmazást nem lehet frissíteni. Valószínűleg nem egy ClickOnce alkalmazás. Hiba: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("Elérhető egy frissítés. Telepíti most a frissítést?", "Frissítés elérhető", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("Az alkalmazás egy kötelező frissítést talált a mostani " +
                            "verzió és a " + info.MinimumRequiredVersion.ToString() +
                            "verzió között. Az alkalmazás most telepíti a frissítést és ujraindul.",
                            "Frissítés elérhető", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("Az alkalmazás frissítve lett és most ujraindul.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Nem lehet telepíteni a legújabb verziót. \n\nEllenőrizze az internet kapcsolatot, vagy próbálja meg később! Hiba: " + dde);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("A legfissebb verzióval rendelkezik!.");
                }
            }
        }
    }
}
