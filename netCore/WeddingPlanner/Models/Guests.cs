using System.Collections.Generic;
using WeddingPlanner.Models;
using System.Linq;

namespace WeddingPlanner.Models{


    public class Guest{
        public int GuestId {get;set;}
        public int WeddingId {get;set;}
        public int UserId {get;set;}
        public Wedding Wedding {get;set;}
        public User User {get;set;}

        //List<Guest> guests = context.guests.Include(g=> g.Wedding).Include(g=>g.User).ToList();
    }
}