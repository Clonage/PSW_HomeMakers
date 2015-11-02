using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeMakers.Models
{
    public class Forum
    {
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