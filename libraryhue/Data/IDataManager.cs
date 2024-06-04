
namespace libraryhue.Data
{
    public interface IDataManager
    {
        Task<int> CreateObject(object _object);
        Task CreateStrings50(string name, string tableName);
        Task Delete(int Id);
        Task<List<T>> GetAll<T>() where T : class;
        Task<T> GetById<T>(int Id) where T : class;
        Task UpdateDate(DateTime newDate, string tableColumn);
        Task UpdateInteger(int newInt, string tableColumn);
        Task UpdateModel(string newModel, string tableColumn);
        Task UpdateNote(string newNote, string tableColumn);
        Task UpdateString(string newString, string tableColumn);
    }
}