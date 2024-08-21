using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class OctopusData : DataManager, IOctopusData
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "Octopus";
        protected override string spCreateName { get; set; } = "spOctopus_create";
        protected override string spUpdateName { get; set; } = "spOctopus_update";

        public OctopusData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
    }

    public interface IOctopusData : IDataManager
    {

    }
}
