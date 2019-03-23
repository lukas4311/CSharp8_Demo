using System;
using System.Data.SqlClient;
using static System.Console;

namespace CSharp8
{
    internal class UsingDeclarations
    {
        public static void Demo()
        {
            // Old using declaration
            using(var connection = new SqlConnection())
            {
                using(var cmd = new SqlCommand("baf", connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        // do reading
                    } // dispose reader
                } // dispose cmd
            } // dispose connection

            // C# 8 using declarations
            if (true)
            {
                using var connection = new SqlConnection();
                using var cmd = new SqlCommand("baf", connection);
                using var reader = cmd.ExecuteReader();
            } // dispose connection, cmd, reader
        }
    }
}
