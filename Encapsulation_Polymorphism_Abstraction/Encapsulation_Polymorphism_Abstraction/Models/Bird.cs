using System;
namespace Encapsulation_Polymorphism_Abstraction.Models
{
	public class Bird:Animal
	{
		public string Color { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Bird Sound");
        }

        public override void Test()
        {
            Console.WriteLine("tested");
        }
    }
}

