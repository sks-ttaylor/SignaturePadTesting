using Blazorise;
using Blazorise.Bootstrap5;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SignaturePadTesting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorise(options =>
{
  options.Immediate = false;
  options.Debounce = false;//true;
  options.DebounceInterval = 0;// 300;
  options.ShowNumericStepButtons = false;
  options.IconStyle = IconStyle.Solid;
  options.IconSize = IconSize.Small;
  options.ProductToken = "CjxRA3B/NQE9WwB0fD01BlEAc3o0CD1UAHl9MAs1bjoNJ2ZdYhBVCCo/CT1WPUsNalV8Al44B2ECAWllMit3cWhZPUsHdXk/MwR5OTwXPFd8JARrTVwTZG4nX2w1KWQxB21uexV3CjhNCSNWQ3YsYxdkMXYNHlBPTxtXFiRrSlg3Zyskdmk6CFkpAXMTShZ6dzR/Sm9QcwsGYWhcGUECB0sAYRJabiRKE0UJd3N7MmwjAXN2dk16fgdhKChCbDQzdCgtNHp9IXJ2LWlqWxVnCTQyXk42dhgFb345G0Y4BnFIXSUIEz5hdk8VWjM9Vk8x";
})
.AddBootstrap5Providers();


await builder.Build().RunAsync();
