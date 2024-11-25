namespace GeniyIdiot.Common
{
    public class UsersResultStorage
    {
        public List<User> UserResults;
        public string Path = @"Results.json";
        public FileHelper FileHelper;
        public UsersResultStorage()
        {
            this.UserResults = new List<User>();
            this.Path = Path;
            this.FileHelper = new FileHelper(Path);
        }

        public List<User> GetAll()
        {
            if (!System.IO.File.Exists(Path))
            {
                var nullResult = new List<User>();
                FileHelper.Write(nullResult);
            }
            var users = FileHelper.Read<User>();
            return users;
        }

        public void Save(User user)
        {
            var allResults = GetAll();
            allResults.Add(user);
            FileHelper.Write(allResults);
        }
    }
}
