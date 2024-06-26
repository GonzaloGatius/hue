﻿
namespace libraryhue.DB
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName);
        Task<int> SaveData<U>(string storedProcedure, U parameters, string connectionStringName);
    }
}