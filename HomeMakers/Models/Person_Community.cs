﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeMakers.Models
{
    public class Person_Community
    {
        private int id_person;

        public int ID_Person
        {
            get { return id_person; }
            set { id_person = value; }
        }

        private int id_community;

        public int ID_Community
        {
            get { return id_community; }
            set { id_community = value; }
        }

    }
}