using Dapper;
using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class SizesData : DataManager
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "Sizes";
        protected override string spCreateName { get; set; } = "spGenerics_createWithName50";

        public SizesData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
        public override async Task<int> CreateObject(object _object)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.AddDynamicParams(_object);
            parameters.Add("@tableName", tableName, DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Id", DbType.Int32, direction: ParameterDirection.Output);

            return await dataAccess.SaveData<DynamicParameters>(spCreateName, parameters, connectionStringData.ConnectionStringName);

        }
    }
}
