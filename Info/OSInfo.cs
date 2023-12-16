namespace OSBase
{
    using Newtonsoft.Json;
    public class ConsoleOSInfo
    {
        public string Name { get; }
        public string Type { get; } = "console";
        public ConsoleOSInfo(string name)
        {
            Name = name ?? "MyNewOS";
            File.WriteAllText("OSInfo.json", JsonConvert.SerializeObject(this));
        }
    }
}