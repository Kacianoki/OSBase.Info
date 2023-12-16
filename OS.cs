namespace OSBase
{
    public abstract class ConsoleOS
    {
        public abstract ConsoleOSInfo osinfo { get; }
        public abstract void Main();
    }
}
