using Microsoft.Maui.Controls.Hosting;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Microsoft.Extensions.Logging;

namespace WevmusicLogin;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseSkiaSharp()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("LatoBold.ttf", "Bold");
                fonts.AddFont("LatoRegular.ttf", "Medium");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
