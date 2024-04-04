using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class UsersData : DataManager
    {
        private readonly IDataAccess dataAccess;
        public ConnectionStringData ConnectionStringData { get; }
        protected virtual string spCreate => "spUsers_create";
        protected virtual string spGetAll => "spUsers_getall";
        protected virtual string spGetById => "spUsers_getbyId";
        protected override string spDelete => "spUsers_delete";

        public UsersData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            ConnectionStringData = connectionStringData;
        }


    }

}
