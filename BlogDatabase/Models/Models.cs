using System.ComponentModel.DataAnnotations;

namespace database.Models{
    public class Post{
        
        public long Id { get; set; }
        
        public string? Title {get;set;}
        public string? Author {get;set;}
        
        public string? Body {get;set;}
        
        public DateTime Posted {get;set;}
        
       
    }


    public class User{
        
        public long Id { get; set; }
        
        public string? FirstName {get;set;}
        public string? LastName {get;set;}
        
        public string? UserName {get;set;}

        
    }
}