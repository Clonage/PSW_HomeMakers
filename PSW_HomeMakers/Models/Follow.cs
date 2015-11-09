using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PSW_HomeMakers.Models
{
    public class Follow
    {
        private int followed;

        public int Followed
        {
            get { return followed; }
            set { followed = value; }
        }


        private int follower;

        public int Follower
        {
            get { return follower; }
            set { follower = value; }
        }

        public virtual Person Person1 { get; set; }
        public virtual Person Person2 { get; set; }

    }
}