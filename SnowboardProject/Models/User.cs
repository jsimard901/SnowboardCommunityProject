using System;
using SnowboardProject.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace SnowboardProject.Models
{
    public class User
    {
        [Key]
        [Display(Name = "ID")]
        public int id {get; set;}

        
        public string UserEmail {get; set;}

        public string UserName {get; set;}

        public bool Friend {get; set;}

        public List<User> ListOfFriends {get; set;}

        public List<Resort> ListOfFavoriteResorts {get; set;}

        public List<ForumPost> ListOfUserPosts {get; set;}
    }
}



