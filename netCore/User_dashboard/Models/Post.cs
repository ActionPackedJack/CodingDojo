using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserDashboard.Models{
    public class Post:BaseEntity{
        public string text {get;set;}
        public User user {get;set;}
        public User postee {get;set;}
        public List<Comment> comments{set;get;}

        public Post(){

        }

        // public Post CreatePost(string text, int){
        //     Post post = new Post();
        //     return post;
        // }
    }
}