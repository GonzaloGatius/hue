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
            await dataAccess.SaveData<dynamic>("spGenerics_createWithName50", new { @name = name, @tableName = tableName }, connectionStringData.ConnectionStringName);

        }
        public virtual async Task<int> CreateObject(object _object)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.AddDynamicParams(_object);
            parameters.Add("@Id", DbType.Int32, direction: ParameterDirection.Output);

            return await dataAccess.SaveData<DynamicParameters>(spCreateName, parameters, connectionStringData.ConnectionStringName);
        }

        // UPDATES
        public async Task UpdateDate(DateTime newDate, string tableColumn)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_updateDates", new { @newDate = newDate, @tableName = tableName, @tableColumn = tableColumn }, connectionStringData.ConnectionStringName);
        }

        public async Task UpdateInteger(int @newInt, string tableColumn)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_updateIntegers", new { @newInt = newInt, @tableName = tableName, @tableColumn = tableColumn }, connectionStringData.ConnectionStringName);
        }

        public async Task UpdateModel(string newModel, string tableColumn)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_updateModels", new { @newModel = newModel, @tableName = tableName, @tableColumn = tableColumn }, connectionStringData.ConnectionStringName);
        }

        public async Task UpdateNote(string newNote, string tableColumn)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_updateNotes", new { @newNote = newNote, @tableName = tableName, @tableColumn = tableColumn }, connectionStringData.ConnectionStringName);
        }

        public async Task UpdateString(string newString, string tableColumn)
        {
            await dataAccess.SaveData<dynamic>("spGenerics_updateStrings", new { @newString = newString, @tableName = tableName, @tableColumn = tableColumn }, connectionStringData.ConnectionStringName);
        }
    }
}
