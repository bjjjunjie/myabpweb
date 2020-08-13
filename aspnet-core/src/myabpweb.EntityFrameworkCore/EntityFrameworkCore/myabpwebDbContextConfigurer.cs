using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace myabpweb.EntityFrameworkCore
{
    public static class myabpwebDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<myabpwebDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<myabpwebDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
