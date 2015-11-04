using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HomeMakers.Models
{
    public class Category
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

        public virtual ICollection<Post> Posts { get; set; }
    
    }
}