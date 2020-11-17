using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace SnowboardProject.Models
{
    public class ForumPostReply
    {
        [Key]
        public int id {get; set;}

        // public int UserId {get; set;}

        public string Reply {get; set;}



    
    }

}