using System;
using System.ComponentModel.DataAnnotations;

namespace SnowboardProject.Models
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

