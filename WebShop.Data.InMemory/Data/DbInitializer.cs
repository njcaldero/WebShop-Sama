using Grpc.Core;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Entities;

namespace WebShop.Data.InMemory.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var _context = new InMemoryContext(serviceProvider.GetRequiredService<DbContextOptions<InMemoryContext>>()))
            {
                if (_context.Products.Any())
                    return;

                string pathToFiles = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                StreamReader r = new StreamReader($"{pathToFiles}/data.json");
                string jsonString = r.ReadToEnd();
                List<Product> lp = JsonConvert.DeserializeObject<List<Product>>(jsonString);

                _context.AddRange(lp);

                _context.SaveChanges();
            }


        }
    }
}
