using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTZMDotNetCore.ConsoleApp
{
    internal class ConnectionStrings
    {
        public static SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "DESKTOP-2HI448L\\MSSQLSERVER33",
            InitialCatalog = "MTZMDotNetCore",
            UserID = "sasa",
            Password = "12345",
        };

    } 
}
