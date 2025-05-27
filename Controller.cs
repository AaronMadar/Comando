using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCommando
{
    internal class Controller
    {
        public void SayName(Commando commando, string Rank)
        {
            if (Rank.ToUpper() == "GENERAL")
            {
                Console.WriteLine(commando.GetName());

            }

            else if (Rank.ToUpper() == "Colonel")
            {
                Console.WriteLine(commando.CodeName);
            }

            else
            {
                Console.WriteLine("Private Information ");

            }
        }


            
        


    }
}
