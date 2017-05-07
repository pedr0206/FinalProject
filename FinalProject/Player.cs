using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Player
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int points { get; set; }


                                           //public string Team { get; set; }
                                           //add team/*
        public Player(string FirstName, string LastName, DateTime DateOfBirth, int Points)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.dateOfBirth = dateOfBirth;
            this.points = Points;
            
        }
        
    }
}
