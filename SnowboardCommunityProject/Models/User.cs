using System;
using SnowboardCommunityProject.Models;
using System.ComponentModel.DataAnnotations;

namespace SnowboardCommunityProject.Models
{
    public class User
    {
        [Key]
        [Display(Name = "ID")]
        public int id {get; set;}

        
        public string UserEmail {get; set;}

        public string UserName {get; set;}

        public List<User> ListOfFriends {get; set;}

        public List<Resort> ListOfFavoriteResorts {get; set;}

        public List<ForumPost> ListOfUserPosts {get; set;}
    }
}



