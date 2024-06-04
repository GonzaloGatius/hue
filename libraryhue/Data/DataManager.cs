using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public abstract class DataManager
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected abstract string tableName { get; set; }

        public DataManager(IDataAccess dataAccess, ConnectionStringData connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }

        //Basic CRUD.
        public async Task<List<T>> GetAll<T>() where T : class
        {
            return await dataAccess.LoadData<T, dynamic>("spGenerics_getAll", new { @tableName = tableName }, connectionStringData.ConnectionStringName);

        }

        public async Task<T> GetById<T>(int Id) where T : class
        {
            var list = await dataAccess.LoadData<T, dynamic>("spGenerics_getById", new { @Id = Id, @tableName = tableName }, connectionStringData.ConnectionStringName);

            return list.FirstOrDefault();
        }

        public async Task Delete(int Id)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_delete", new { @Id = Id, @tableName = tableName }, connectionStringData.ConnectionStringName);

        }
        public async Task CreateStrings50(string name, string tableName)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_createWithName50", new {@name = name, @tableName = tableName }, connectionStringData.ConnectionStringName);

        }
    }
}
