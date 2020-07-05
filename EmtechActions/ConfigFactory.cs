using Microsoft.Extensions.Configuration;

namespace EmtechActions
{
    internal class ConfigFactory
    {
        MauticConfig GetMauticConfiguration()
        {
            return new MauticConfig();
        }
        
    }
}