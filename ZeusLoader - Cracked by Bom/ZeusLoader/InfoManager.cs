using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000E RID: 14
	internal class InfoManager
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00002287 File Offset: 0x00000487
		public InfoManager()
		{
			this.lastGateway = this.GetGatewayMAC();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000229D File Offset: 0x0000049D
		public void StartListener()
		{
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000048C0 File Offset: 0x00002AC0
		private void OnCallBack()
		{
			this.timer.Dispose();
			bool flag = !(this.GetGatewayMAC() == this.lastGateway);
			if (flag)
			{
				Constants.Breached = true;
				MessageBox.Show("ARP Cache poisoning has been detected!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				this.lastGateway = this.GetGatewayMAC();
			}
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004948 File Offset: 0x00002B48
		public static IPAddress GetDefaultGateway()
		{
			return (from g in (from n in NetworkInterface.GetAllNetworkInterfaces()
			where n.OperationalStatus == OperationalStatus.Up
			where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
			select n).SelectMany(delegate(NetworkInterface n)
			{
				IPInterfaceProperties ipproperties = n.GetIPProperties();
				return (ipproperties != null) ? ipproperties.GatewayAddresses : null;
			})
			select (g != null) ? g.Address : null into a
			where a != null
			select a).FirstOrDefault<IPAddress>();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004A18 File Offset: 0x00002C18
		private string GetArpTable()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			string result;
			using (Process process = Process.Start(new ProcessStartInfo
			{
				FileName = pathRoot + "Windows\\System32\\arp.exe",
				Arguments = "-a",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}))
			{
				using (StreamReader standardOutput = process.StandardOutput)
				{
					result = standardOutput.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004ABC File Offset: 0x00002CBC
		private string GetGatewayMAC()
		{
			string arg = InfoManager.GetDefaultGateway().ToString();
			string pattern = string.Format("({0} [\\W]*) ([a-z0-9-]*)", arg);
			Regex regex = new Regex(pattern);
			Match match = regex.Match(this.GetArpTable());
			return match.Groups[2].ToString();
		}

		// Token: 0x04000030 RID: 48
		private Timer timer;

		// Token: 0x04000031 RID: 49
		private string lastGateway;
	}
}
