using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class RentalCartData : DataManager, IRentalCartData
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "RentalCarts";
        protected override string spCreateName { get; set; } = "spRentalCarts_create";
        protected override string spUpdateName { get; set; } = "";

        public RentalCartData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
    }

    public interface IRentalCartData : IDataManager
    {

    }
}
