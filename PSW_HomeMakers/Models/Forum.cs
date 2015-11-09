using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace PSW_HomeMakers.Models
{
    public class Forum
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private int id_Community;

        public int ID_Community
        {
            get { return id_Community; }
            set { id_Community = value; }
        }

        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        
    }
}