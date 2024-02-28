using System;
using Encapsulation_Polymorphism_Abstraction.Helpers.Constants;
using Encapsulation_Polymorphism_Abstraction.Services;

namespace Encapsulation_Polymorphism_Abstraction.Controllers
{
	public class UserController
	{
		private readonly UserService _userService;
		public UserController()
		{
			_userService = new UserService();
		}

		public void GetAll()
		{
			var users = _userService.GetAll();

			foreach (var user in users)
			{
				var result=$"{user.fullname} - {user.email}-{user.age}";
				Console.WriteLine(result);
			}
		}

		public void GetById()
		{
			Console.WriteLine("Add user id");
			UserId: string strId = Console.ReadLine();
			int id;
			bool IsCorrectId = int.TryParse(strId, out id);
			if (IsCorrectId)
			{
                var user = _userService.GetById(_userService.GetAll(), id);
                if (user == null)
                {
                    Console.WriteLine(ResponseMessages.NotFound);
                    return;
                }
                
                
               var result = $"{user.fullname} - {user.email}-{user.age}";
               Console.WriteLine(result);

			}
			else
			{
				Console.WriteLine(ResponseMessages.IncorrectNumberFormat);
				goto UserId;
			}
		
            
        }
	}
}

