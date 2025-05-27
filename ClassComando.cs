using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ExerciseCommando
{


	 static public class Commando
	{
		string Name;
		string CodeName;
		string[] Arms = new string[5];
		string Status;


		public Commando(string name, string codename, string status, string arms[5])
		{
			Name = name;
			CodeName = codename;
			Status = status;
			Arms = arms;



		}

		static void Walk()
		{
			Status = "Walking";
			Console.WriteLine($"{CodeName} is Walking right now ! ")
		}

        static void Hide()
        {
            Status = "Hidding";
            Console.WriteLine($"{CodeName} is Hidding right now ! ")

        }

        static void Attack()
        {
            Status = "Attacking";
            Console.WriteLine($"{CodeName} is Attacking right now ! ")

        }






    }


}