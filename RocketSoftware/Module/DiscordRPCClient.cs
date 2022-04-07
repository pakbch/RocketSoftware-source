using System;
using DiscordRPC;
using DiscordRPC.Message;

namespace RocketSoftware.Module
{
	// Token: 0x02000006 RID: 6
	public class DiscordRPCClient
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000040B4 File Offset: 0x000022B4
		public void Initialize()
		{
			this.client = new DiscordRpcClient("953675545676247051");
			this.client.OnReady += delegate(object sender, ReadyMessage e)
			{
			};
			this.client.OnPresenceUpdate += delegate(object sender, PresenceMessage e)
			{
			};
			this.client.Initialize();
			this.client.SetPresence(new RichPresence
			{
				Details = "HQ Proxy pool.",
				State = "https://vu.fr/rca-discord",
				Assets = new Assets
				{
					LargeImageKey = "logow",
					LargeImageText = "Client V0.0.2"
				}
			});
		}

		// Token: 0x0400001C RID: 28
		public DiscordRpcClient client;
	}
}
