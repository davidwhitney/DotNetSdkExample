using DotNetSdk.Resources;

namespace DotNetSdk
{
    public interface IProductNameClient
    {
        SdkConfiguration Configuration { get; set; }
        IResource1 Resource1 { get; set; }
        IResource2 Resource2 { get; set; }
    }
}