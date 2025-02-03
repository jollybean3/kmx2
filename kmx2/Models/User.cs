namespace kmx2.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Salt { get; private set; }
        public List<Room>? Rooms { get; private set; }

        public User(string userName, string password, string confirmPassword) 
        {
            if (userName.Length < 5)
                throw new Exception("UserName must be at least 5 characters long.");

            if (password.Length < 4)
                throw new Exception("Password must be at least 4 characters long.");

            if (password != confirmPassword)
                throw new Exception("Passwords do not match");

            UserName = userName;
            SetPassword(password);
        }

        public void SetPassword(string password)
        {
            Salt = password;
            Password = password;
        }
    }
}
