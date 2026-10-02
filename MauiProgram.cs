using Microsoft.Extensions.Logging;
using ProjetoOnboardingPage.ViewModels;
using ProjetoOnboardingPage.Views;

namespace ProjetoOnboardingPage
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddScoped<OnboardingViewModel>();
            builder.Services.AddScoped<OnboardingPage>();

            return builder.Build();
        }
    }
}
