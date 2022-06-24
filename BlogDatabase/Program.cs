using database.DBcontext;
using database.Models;
namespace database
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strarting program");

            //run database operations
            using (var db = new BloggingContext())
            {
                db.Database.EnsureCreated();
                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new Post
                {
                    Author = "Nikolaj",
                    Body = "DotNet",
                    Title = "Simple Post01",
                    Posted = DateTime.Now.ToUniversalTime()

                });

                db.Add(new User{
                    UserName = "nmajorov",
                    FirstName = "Nikolaj",
                    LastName = "Majorov",
                    

                });
                db.SaveChanges();
            }
        }

    }

}