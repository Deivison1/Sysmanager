using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;


namespace Sysmanager.Application.Data.Mysql
{
     public class MySqlContext
     {
        private MySqlConnection connetion;
        private readonly string connectionString = "";

        public MySqlContext(IOptions<AppConnectionSettings> appsettings)
        {
            connectionString = appsettings.Value.DefaultConnection;
            connetion = new MySqlConnection(connectionString);
            connetion.Open();
        }

        public MySqlConnection Connection()
        {
            connetion = new MySqlConnection(connectionString);
            connetion.Open();
            return connetion;
        }

     }
}
