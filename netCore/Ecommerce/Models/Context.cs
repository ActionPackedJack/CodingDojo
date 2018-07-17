using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Models{
    public class Context:DbContext{
        public Context(DbContextOptions<Context>) options:base(DbContextOptions){} 
    }
}

