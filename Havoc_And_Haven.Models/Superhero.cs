﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havoc_And_Haven.Models
{
    public class Superhero
    {
        public int SuperheroID { get; set; }
        public string Alias { get; set; }
        public string RealFullName { get; set; }
        public string OriginStory { get; set; }
        public string ProfilePicture { get; set; }
        public List<int> EmergencyCallIDs { get; set; }
    }
}
