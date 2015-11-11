using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace PSW_HomeMakers.Models
{
    public class Comment
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int id_person;

        public int ID_Person
        {
            get { return id_person; }
            set { id_person = value; }
        }

        private int id_Post;

        public int ID_Post
        {
            get { return id_Post; }
            set { id_Post = value; }
        }

        private string comment_text;

        public string Comment_text
        {
            get { return comment_text; }
            set { comment_text = value; }
        }

        public virtual Person Person { get; set; }
        
    }
}