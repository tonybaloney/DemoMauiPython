using CSnakes.Runtime;
using Microsoft.Extensions.Logging;

namespace DemoMauiPython
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            var home = Path.Join(Environment.CurrentDirectory, "python");
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.WithPython()
                .WithHome(home)
                .FromRedistributable()
                .WithPipInstaller();

            return builder.Build();
        }
    }
}
