using System;
using Encapsulation_Polymorphism_Abstraction.Models;

namespace Encapsulation_Polymorphism_Abstraction.Services
{
	public class UserService
	{
		public User[] GetAll()
		{
			return new User[]
			{
				new User
				{
					id=1,
					fullname="Fatima Gaykhanova",
					email="fatima@code.edu.az",
					password="fatima123",
					age=22
				},
                new User
                {
                    id=2,
                    fullname="Sadigkhan Gaykhanov",
                    email="sadigkhan@code.edu.az",
                    password="sadigkhan123",
                    age=26
                },
                new User
                {
                    id=3,
                    fullname="Sharif Gaykhanov",
                    email="sharif@code.edu.az",
                    password="sharif123",
                    age=32
                },

            };
		}

		public User GetById(User[] users,int id)
        {
            return users.Where(m => m.id == id).FirstOrDefault();
        }
	}
}

