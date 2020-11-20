using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace SnowboardProject.Models
{
    public class ForumPost
    {
        [Key]
        public int id {get; set;}

        public string UserIdEmail {get; set;}

        // public string PostCategory {get; set;}
        public string PostTitle {get; set;}

        public string Post {get; set;}

        public int ResortId {get; set;}

        public List<ForumPostReply> ListOfPostReplies {get; set;}


    
    }

}