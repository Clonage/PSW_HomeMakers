﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeMakers.Models
{
    public class Role
    {
        private int id;
        private string description;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public virtual ICollection<Person> Persons { get; set; }
    }
}