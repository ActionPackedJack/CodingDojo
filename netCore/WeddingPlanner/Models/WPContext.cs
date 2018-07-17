using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace WeddingPlanner.Models
{
    public class WPContext:DbContext
    {
        public WPContext(DbContextOptions<WPContext> options):base(options){}
        public DbSet<User> _users {get;set;}
        public DbSet<Wedding> _weddings {get;set;}
        public DbSet<Guest> guests {get;set;}
        //public User CreateUser(RegisterVM registerVM)

        public void CreateUser(RegisterVM registerVM){
            List<User> users = _users.ToList();
            User user = new User(registerVM);
            this.Add(user);
            this.SaveChanges();
        }
    
        public User Login(LoginVM loginVM){
            User user= _users.Where(u=> u.email == loginVM.email).SingleOrDefault();
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
        }
    }
}