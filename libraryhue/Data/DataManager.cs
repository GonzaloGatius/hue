using Dapper;
using libraryhue.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public abstract class DataManager : IDataManager
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected abstract string tableName { get; set; }
        protected abstract string spCreateName { get; set; }
        protected abstract string spUpdateName { get; set; }

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
        public virtual async Task<int> CreateObject(object _object)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.AddDynamicParams(_object);
            parameters.Add("@Id", DbType.Int32, direction: ParameterDirection.Output);

            return await dataAccess.SaveData<DynamicParameters>(spCreateName, parameters, connectionStringData.ConnectionStringName);
        }
        // UPDATES
        public virtual async Task UpdateObject(int id, object _object)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.AddDynamicParams(_object);
            parameters.Add("@Id", id);

            await dataAccess.SaveData<DynamicParameters>(spUpdateName, parameters, connectionStringData.ConnectionStringName);
        }
        public async Task UpdateDate(DateTime newDate, string tableColumn, int Id)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_updateDates", new { @Id = Id, @newDate = newDate, @tableName = tableName, @tableColumn = tableColumn }, connectionStringData.ConnectionStringName);
        }
        public async Task UpdateInteger(int @newInt, string tableColumn, int Id)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_updateIntegers", new { @Id = Id, @newInt = newInt, @tableName = tableName, @tableColumn = tableColumn }, connectionStringData.ConnectionStringName);
        }
        public async Task UpdateString(string newString, string stringLength, string tableColumn, int Id)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_updateStrings" + stringLength, new { @Id = Id, @newString = newString, @tableName = tableName, @tableColumn = tableColumn }, connectionStringData.ConnectionStringName);
        }
    }
}
