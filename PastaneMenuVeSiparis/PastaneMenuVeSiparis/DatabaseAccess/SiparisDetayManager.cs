using PastaneMenuVeSiparis.Models;
using SQLiteNetExtensionsAsync.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PastaneMenuVeSiparis.DatabaseAccess
{
    public class SiparisDetayManager
    {
        private readonly DatabaseContext context;
        public SiparisDetayManager(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<List<SiparisDetay>> GetAllSiparisWithChildrenAsync(int siparisId)
        {
            return await context.Connection.GetAllWithChildrenAsync<SiparisDetay>(x => x.SiparisId == siparisId);
        }

        public Task<int> SaveAsync(SiparisDetay item)
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

        public Task<int> DeleteAsync(SiparisDetay item)
        {
            return context.Connection.DeleteAsync(item);
        }
    }
}
