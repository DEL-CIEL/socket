using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socketUDP
{
    public partial class Form1 : Form
    {
        private Socket SSockUDP;

        public Form1()
        {
            this.Text = "Communication par socket UDP";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.buttonCreerSocket = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.buttonRecevoir = new System.Windows.Forms.Button();
            this.buttonCLS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonCreerSocket
            // 
            this.buttonCreerSocket.Location = new System.Drawing.Point(343, 42);
            this.buttonCreerSocket.Name = "buttonCreerSocket";
            this.buttonCreerSocket.Size = new System.Drawing.Size(147, 22);
            this.buttonCreerSocket.TabIndex = 0;
            this.buttonCreerSocket.Text = "Créer Socket et Bind(IPeR)";
            this.buttonCreerSocket.UseVisualStyleBackColor = true;
            this.buttonCreerSocket.Click += new System.EventHandler(this.buttonCreerSocket_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(343, 85);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(147, 22);
            this.buttonFermer.TabIndex = 1;
            this.buttonFermer.Text = "Fermer Close()";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.Location = new System.Drawing.Point(343, 147);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(147, 22);
            this.buttonEnvoyer.TabIndex = 2;
            this.buttonEnvoyer.Text = "Envoyer SendTo(IPeD)";
            this.buttonEnvoyer.UseVisualStyleBackColor = true;
            this.buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
            // 
            // buttonRecevoir
            // 
            this.buttonRecevoir.Location = new System.Drawing.Point(343, 188);
            this.buttonRecevoir.Name = "buttonRecevoir";
            this.buttonRecevoir.Size = new System.Drawing.Size(147, 40);
            this.buttonRecevoir.TabIndex = 3;
            this.buttonRecevoir.Text = "Recevoir ReceiveFrom()\r\nBloquant Timeout";
            this.buttonRecevoir.UseVisualStyleBackColor = true;
            this.buttonRecevoir.Click += new System.EventHandler(this.buttonRecevoir_Click);
            // 
            // buttonCLS
            // 
            this.buttonCLS.Location = new System.Drawing.Point(343, 322);
            this.buttonCLS.Name = "buttonCLS";
            this.buttonCLS.Size = new System.Drawing.Size(65, 22);
            this.buttonCLS.TabIndex = 4;
            this.buttonCLS.Text = "CLS";
            this.buttonCLS.UseVisualStyleBackColor = true;
            this.buttonCLS.Click += new System.EventHandler(this.buttonCLS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Recp.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "IPeR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Envoi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Dest.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "IPeD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Recp.";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(80, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(186, 47);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(60, 20);
            this.textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(80, 82);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(186, 82);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(60, 20);
            this.textBox9.TabIndex = 14;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(82, 215);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(255, 129);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(80, 147);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(257, 62);
            this.richTextBox3.TabIndex = 16;
            this.richTextBox3.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(516, 383);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCLS);
            this.Controls.Add(this.buttonRecevoir);
            this.Controls.Add(this.buttonEnvoyer);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonCreerSocket);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress iPAddress = ipHostEntry.AddressList[6];

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());

            IPEndPoint IPedD = new IPEndPoint(iPAddress, 50000);
            IPEndPoint IPedR = new IPEndPoint(iPAddress, 50000);
            EndPoint IPedFrom = new IPEndPoint(iPAddress, 50000);
            socket.Bind(IPedR);

            var msg = Encoding.ASCII.GetBytes("Bonjour UDP");
            socket.SendTo(msg, IPedD);

            var buffer = new byte[1024];
            socket.ReceiveFrom(buffer, ref IPedFrom);
            socket.Close();

            this.richTextBox3.Text += Encoding.ASCII.GetString(buffer, 0, buffer.Length);
        }

        private void buttonCreerSocket_Click(object sender, EventArgs e)
        {
            this.SSockUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress ip = IPAddress.Parse(this.textBox6.Text);
            int port = int.Parse(this.textBox7.Text);
            IPEndPoint iped = new IPEndPoint(ip, port);

            this.SSockUDP.Connect(iped);

            this.richTextBox2.Text += "Connexion créée vers " + ip + ':' + port + '\n';
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.SSockUDP.Shutdown(SocketShutdown.Both);
            this.SSockUDP.Close();

        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            this.SSockUDP.Send(Encoding.ASCII.GetBytes(this.richTextBox3.Text));
        }

        private void buttonRecevoir_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];
            this.SSockUDP.Receive(buffer);
        }

        private void buttonCLS_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Text = "";
        }
    }
}
