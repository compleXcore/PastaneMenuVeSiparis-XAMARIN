using PastaneMenuVeSiparis.Models;
using SQLiteNetExtensionsAsync.Extensions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PastaneMenuVeSiparis.DatabaseAccess
{
    public class UrunManager
    {
        private readonly DatabaseContext context;
        public UrunManager(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<List<Urun>> GetAllUrunWithCategoriesAsync()
        {
            return await context.Connection.GetAllWithChildrenAsync<Urun>();
        }

        public Task<Urun> GetUrunAsync(int id)
        {
            return context.Connection.GetWithChildrenAsync<Urun>(id);
        }

        public Task<int> SaveAsync(Urun item)
        {
            if (item.Id == 0)
            {
                return context.Connection.InsertAsync(item);
            }
            else
            {
                return context.Connection.UpdateAsync(item);
            }
        }

        public Task<int> DeleteAsync(Urun item)
        {
            return context.Connection.DeleteAsync(item);
        }
    }
}
