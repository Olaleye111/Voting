using System;
using System.Collections.Generic;
using VotingSystem;
using VotingSystem.Admin;
using VotingSystem.Enum;
using VotingSystem.Model;

namespace VotingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VoterAdmin ted = new VoterAdmin();
            ted.Register("ted");
            /*List<string> StudentInSchool1 = new List<string>(){"CLH/18/0001","CLH/18/0002","CLH/18/0003","CLH/18/0004","CLH/18/0005","CLH/19/0006","CLH/19/0007","CLH/19/0008","CLH/19/0009","CLH/19/0010","CLH/20/0011","CLH/20/0012","CLH/20/0013","CLH/20/0014","CLH/20/0015"};
            bool check = StudentInSchool1.Contains("CLH/18/0011");
            Console.WriteLine(check);*/
        }
    }
}
