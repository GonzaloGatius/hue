using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class RentalsData : DataManager
    {
        private readonly IDataAccess dataAccess;
        public ConnectionStringData ConnectionStringData { get; }
        protected virtual string spCreate => "spRentals_create";
        protected virtual string spGetAll => "spRentals_getall";
        protected virtual string spGetById => "spRentals_getbyId";
        protected override string spDelete => "spRentals_delete";

        public RentalsData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            ConnectionStringData = connectionStringData;
        }


    }

}
