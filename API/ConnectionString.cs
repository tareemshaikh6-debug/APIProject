using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace API
{
    public class ConnectionString
    {
        private static string connectionstring;
        
        static ConnectionString()
        {
           var builder = new SqlConnectionStringBuilder
           {
               DataSource = "DESKTOP-DE5MQGD\\SQLEXPRESS",
               InitialCatalog = "CompanyDB",
               TrustServerCertificate = true,
               IntegratedSecurity=true
           };
              connectionstring = builder.ConnectionString;
        }
        public static string cs
        {
            get => connectionstring;
        }
    }
}
