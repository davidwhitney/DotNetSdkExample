using DotNetSdk.Models.Resource1;

namespace DotNetSdk.Resources
{
    public class Resource1 : Resource, IResource1
    {
        public Resource1(SdkConfiguration configuration) : base(configuration)
        {
        }

        public SomeGetModel Get()
        {
            return new SomeGetModel();
        }
    }
}
