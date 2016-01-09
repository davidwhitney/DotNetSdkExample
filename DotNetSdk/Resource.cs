namespace DotNetSdk
{
    public abstract class Resource
    {
        public SdkConfiguration Configuration { get; set; }

        protected Resource(SdkConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}