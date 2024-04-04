using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class FootwearData : DataManager
    {
        private readonly IDataAccess dataAccess;
        public ConnectionStringData ConnectionStringData { get; }
        protected virtual string spCreate => "spFootwear_create";
        protected virtual string spGetAll => "spFootwear_getall";
        protected virtual string spGetById => "spFootwear_getbyId";
        protected override string spDelete => "spFootwear_delete";

        public FootwearData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            ConnectionStringData = connectionStringData;
        }


    }

}
