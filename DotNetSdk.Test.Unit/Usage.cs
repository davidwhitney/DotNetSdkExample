using NUnit.Framework;

namespace DotNetSdk.Test.Unit
{
    [TestFixture]
    public class Usage
    {
        [Test]
        public void Example()
        {
            //ProductName.DefaultConfiguration.Interceptors.Add(/*something*/);
            //ProductName.DefaultConfiguration.Serializer = // some custom serializer
            //ProductName.DefaultConfiguration.Transport = // some other http abstraction

            ProductName.DefaultConfiguration
                       .WithInterceptor<MyRandomInterceptor>();

            var client = ProductName.CreateClient("123");
            var typedResponse = client.Resource1.Get();
        }
    }
}
