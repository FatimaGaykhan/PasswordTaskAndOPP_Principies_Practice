 using System;
namespace Encapsulation_Polymorphism_Abstraction.Models
{
	public abstract class Animal
	{
		public string Name { get; set; }

		public abstract void Test();

		public virtual void Sound() 
		{
			Console.WriteLine("Animal Sound");
		}
	}
}

