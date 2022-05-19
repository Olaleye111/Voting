using System;
using System.Collections.Generic;
using VotingSystem.Model;
using VotingSystem.Enum;
//using VotingSystem.Admin;

namespace VotingSystem.Admin
{
    public class VoterAdmin
    {
        private static int VotersCount = 0;
        List<string> StudentInSchool = new List<string>(){"CLH/18/0001","CLH/18/0002","CLH/18/0003","CLH/18/0004","CLH/18/0005","CLH/19/0006","CLH/19/0007","CLH/19/0008","CLH/19/0009","CLH/19/0010","CLH/20/0011","CLH/20/0012","CLH/20/0013","CLH/20/0014","CLH/20/0015"};
        private static List<Voter> Voters = new List<Voter>();
        public void Register(string name)
        {
            Console.Write("Enter Your FirstName : ");
            string firsTname = Console.ReadLine();
            
            Console.Write("Enter Your LastName : ");
            string lastname = Console.ReadLine();

            Console.Write("What is Your Gender\nEnter 1 for Male or 2 for Female : ");
            int gender;
            while(int.TryParse(Console.ReadLine(), out gender) && (gender < 0 || gender > 2))
            {
                Console.WriteLine("Invalid input\nTry Again...");
            }

            Console.Write("Enter Your Matric No (CAPITAL LETTERS ONLY!) : ");
            string matricNo = Console.ReadLine();
            /*while(CheckStudent(matricNo, StudentInSchool) == false)
            {
                Console.WriteLine("You are not a student of our school");
                break;
            }*/
            Console.Write("Create your password : ");
            string pin = Console.ReadLine();

            Console.Write("Confirm Your Password : ");
            while(Console.ReadLine() != pin)
            {
                Console.WriteLine("The password you entered does not match. Kindly enter again : ");
            }

            VotersCount++;

            var student = new Voter(VotersCount, firsTname, lastname, (GenDer)gender, matricNo, pin);

            Voters.Add(student);

            Console.WriteLine("You have successfilly create your voting account");
        }

        private bool CheckStudent(string matric, List<string> matrics)
        {
            bool check = matrics.Contains(matric);
            return check;
        }
    }
}