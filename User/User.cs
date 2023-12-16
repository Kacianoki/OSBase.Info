namespace OSBase.User
{
        public enum Permision
        {
            System = 4,
            Administrator = 3,
            User = 2,
            Program = 1,
            None = 0
        }
    public class User
    {
        public string Name = "" ?? "User";
        public Permision Permision = Permision.User;
        public string Password = "" ?? "PasswordIsNotSet";
        public User(string name, Permision permision) { Name = name; Permision = permision; }
        public User(string name, Permision permision, string password) { Name = name; Permision = permision; Password = password; }
    }
}
