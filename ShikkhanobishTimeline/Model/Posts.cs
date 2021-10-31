using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShikkhanobishTimeline.Model
{
    public class Posts
    {
        public string postID { get; set; }
        public string name { get; set; }
        public string post { get; set; }
        public string postDate { get; set; }
        public int userID { get; set; }
        public int userType { get; set; }
        public string imgSrc { get; set; }
        public string postTitle { get; set; }
        public int noOfComment { get; set; }
        public int tagID { get; set; }
        public string tagName { get; set; }
        public string Response { get; set; }
    }
}
