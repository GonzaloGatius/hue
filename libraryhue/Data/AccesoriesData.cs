using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class AccesoriesData : DataManager
    {
        private readonly IDataAccess dataAccess;
        public ConnectionStringData ConnectionStringData { get; }
        protected virtual string spCreate => "spAccesories_create";
        protected virtual string spGetAll => "spAccesories_getall";
        protected virtual string spGetById => "spAccesories_getbyId";
        protected override string spDelete => "spAccesories_delete";

        public AccesoriesData(IDataAccess dataAccess, ConnectionStringData connectionStringData):base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            ConnectionStringData = connectionStringData;
        }


    }

   }
