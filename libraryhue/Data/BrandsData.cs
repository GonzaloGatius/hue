using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class BrandsData : DataManager
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "Brands";
        protected override string spCreateName { get; set; } = "spGenerics_createWithName50";

        public BrandsData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
    }
}
