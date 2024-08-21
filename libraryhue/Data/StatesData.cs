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
    public class StatesData : DataManager, IStatesData
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "States";
        protected override string spCreateName { get; set; } = "spGenerics_createWithName50";
        protected override string spUpdateName { get; set; } = "";

        public StatesData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
    }

    public interface IStatesData : IDataManager
    {

    }
}
