using System;
namespace PasswordTask.Models
{
	public class User
	{
		public string name;
		public string surname;
		public int age;
		private string password;

		public User(string name,string surname,int age)
		{
			this.name = name;
			this.surname = surname;
			this.age = age;
		}

		public string Get()
		{
			return password;
        }

		public string Set(string password)=> this.password = password;

    }
}

