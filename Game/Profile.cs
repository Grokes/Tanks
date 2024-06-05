namespace Tanks.Game
{
    public class Profile: IProfile
    {
        private Dictionary<string, string> _profiles = new Dictionary<string, string>()
        {
            {"admin", "admin" },
            {"vasya", "vasya" },
            {"1234", "1234" }
        };

        public bool ValidateProfile(string login, string pass)
        {
            if (!_profiles.ContainsKey(login)) 
            {
                return false;
            }
            if (_profiles[login] != pass) 
            {
                return false;
            }
            return true;
        }
    }
}
