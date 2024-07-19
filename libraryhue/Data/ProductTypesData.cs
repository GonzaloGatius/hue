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
    public class ProductTypesData : DataManager, IProductTypesData
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "ProductTypes";
        protected override string spCreateName { get; set; } = "spGenerics_createWithName50";

        public ProductTypesData(IDataAccess dataAccess, ConnectionStringData connectionStringData) : base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
        public async Task<T> GetProductNameById<T>(int Id) 
        {
            var list = await dataAccess.LoadData<T, dynamic>("spProductTypes_GetNameById", new { @Id = Id}, connectionStringData.ConnectionStringName);

            return list.FirstOrDefault();
        }
    }

    public interface IProductTypesData : IDataManager
    {
        Task<T> GetProductNameById<T>(int Id);
    }

}
