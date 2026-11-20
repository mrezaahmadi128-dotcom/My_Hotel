using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    internal class HotelDesignTimeDbContextFactory : IDesignTimeDbContextFactory<HotelDbContext>
    {
        public HotelDbContext CreateDbContext(string[] args)
        {
            return new HotelDbContext("Server=localhost\\SQLEXPRESS;Database=MyHotel;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
