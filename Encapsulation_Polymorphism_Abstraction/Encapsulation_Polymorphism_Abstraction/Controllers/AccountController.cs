using System;
using Encapsulation_Polymorphism_Abstraction.Helpers.Constants;
using Encapsulation_Polymorphism_Abstraction.Services;

namespace Encapsulation_Polymorphism_Abstraction.Controllers
{
	public class AccountController
	{
		private readonly AccountService _accountService;
		public AccountController()
		{
			_accountService = new AccountService();
		}
		public void Login()
		{
			Email:  Console.WriteLine("Add Your Email:");
			string email = Console.ReadLine();
			if (!email.Contains('@'))
			{
				Console.WriteLine(ResponseMessages.IncorrectEmailFormat);
				goto Email;
			}

			Console.WriteLine("Add Your Password:");
			string password = Console.ReadLine();

			var response = _accountService.Login(email,password);
			if (response)
			{
				Console.WriteLine(ResponseMessages.LoginSuccess);
			}
			else
			{
				Console.WriteLine(ResponseMessages.LoginFailed );
			}
		}
	}
}

