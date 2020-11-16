using System;
using System.ComponentModel.DataAnnotations;


namespace SnowboardProject.Models
{
    public class ForumPost
    {
        [Key]
        public int id {get; set;}

        // public int UserId {get; set;}

        // public string PostCategory {get; set;}

        public string Post {get; set;}


    
    }

}