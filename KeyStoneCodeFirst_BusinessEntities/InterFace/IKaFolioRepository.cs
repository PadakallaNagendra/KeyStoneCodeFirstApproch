using KeyStoneCodeFirst_BusinessEntities.KarvyMfsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneCodeFirst_BusinessEntities.InterFace
{
    public interface IKaFolioRepository
    {
        List<KaFolio> GetAllKaFolioDetails();
        List<KaFolio> GetKaFolioDetailsByID(int id);
        bool AddKaFolioDetails(KaFolio kaFolio);
        bool UpdateKaFolioDetails(KaFolio kaFolio);
        bool DeleteKaFolioDetails(int id);
    }
}
