using System;
using VotingSystem.Enum;
//using VotingSystem.Admin;
//using VotingSystem.Model;

namespace VotingSystem.Model
{
    public class Treasurer : Person
    {
        public Treasurer(int id, string firstname, string lastname, GenDer gender, string matric, string pin):base(id, firstname, lastname, gender, matric, pin){}
    }
}