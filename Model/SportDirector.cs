using System;
using VotingSystem.Enum;
using VotingSystem.Admin;
//using VotingSystem.Model;

namespace VotingSystem.Model
{
    public class SportDirector : Person
    {
        public SportDirector(int id, string firstname, string lastname, GenDer gender, string matric, string pin):base(id, firstname, lastname, gender, matric, pin){}
    }
}