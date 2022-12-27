using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorWasmAppBlazorise
{
    public class Program
    {
        public static async Task Main( string[] args )
        {
            var builder = WebAssemblyHostBuilder.CreateDefault( args );
            builder.RootComponents.Add<App>( "#app" );
            builder.RootComponents.Add<HeadOutlet>( "head::after" );

            builder.Services
                .AddBlazorise()
                .AddBootstrap5Providers()
                .AddFontAwesomeIcons();
            builder.Services.AddScoped( sp => new HttpClient { BaseAddress = new Uri( builder.HostEnvironment.BaseAddress ) } );

            await builder.Build().RunAsync();
        }
    }
}