using System;

namespace DotNetSdk
{
    public static class ProductName
    {
        public static SdkConfiguration DefaultConfiguration { get; set; }

        static ProductName()
        {
            DefaultConfiguration = new SdkConfiguration();
        }

        public static void Configure(Action<SdkConfiguration> mutator)
        {
            mutator = mutator ?? (c => { });
            mutator(DefaultConfiguration);
        }

        public static ProductNameClient CreateClient(string apiKey)
        {
            DefaultConfiguration.ApiKey = apiKey;
            return new ProductNameClient(DefaultConfiguration);
        }
    }
}