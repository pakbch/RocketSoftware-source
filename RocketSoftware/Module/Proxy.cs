using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace RocketSoftware.Module
{
	// Token: 0x02000008 RID: 8
	public class Proxy
	{
		// Token: 0x06000020 RID: 32
		[DllImport("wininet.dll")]
		public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

		// Token: 0x06000021 RID: 33 RVA: 0x00004184 File Offset: 0x00002384
		public static void setProxy(string proxyhost, bool proxyEnabled)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "ProxyServer", proxyhost);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "ProxyEnable", proxyEnabled ? "1" : "0");
			Proxy.InternetSetOption(IntPtr.Zero, 39, IntPtr.Zero, 0);
			Proxy.InternetSetOption(IntPtr.Zero, 37, IntPtr.Zero, 0);
		}

		// Token: 0x04000020 RID: 32
		public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;

		// Token: 0x04000021 RID: 33
		public const int INTERNET_OPTION_REFRESH = 37;
	}
}
