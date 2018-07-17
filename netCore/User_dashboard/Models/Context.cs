using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UserDashboard.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options){}
        public DbSet<User> _users {get;set;}
        public DbSet<Post> _posts {get;set;}
        public DbSet<Comment> _comments {get;set;}
        //public User CreateUser(RegisterVM registerVM)

        public void CreateUser(RegisterVM registerVM){
            List<User> users = _users.ToList();
            User user = new User(registerVM);
            if(users.Count()>0){
                user.admin = false;
            }
            else{
                user.admin = true;
            }
            this.Add(user);
            this.SaveChanges();
        }
    
        public User Login(LoginVM loginVM){
            User user= _users.Where(u=> u.email == loginVM.email).SingleOrDefault():
            if(user == null){
                return null;
            }
            else{
                if(user.password == loginVM.password){
                    return user;
                }
                else{
                    return null;
                }
            }
                return user;
        }
    

    }
    public User Login(LoginVM loginVM)
    {
        User user = _users.Where(u => u.email == loginVM.email).SingleOrDefault();
    }
    [Route("/users/posts")]
    public IActionResult post(string text, int id){
        User user= context._users.Where(u => u.Id == id).SingleOrDefault();
        int uid = Int32.Parse(HttpContext.Session.GetString("id"));
        User poster = context._users.Where(u => u.Id == uid).SingleOrDefault();
        //Post post = new Post(text; poster;);

        post.postee = postee;
        post.posterID= uid;

        postee.posts.Add(post);
        context.SaveChanges();
        return Redirect("user/"+id);
    }
    public IActionResult show(int id)
    {

    }
}