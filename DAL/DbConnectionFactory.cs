
using Microsoft.Data.SqlClient;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL;

public class DbConnectionFactory
{
    private static string _connectionString;
    public static void Initialize(string connectionString)
    {
        _connectionString = connectionString;
    }
    public static HotelDbContext Create()
    {
        return new HotelDbContext(_connectionString);
    }
}
