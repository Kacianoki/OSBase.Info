namespace OSBase
{
    public abstract class ConsoleOS
    {
        public abstract ConsoleOSInfo osinfo { get; }
        public ConsoleOS() { }
    }
    public abstract class OSInstaller
    {
        public abstract void Install();
        public abstract void Uninstall();
        public abstract void FastInstall();
        public abstract void FastDelete();
        public OSInstaller() { }
    }
}
