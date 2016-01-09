namespace DotNetSdk.Serialization
{
    public interface ISerializeMessages
    {
        string Serialize<T>(T type);
        T Deserialize<T>(string stringData);
    }
}
