using System;

namespace ExerciseCommando
{

	static public class Weapons
	{
		string Name;
		string Manufacturer;
		int NumberOfBalls;

		public Weapons(string name, string manufacturer, int numberofballs)
		{
			Name = name;
			Manufacturer = manufacturer;
			NumberOfBalls = numberofballs;


		}

		public void Shoot()
		{
			NumberOfBalls--;
			Console.WriteLine("BOOM !");
		}

		
	}


}