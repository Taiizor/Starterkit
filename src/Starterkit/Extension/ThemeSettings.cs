using Microsoft.Extensions.Configuration;

namespace Starterkit.Extension
{
    public class ThemeSettings
    {
        public static ThemeBase Config;

        public static void Init(IConfiguration Configuration, string Key)
        {
            Config = Configuration.GetSection(Key).Get<ThemeBase>();
        }
    }
}