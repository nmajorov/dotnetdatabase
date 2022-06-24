// See https://aka.ms/new-console-template for more information
using database.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace database.DBcontext
{

    public class BloggingContext : DbContext
    {

        public DbSet<Post>? Posts { get; set; }
         public DbSet<User>? Users { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            Console.WriteLine($"connection sting:{connectionString} ");
            if (connectionString !=null){
                options.UseNpgsql(connectionString);
            }else{
                throw new Exception("Can't read connection string form configuration");
            }

        }
    }


}
