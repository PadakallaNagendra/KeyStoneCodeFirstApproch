using KeyStoneCodeFirst_BusinessEntities.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneCodeFirst_BusinessEntities.InterFace
{
    public interface IKaFolioService
    {
        List<KaFolioDTO> GetAllKaFolioDetails();
        List<KaFolioDTO> GetKaFolioDetailsByID(int id);
        bool AddKaFolioDetails(KaFolioDTO kaFolioDTO);
        bool UpdateKaFolioDetails(KaFolioDTO kaFolioDTO);
        bool DeleteKaFolioDetails(int id);
    }
}
