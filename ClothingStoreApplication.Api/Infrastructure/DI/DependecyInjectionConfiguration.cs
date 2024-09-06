using ClothingStoreApplication.Api.Infrastructure.AppSettings;

namespace ClothingStoreApplication.Api.Infrastructure.DI
{
    public class DependecyInjectionConfiguration
    {
        public static void ConfigureServices(IServiceCollection services) 
        {
            
        }
        /*************************************USAGE***************************************************/
        /*private readonly AppSettings _settings;

        public SomeService(IOptions<AppSettings> settings)
        {
        _settings = settings.Value;
        }

        public void SomeMethod()
        {
        var apiBaseUrl = _settings.ApiBaseUrl;
        // Use the settings as needed
        }*/
    }
}
