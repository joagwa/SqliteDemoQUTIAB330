using SQLite;
using SqliteDemo.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SqliteDemo.Services
{
    public class ItemsDataStore : IDataStore<Item>
    {
        readonly SQLiteAsyncConnection database = App.Database.Database;
        public async Task<bool> AddItemAsync(Item item)
        {
            return await database.InsertAsync(item) > 0;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var item = database.Table<Item>().FirstOrDefaultAsync(i => i.Id == id);
            return item != null && await database.DeleteAsync(item) > 0;
        }

        public Task<Item> GetItemAsync(string id)
        {
            return database.GetAsync<Item>(id);
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await database.Table<Item>().ToListAsync();
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            return await database.UpdateAsync(item) > 0;
        }
    }
}
