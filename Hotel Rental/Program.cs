using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Rental
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //for (int i = 0; i < 20; i++)
        //    {
        //    Console.WriteLine(Guid.newGuid().ToString());
        //    }

        
            
    }
}


//for (int i = 0; i < 20; i++)
//{
//    var num = new Random(4);
//    Console.WriteLine(num.ToString();
//}