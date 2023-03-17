using System;
using static AuthSystemProject.User;

namespace AuthSystemProject
{
	public class UsersDataBaseMock
	{
		private User[] Users;

		public UsersDataBaseMock(int length)
		{
			Users = new User[length];
			Init();
		}

		public User[] GetAll()
		{
			return Users;
		}

		public User? Get(string login, string pass)
		{
			foreach (User u in Users)
			{
				if (u.Login.Equals(login) && u.Password.Equals(pass))
				{
					return u;
				}
			}

			return null;
		}

		public User? GetById(int id)
		{
			foreach (User u in Users)
			{
				if (u.Id == id)
				{
					return u;
				}
			}

			return null;
		}

		private void Init()
		{
			for (int i = 0; i < Users.Length; i++)
			{
				Users[i] = new User(
					"Login" + i,
					"Pass" + i,
					"DisplayName" + i,
					GenerateRole()
					);
				Users[i].Id = i;
			}
		}

		private static Roles GenerateRole()
		{
			Random random = new();
			Roles[] roles = (Roles[]) Enum.GetValues(Roles.ADMIN.GetType());
			return roles[random.Next(roles.Length)];
		} 
	}
}

