using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class FinsData : DataManager
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "Fins";
        protected override string spCreateName { get; set; } = "spFins_create";

        public FinsData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
    }
}
