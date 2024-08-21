using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class RentalsData : DataManager, IRentalsData
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "Rentals";
        protected override string spCreateName { get; set; } = "spRentals_create";
        protected override string spUpdateName { get; set; } = "";

        public RentalsData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
    }

    public interface IRentalsData : IDataManager
    {

    }
}
