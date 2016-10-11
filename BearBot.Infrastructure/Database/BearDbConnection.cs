using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearBot.Infrastructure.Database
{
    public class BearDbConnection
    {
        public static string ConnectionString { get {
                return "Server=localhost;Port=5432;User Id=bearbot;Password=bearbot;Database=bearsbot;";
            }
        }
    }
}
