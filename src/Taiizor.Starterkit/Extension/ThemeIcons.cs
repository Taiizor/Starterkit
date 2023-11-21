using Microsoft.Extensions.Configuration;

namespace Taiizor.Starterkit.Extension
{
    public class ThemeIcons
    {
        public static SortedDictionary<string, int> Config { get; set; } = [];

        public static void Init(string Path, string Key)
        {
            IConfiguration Configuration = new ConfigurationBuilder()
                .AddJsonFile(Path)
                .Build();

            Init(Configuration, Key);
        }

        public static void Init(IConfiguration Configuration, string Key)
        {
            Config = Configuration.GetSection(Key).Get<SortedDictionary<string, int>>() ?? Config;
        }
    }
}