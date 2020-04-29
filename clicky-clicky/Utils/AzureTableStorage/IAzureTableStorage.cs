using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos.Table;

namespace clicky_clicky.Utils.AzureTableStorage
{
    public interface IAzureTableStorage<T> where T : TableEntity, new()
    {
        Task Delete(string partitionKey, string rowKey);
        Task<T> GetItem(string partitionKey, string rowKey);
        Task<List<T>> GetList(string partitionKey);
        Task Insert(T item);
        Task InsertOrReplace(T item);
    }
}