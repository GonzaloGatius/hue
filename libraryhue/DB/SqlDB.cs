using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace libraryhue.DB
{
    public class SqlDB : IDataAccess
    {
        private readonly IConfiguration configuration;

        public SqlDB(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            var connectionString = configuration.GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                var rows = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return rows.ToList();
            }
        }

        public async Task<int> SaveData<U>(string storedProcedure, U parameters, string connectionStringName)
        {
            var connectionString = configuration.GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                return await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
