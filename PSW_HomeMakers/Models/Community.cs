﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace PSW_HomeMakers.Models
{
    public class Community
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string forum { get; set; }
    }
}