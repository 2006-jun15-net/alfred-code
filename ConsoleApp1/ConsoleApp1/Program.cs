using ClassLibraryEF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public static readonly DbContextOptions<chinookContext> Options = new DbContextOptionsBuilder<chinookContext>()
           .UseLoggerFactory(MyLoggerFactory)
           .UseSqlServer(SecretConfiguration.ConnectionString)
           .Options;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void DisplayData()
        {
            using var context = new chinookContext(Options);

           // List<Student> students = context.Customer
               // .Include(s => s.FirstName)
                  // .ThenInclude(e => e.City)
               // .ToList();
                     
        }
    }
}
