using CSharpSharedData;

namespace BlazorWasmAppTelerik.Pages
{
   public partial class FetchData
   {
      private WeatherForecast[]? forecasts;

      protected override void OnInitialized()
      {
         forecasts = WeatherForecast.Data;
      }
   }
}