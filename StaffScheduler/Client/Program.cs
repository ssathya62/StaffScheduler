using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StaffScheduler.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{

			

			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
			var keyPart = builder.Configuration["Syncfusion:Erandhu"];
			var keyaPart = builder.Configuration["Syncfusion:Mudhal"];

			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(keyaPart.Trim()+keyPart.Trim());			
			builder.Services.AddSyncfusionBlazor();
			await builder.Build().RunAsync();
		}
	}
}
