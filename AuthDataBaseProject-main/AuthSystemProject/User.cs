using System;
namespace AuthSystemProject
{
	public class User
	{
		public int Id { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string DisplayName { get; set;}
		public Roles Role{ get; set;}

        public User(string login, string password, string displayName, Roles role)
        {
            Login = login;
            Password = password;
            DisplayName = displayName;
            Role = role;
        }

        public enum Roles{
			USER, ADMIN
		}
	}
}

