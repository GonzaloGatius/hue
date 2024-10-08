﻿
namespace libraryhue.Data
{
    public interface IDataManager
    {
        Task<int> CreateObject(object _object);
        Task UpdateObject(int id, object _object);
        Task Delete(int Id);
        Task<List<T>> GetAll<T>() where T : class;
        Task<T> GetById<T>(int Id) where T : class;
        Task UpdateDate(DateTime newDate, string tableColumn, int Id);
        Task UpdateInteger(int newInt, string tableColumn, int Id);
        Task UpdateString(string newString, string stringLenth, string tableColumn, int Id);
    }
}