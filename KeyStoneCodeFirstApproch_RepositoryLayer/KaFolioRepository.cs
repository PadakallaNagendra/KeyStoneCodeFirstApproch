using KeyStoneCodeFirst_BusinessEntities.Entities;
using KeyStoneCodeFirst_BusinessEntities.InterFace;
using KeyStoneCodeFirst_BusinessEntities.KarvyMfsModel;
using KeyStoneCodeFirstApproch_DataBaseLogic.DBConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneCodeFirstApproch_RepositoryLayer
{
    public class KaFolioRepository : IKaFolioRepository
    {
        KarvyMfsContext _karvyMfsContex;
        public KaFolioRepository(KarvyMfsContext karvyMfsContext)
        {
            _karvyMfsContex = karvyMfsContext;
        }
        public bool AddKaFolioDetails(KaFolio kaFolio)
        {
            _karvyMfsContex.KaFolios.Add(kaFolio);
            return true;
        }

        public bool DeleteKaFolioDetails(int id)
        {
            KaFolio kaFolio = _karvyMfsContex.KaFolios.SingleOrDefault(f => f.Id == id);
            if (kaFolio != null)
            {
                _karvyMfsContex.KaFolios.Remove(kaFolio);
                _karvyMfsContex.SaveChanges();
                return true;
            }
            else return false;
        }

        public List<KaFolio> GetAllKaFolioDetails()
        {
            var kafolio = _karvyMfsContex.KaFolios.ToList();
            if (kafolio.Count == 0)
                return null;
            else return kafolio;
        }

        public List<KaFolio> GetKaFolioDetailsByID(int id)
        {
            List<KaFolio> kaFolios = _karvyMfsContex.KaFolios.ToList().FindAll(e => e.Id == id);
            if (kaFolios.Count == 0)
                return null;
            else
                return kaFolios;
        }

        public bool UpdateKaFolioDetails(KaFolio kaFolio)
        {
            _karvyMfsContex.KaFolios.Update(kaFolio);
            _karvyMfsContex.SaveChanges();
            return true;
        }
    }
}
