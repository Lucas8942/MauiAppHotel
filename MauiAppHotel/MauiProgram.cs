using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("PlaypenSansDeva-Bold.ttf", "PlaypenSansDevaBold");
                    fonts.AddFont("PlaypenSansDeva-ExtraBold.ttf", "PlaypenSansDevaExtraBold");
                    fonts.AddFont("PlaypenSansDeva-ExtraLight.ttf", "PlaypenSansDevaExtraLight");
                    fonts.AddFont("PlaypenSansDeva-Light.ttf", "PlaypenSansDevaLight");
                    fonts.AddFont("PlaypenSansDeva-Medium.ttf", "PlaypenSansDevaMedium");
                    fonts.AddFont("PlaypenSansDeva-Regular.ttf", "PlaypenSansDeva");
                    fonts.AddFont("PlaypenSansDeva-SemiBold.ttf", "PlaypenSansDevaSemiBold");
                    fonts.AddFont("PlaypenSansDeva-Thin.ttf", "PlaypenSansDevaThin");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
