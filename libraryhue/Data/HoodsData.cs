using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class HoodsData : DataManager, IHoodsData
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "Hoods";
        protected override string spCreateName { get; set; } = "spHoods_create";
        protected override string spUpdateName { get; set; } = "spHoods_update";

        public HoodsData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
    }

    public interface IHoodsData : IDataManager
    {

    }
}
