using NinjaDomain.Classes;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
            InsertClans();
            InsetNinja();
            Console.ReadKey();
        }
        private static void InsertClans()
        {
            using(var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Clans.Add(new Clan() {
                    Id = 1,
                    ClanName = "Adventures"
                });
                context.SaveChanges();
            }
        }

        private static void InsetNinja()
        {
            var ninja = new Ninja
            {
                Name = "JulieSan",
                ServedinOniwaban = false,
                DateOfBirth = new DateTime(1980, 1, 1),
                ClanID = 1
            };

            using(var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            };
        }
    }
}
