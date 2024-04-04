using Dapper;
using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class DataManager
    {
        private readonly IDataAccess dataAccess;
        public ConnectionStringData ConnectionStringData { get; }

        protected virtual string spCreate => "";
        protected virtual string spGetAll => "";
        protected virtual string spGetById => "";
        protected virtual string spDelete => "";

        public DataManager(IDataAccess dataAccess, ConnectionStringData connectionStringData)
        {
            this.dataAccess = dataAccess;
            ConnectionStringData = connectionStringData;
        }


        public async Task<int> Create(object model)
        {
            DynamicParameters p = new DynamicParameters();
            p.AddDynamicParams(model);
            p.Add("@Id", DbType.Int32, direction: System.Data.ParameterDirection.Output);

            await dataAccess.SaveData(spCreate, p, ConnectionStringData.ConnectionStringName);

            return p.Get<int>("@Id");
        }


        public async Task<List<T>> GetAll<T>()
        { 
            return await dataAccess.LoadData<T, dynamic>(spGetAll, new { }, ConnectionStringData.ConnectionStringName);
        }

        public async Task<T> GetById<T>(int Id)
        { 
            var item = await dataAccess.LoadData<T, dynamic>(spGetById, new { @Id = Id }, ConnectionStringData.ConnectionStringName);

            return item.FirstOrDefault();
        }

        public async Task<int> Delete(int Id)
        {
            return await dataAccess.SaveData<dynamic>(spDelete, new { @Id = Id }, ConnectionStringData.ConnectionStringName);
        }
    }
}
