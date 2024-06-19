using PastaneMenuVeSiparis.Models;
using PastaneMenuVeSiparis.Models.Enums;
using SQLiteNetExtensionsAsync.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaneMenuVeSiparis.DatabaseAccess
{
    public class SiparisManager
    {
        private readonly DatabaseContext context;
        public SiparisManager(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<List<Siparis>> GetAllSiparisWithChildrenAsync()
        {
            return await context.Connection.GetAllWithChildrenAsync<Siparis>(x => x.Durum == Durumlar.TeslimEdildi);
        }

        public async Task<List<Siparis>> GetAllSiparisWithChildrenAsync(int id, Durumlar durum)
        {
            return await context.Connection.GetAllWithChildrenAsync<Siparis>(x => x.Durum == durum && x.KullaniciId == id);
        }

        public async Task<Siparis> GetSiparisInSepette(int id)
        {
            return await context.Connection.Table<Siparis>().FirstOrDefaultAsync(x => x.KullaniciId == id && x.Durum == Durumlar.Sepette);
        }
        public Task<int> SaveAsync(Siparis item)
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

        public Task<int> DeleteAsync(Siparis item)
        {
            return context.Connection.DeleteAsync(item);
        }
    }
}