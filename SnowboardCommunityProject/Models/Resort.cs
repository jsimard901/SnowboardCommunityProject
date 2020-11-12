using System;
using System.ComponentModel.DataAnnotations;

namespace SnowboardCommunityProject.Models
{
    public class Resort
    {
        [Key]
        public int ResortId {get; set;}

        public string ResortName {get; set;}

        public string ResortLocation {get; set;}

        public int ResortElevation {get; set;}

        
    
    }

}

