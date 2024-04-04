using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class BodyData : DataManager
    {
        private readonly IDataAccess dataAccess;
        public ConnectionStringData ConnectionStringData { get; }
        protected virtual string spCreate => "spBody_create";
        protected virtual string spGetAll => "spBody_getall";
        protected virtual string spGetById => "spBody_getbyId";
        protected override string spDelete => "spBody_delete";

        public BodyData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            ConnectionStringData = connectionStringData;
        }


    }

}
