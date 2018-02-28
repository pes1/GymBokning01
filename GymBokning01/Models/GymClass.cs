﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymBokning01.Models
{
    public class GymClass
    {
        public int      Id          { get; set; }
        public string   Name        { get; set; }
        public DateTime StartTime   { get; set; }
        public TimeSpan Duration    { get; set; }
        public DateTime EndTime     { get { return StartTime + Duration; } }
        public String   Description { get; set; }

        //- Navigation property -
        public virtual ICollection<ApplicationUser> AttendingMembers { get; set; }
    }
}