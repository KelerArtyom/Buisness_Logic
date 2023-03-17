using System;
using static AuthSystemProject.User;

namespace AuthSystemProject
{
	public class Authorization
	{
		private User? User = null;

		private UsersDataBaseMock UsersDataBaseMock;

        public Authorization(UsersDataBaseMock usersDataBaseMock)
        {
            UsersDataBaseMock = usersDataBaseMock;
        }

        public void Login(string login, string pass)
		{
			User? user = UsersDataBaseMock.Get(login, pass);

			if (user != null)
			{
				User = user;
			
			}
		}

		public void LogOut() {
			User = null;
		}

		public bool IsAuth() {
			return User != null;
		}

		public string GetName() {
			return User.DisplayName;
		}

		public Roles GetRole() {
			return User.Role;
		}
		
		
	}
}

