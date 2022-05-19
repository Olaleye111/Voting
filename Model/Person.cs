using System;
using VotingSystem.Enum;
using VotingSystem.Admin;
//using VotingSystem.Model;

namespace VotingSystem.Model
{
    public class Person
    {
        public int Id{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public GenDer Gender{get; set;}
        public string MatricNo{get; set;}
        public string Pin{get; set;}
        public Person(int id, string firstname, string lastname, GenDer gender, string matric, string pin)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Gender = gender;
            this.MatricNo = matric;
            this.Pin = pin;
        }
    }
}