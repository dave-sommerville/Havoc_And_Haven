﻿namespace Havoc_And_Haven.Models
{
    public class Headquarter
    {
        public int HeadquarterID { get; set; }
        public string Title { get; set; }
        public DateTime DateRegistered { get; set; }
        public int LocationID { get; set; }
        public List <int> SuperheroID { get; set; }

    }
}
