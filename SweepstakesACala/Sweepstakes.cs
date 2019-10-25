using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesACala
{
    class Sweepstakes
    {
        //member variables
        Dictionary<int, Contestant> Contestants = new Dictionary<int, Contestant>();





        //constructor
        public Sweepstakes(string name)
        {

        }



        //method

        void RegisterContestant(Contestant contestant)
        {
       
        }

        Contestant PickWinner()
        {
            // randomly select winner
        }


        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegistrationNumber);

        }

    }
}
