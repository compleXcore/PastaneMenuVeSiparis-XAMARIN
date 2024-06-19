using PastaneMenuVeSiparis.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PastaneMenuVeSiparis.DatabaseAccess
{
    public class DatabaseContext
    {
        private readonly SQLiteAsyncConnection _connection;
        public SQLiteAsyncConnection Connection { get { return _connection; } }
        public DatabaseContext(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            Initialize();
        }

        private async void Initialize()
        {
            await _connection.CreateTableAsync<Kullanici>();
            await _connection.CreateTableAsync<Kategori>();
            await _connection.CreateTableAsync<Urun>();
            await _connection.CreateTableAsync<Siparis>();
            await _connection.CreateTableAsync<SiparisDetay>();

            if (await _connection.Table<Kullanici>().CountAsync() == 0)
            {
                await _connection.InsertAsync(new Kullanici
                {
                    KullaniciAdi = "tilda",
                    Parola = "1234",
                    Isim = "test",
                    Soyisim = "testsoy",
                    Yetki = Models.Enums.Yetkiler.Kullanici
                });

                await _connection.InsertAsync(new Kullanici
                {
                    KullaniciAdi = "hamza",
                    Parola = "hamza4141",
                    Isim = "Hamza",
                    Soyisim = "Süleyman",
                    Yetki = Models.Enums.Yetkiler.Yonetici
                });
            }
            if (await _connection.Table<Kategori>().CountAsync() == 0)
            {
                await _connection.InsertAsync(new Kategori { Ad = "Börek" });
                await _connection.InsertAsync(new Kategori { Ad = "Kek" });
                await _connection.InsertAsync(new Kategori { Ad = "Poğaça" });
                await _connection.InsertAsync(new Kategori { Ad = "Tatlı" });
                await _connection.InsertAsync(new Kategori { Ad = "Tuzlu" });
            }
            if (await _connection.Table<Urun>().CountAsync() == 0)
            {
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Gül Böreği",
                    Fiyat = 100,
                    KategoriId = 1
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Ispanalı Börek",
                    Fiyat = 95,
                    KategoriId = 1
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Kıymalı Börek",
                    Fiyat = 150,
                    KategoriId = 1
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Su Böregi",
                    Fiyat = 75,
                    KategoriId = 1
                });

                await _connection.InsertAsync(new Urun
                {
                    Ad = "Çikolatalı Kek",
                    Fiyat = 120,
                    KategoriId = 2
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Islak Kek",
                    Fiyat = 160,
                    KategoriId = 2
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "limonlu Kek",
                    Fiyat = 110,
                    KategoriId = 2
                });

                await _connection.InsertAsync(new Urun
                {
                    Ad = "Sade Poğaça",
                    Fiyat = 25,
                    KategoriId = 3
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Susamlı Poğaça",
                    Fiyat = 30,
                    KategoriId = 3
                });

                await _connection.InsertAsync(new Urun
                {
                    Ad = "Dolma Baklava",
                    Fiyat = 50,
                    KategoriId = 4
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Ekler",
                    Fiyat = 55,
                    KategoriId = 4
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Kuru Baklava",
                    Fiyat = 85,
                    KategoriId = 4
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Şekerpare",
                    Fiyat = 100,
                    KategoriId = 4
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Soğuk Baklava",
                    Fiyat = 110,
                    KategoriId = 4
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Soğuk Baklava Beyaz",
                    Fiyat = 1650,
                    KategoriId = 4
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Soğuk Baklava Çikolata",
                    Fiyat = 200,
                    KategoriId = 4
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Soğuk Baklava Fıstık",
                    Fiyat = 120,
                    KategoriId = 4
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Tulumba",
                    Fiyat = 140,
                    KategoriId = 4
                });

                await _connection.InsertAsync(new Urun
                {
                    Ad = "Lokmalik Tuzlu",
                    Fiyat = 20,
                    KategoriId = 5
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Lokmalik Tuzlu 2",
                    Fiyat = 30,
                    KategoriId = 5
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Sirkeli Tuzlu",
                    Fiyat = 25,
                    KategoriId = 5
                });
                await _connection.InsertAsync(new Urun
                {
                    Ad = "Tahinli Tuzlu",
                    Fiyat = 20,
                    KategoriId = 5
                });
            }
        }
    }
}
