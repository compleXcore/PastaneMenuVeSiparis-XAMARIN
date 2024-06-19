using PastaneMenuVeSiparis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PastaneMenuVeSiparis.DatabaseAccess
{
    public class KullaniciManager
    {
        private readonly DatabaseContext context;
        public Kullanici Kullanici { get; set; }

        public KullaniciManager(DatabaseContext context)
        {
            this.context = context;
        }

        public Task<List<Kullanici>> GetAllAsync()
        {
            return context.Connection.Table<Kullanici>().Where(x => x.Yetki == Models.Enums.Yetkiler.Yonetici).ToListAsync();
        }

        public Task<Kullanici> GetKullaniciAsync(int id)
        {
            return context.Connection.GetAsync<Kullanici>(id);
        }

        public async Task<int> SaveKullaniciAsync(Kullanici user)
        {
            if (user.Id == 0)
            {
                if (await context.Connection.Table<Kullanici>().FirstOrDefaultAsync(x => x.KullaniciAdi.Equals(user.KullaniciAdi)) == null)
                    return await context.Connection.InsertAsync(user);
                else
                    throw new Exception($"{user.KullaniciAdi} kullanıcı adına sahip kullanıcı zaten var...");
            }
            else
            {
                if (await context.Connection.Table<Kullanici>().FirstOrDefaultAsync(x => x.Id != user.Id && x.KullaniciAdi.Equals(user.KullaniciAdi)) != null)
                    throw new Exception($"{user.KullaniciAdi} kullanıcı adına sahip başka kullanıcı zaten var");
                else
                    return await context.Connection.UpdateAsync(user);
            }
        }

        public async Task<bool> KullaniciCheck(Kullanici user)
        {
            if (await context.Connection.Table<Kullanici>().FirstOrDefaultAsync(x => x.KullaniciAdi.Equals(user.KullaniciAdi)) == null)
                return true;
            else
                return false;
        }

        public Task<int> DeleteAsync(Kullanici user)
        {
            return context.Connection.DeleteAsync(user);
        }

        public async Task<bool> Login(Kullanici user)
        {
            if (await context.Connection.Table<Kullanici>().FirstOrDefaultAsync(x => x.KullaniciAdi.Equals(user.KullaniciAdi) &&
                                                                                     x.Parola.Equals(user.Parola)) == null)
            {
                return false;
            }
            else
            {
                Kullanici = new Kullanici();
                Kullanici = await context.Connection.Table<Kullanici>().FirstOrDefaultAsync(x => x.KullaniciAdi.Equals(user.KullaniciAdi) &&
                                                                                     x.Parola.Equals(user.Parola));
                return true;
            }
        }
    }
}
