using Microsoft.Extensions.Logging;

namespace MauiAppHotel1
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
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                    fonts.AddFont("Quicksand-Bold.ttf", "QuickSandBold");
                    fonts.AddFont("Quicksand-Regular.ttf", "QuickSand");
                    fonts.AddFont("Quicksand-Light.ttf", "QuickSandLight");
                    fonts.AddFont("Quicksand-Medium.ttf", "QuickSandMedium");
                    fonts.AddFont("Quicksand-SemiBold.ttf", "QuickSandSemiBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
