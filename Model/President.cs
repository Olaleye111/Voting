using System;
using VotingSystem.Enum;
using VotingSystem.Admin;
//using VotingSystem.Model;

namespace VotingSystem.Model
{
    public class President : Person
    {
        public int Grade;
        public President(int id, string firstname, string lastname, GenDer gender, string matric, string pin, int grade):base(id, firstname, lastname, gender, matric, pin)
        {
            this.Grade = grade;
        }
    }
}