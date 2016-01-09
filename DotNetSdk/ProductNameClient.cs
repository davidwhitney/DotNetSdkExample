using DotNetSdk.Resources;

namespace DotNetSdk
{
    public class ProductNameClient : IProductNameClient
    {
        public SdkConfiguration Configuration { get; set; }
        public IResource1 Resource1 { get; set; }
        public IResource2 Resource2 { get; set; }

        public ProductNameClient(SdkConfiguration configuration)
        {
            Configuration = configuration;
            Resource1 = new Resource1(Configuration);
            Resource2 = new Resource2(Configuration);
        }
    }
}
