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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(343, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 22);
            this.button6.TabIndex = 0;
            this.button6.Text = "Créer Socket et Bind(IPeR)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(343, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 22);
            this.button7.TabIndex = 1;
            this.button7.Text = "Fermer Close()";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(343, 147);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 22);
            this.button8.TabIndex = 2;
            this.button8.Text = "Envoyer SendTo(IPeD)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(343, 188);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(147, 40);
            this.button9.TabIndex = 3;
            this.button9.Text = "Recevoir ReceiveFrom()\r\nBloquant Timeout";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(343, 322);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 22);
            this.button10.TabIndex = 4;
            this.button10.Text = "CLS";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
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
            this.richTextBox2.Location = new System.Drawing.Point(80, 215);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(203, 129);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(80, 147);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(205, 62);
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
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
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
            socket.SendTo(msg, IPedFrom);

            var buffer = new byte[1024];
            socket.ReceiveFrom(buffer, ref IPedFrom);
            socket.Close();

            this.richTextBox3.Text += Encoding.ASCII.GetString(buffer, 0, buffer.Length);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
