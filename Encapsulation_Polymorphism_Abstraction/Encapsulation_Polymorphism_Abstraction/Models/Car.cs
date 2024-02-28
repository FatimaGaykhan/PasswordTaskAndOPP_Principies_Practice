using System;
namespace Encapsulation_Polymorphism_Abstraction.Models
{
	public class Car
	{
		public string name;
		public int speed;
		private string color="red";
		public string Color
		{
			get
			{
				if (speed>400)
				{
                    return color;
                }
				return null;
			}
			set
			{
				color = value;
			}
		}



	}
}

