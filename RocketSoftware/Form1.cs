using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Leaf.xNet;
using RocketSoftware.Module;

namespace RocketSoftware
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		public Form1()
		{
			this.InitializeComponent();
			new DiscordRPCClient().Initialize();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000206F File Offset: 0x0000026F
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002071 File Offset: 0x00000271
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://vu.fr/rca-discord");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000207E File Offset: 0x0000027E
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://stats.uptimerobot.com/PKzy0h0Dp2");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000208C File Offset: 0x0000028C
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			using (HttpRequest httpRequest = new HttpRequest())
			{
				this.richTextBox1.AppendText("Changing ip address.\n");
				string text = httpRequest.Get("https://api.ipify.org", null).ToString();
				this.guna2TextBox1.Text = text;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206F File Offset: 0x0000026F
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020EC File Offset: 0x000002EC
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			if (this.guna2TextBox2.Text == "")
			{
				MessageBox.Show("Please provide your api key.");
				return;
			}
			this.richTextBox1.AppendText("Updating your ip address.\n");
			using (HttpRequest httpRequest = new HttpRequest())
			{
				this.richTextBox1.AppendText("Changing ip address.\n");
				string text = httpRequest.Get("http://62.4.29.235/change_ip?ip=" + this.guna2TextBox1.Text + "&api_key=" + this.guna2TextBox2.Text, null).ToString();
				if (text.Contains("success"))
				{
					this.richTextBox1.AppendText("Successfully changed ip address to " + this.guna2TextBox1.Text + ".\n");
				}
				else
				{
					MessageBox.Show(text + "\n");
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021D8 File Offset: 0x000003D8
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			string text = this.guna2ComboBox1.SelectedItem.ToString();
			if (text == "")
			{
				MessageBox.Show("Please select pool to connect !");
				return;
			}
			if (text == "ALL")
			{
				string proxyhost = "62.4.29.235:1339";
				if (!this.active)
				{
					this.active = true;
					Proxy.setProxy(proxyhost, this.active);
					this.guna2Button3.Text = "Disconnect";
					this.richTextBox1.AppendText("Now Connected to " + text + " Pool !\n");
					return;
				}
				this.active = false;
				Proxy.setProxy("", this.active);
				this.guna2Button3.Text = "Connect";
				this.richTextBox1.AppendText("You are now Disconnected.\n");
				return;
			}
			else if (text == "BR")
			{
				string proxyhost2 = "62.4.29.235:1343";
				if (!this.active)
				{
					this.active = true;
					Proxy.setProxy(proxyhost2, this.active);
					this.guna2Button3.Text = "Disconnect";
					this.richTextBox1.AppendText("Now Connected to " + text + " Pool !\n");
					return;
				}
				this.active = false;
				Proxy.setProxy("", this.active);
				this.guna2Button3.Text = "Connect";
				this.richTextBox1.AppendText("You are now Disconnected.\n");
				return;
			}
			else if (text == "DE")
			{
				string proxyhost3 = "62.4.29.235:1342";
				if (!this.active)
				{
					this.active = true;
					Proxy.setProxy(proxyhost3, this.active);
					this.guna2Button3.Text = "Disconnect";
					this.richTextBox1.AppendText("Now Connected to " + text + " Pool !\n");
					return;
				}
				this.active = false;
				Proxy.setProxy("", this.active);
				this.guna2Button3.Text = "Connect";
				this.richTextBox1.AppendText("You are now Disconnected.\n");
				return;
			}
			else if (text == "FR")
			{
				string proxyhost4 = "62.4.29.235:1340";
				if (!this.active)
				{
					this.active = true;
					Proxy.setProxy(proxyhost4, this.active);
					this.guna2Button3.Text = "Disconnect";
					this.richTextBox1.AppendText("Now Connected to " + text + " Pool !\n");
					return;
				}
				this.active = false;
				Proxy.setProxy("", this.active);
				this.guna2Button3.Text = "Connect";
				this.richTextBox1.AppendText("You are now Disconnected.\n");
				return;
			}
			else if (text == "US")
			{
				string proxyhost5 = "62.4.29.235:1341";
				if (!this.active)
				{
					this.active = true;
					Proxy.setProxy(proxyhost5, this.active);
					this.guna2Button3.Text = "Disconnect";
					this.richTextBox1.AppendText("Now Connected to " + text + " Pool !\n");
					return;
				}
				this.active = false;
				Proxy.setProxy("", this.active);
				this.guna2Button3.Text = "Connect";
				this.richTextBox1.AppendText("You are now Disconnected.\n");
				return;
			}
			else
			{
				string proxyhost6 = "62.4.29.235:6968";
				if (!this.active)
				{
					this.active = true;
					Proxy.setProxy(proxyhost6, this.active);
					this.guna2Button3.Text = "Disconnect";
					this.richTextBox1.AppendText("Now Connected to " + text + " Pool !\n");
					return;
				}
				this.active = false;
				Proxy.setProxy("", this.active);
				this.guna2Button3.Text = "Connect";
				this.richTextBox1.AppendText("You are now Disconnected.\n");
				return;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002584 File Offset: 0x00000784
		private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.active)
			{
				this.active = false;
				Proxy.setProxy("", this.active);
				this.guna2Button3.Text = "Connect";
				this.richTextBox1.AppendText("You are now Disconnected.\n");
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000025D0 File Offset: 0x000007D0
		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.richTextBox1.Text = "";
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000206F File Offset: 0x0000026F
		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000206F File Offset: 0x0000026F
		private void guna2TextBox3_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000025E4 File Offset: 0x000007E4
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			string text = this.guna2TextBox1.Text;
			string text2 = this.guna2TextBox3.Text;
			string text3 = this.guna2TextBox2.Text;
			if (text == "" || text2 == "" || text3 == "")
			{
				MessageBox.Show("Please provide:\n- Username\n- Valid api key\n- Ip address");
				return;
			}
			this.richTextBox1.AppendText("Activating account.\n");
			using (HttpRequest httpRequest = new HttpRequest())
			{
				string text4 = httpRequest.Get(string.Concat(new string[]
				{
					"http://62.4.29.235/activate?ip=",
					text,
					"&username=",
					text2,
					"&api_key=",
					text3
				}), null).ToString();
				if (text4.Contains("success"))
				{
					this.richTextBox1.AppendText("Successfully Activated key, proxy address and informations are in ./proxy_info.txt.\n");
					using (StreamWriter streamWriter = File.CreateText("./proxy_info.txt"))
					{
						streamWriter.WriteLine("Proxy address: 62.4.29.235");
						streamWriter.WriteLine("Mixed country port: 1339");
						streamWriter.WriteLine("FR port: 1340");
						streamWriter.WriteLine("US port: 1341");
						streamWriter.WriteLine("DE port: 1342");
						streamWriter.WriteLine("BR port: 1343");
						return;
					}
				}
				MessageBox.Show(text4 + "\n");
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002758 File Offset: 0x00000958
		private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://0xvichy.sellix.io/terms");
		}

		// Token: 0x04000001 RID: 1
		public bool active;
	}
}
