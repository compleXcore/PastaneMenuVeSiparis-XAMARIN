using PastaneMenuVeSiparis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PastaneMenuVeSiparis.DatabaseAccess
{
    public class KategoriManager
    {
        private readonly DatabaseContext context;
        public KategoriManager(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<List<Kategori>> GetAllAsync()
        {
            var data = await context.Connection.Table<Kategori>().ToListAsync();
            return data;
        }

        public Task<Kategori> GetKategoriAsync(int id)
        {
            return context.Connection.GetAsync<Kategori>(id);
        }

        public Task<int> SaveKategoriAsync(Kategori item)
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

        public Task<int> DeleteAsync(Kategori item)
        {
            return context.Connection.DeleteAsync(item);
        }
    }
}
