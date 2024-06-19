using System;
using System.Collections.Generic;
using System.Text;

namespace PastaneMenuVeSiparis.DatabaseAccess
{
    public class UnitOfWork
    {
        private readonly DatabaseContext context;
        private KullaniciManager _kullaniciManager;
        private KategoriManager _kategoriManager;
        private UrunManager _urunManager;
        private SiparisManager _siparisManager;
        private SiparisDetayManager _siparisDetayManager;

        public KullaniciManager KullaniciManager
        {
            get
            {
                if (_kullaniciManager == null)
                    _kullaniciManager = new KullaniciManager(context);
                return _kullaniciManager;
            }
        }

        public KategoriManager KategoriManager
        {
            get
            {
                if (_kategoriManager == null)
                    _kategoriManager = new KategoriManager(context);
                return _kategoriManager;
            }
        }
        public UrunManager UrunManager
        {
            get
            {
                if (_urunManager == null)
                    _urunManager = new UrunManager(context);
                return _urunManager;
            }
        }

        public SiparisManager SiparisManager
        {
            get
            {
                if (_siparisManager == null)
                    _siparisManager = new SiparisManager(context);
                return _siparisManager;
            }
        }

        public SiparisDetayManager SiparisDetayManager
        {
            get
            {
                if (_siparisDetayManager == null)
                    _siparisDetayManager = new SiparisDetayManager(context);
                return _siparisDetayManager;
            }
        }

        public UnitOfWork(string dbPath)
        {
            context = new DatabaseContext(dbPath);
        }
    }
}
