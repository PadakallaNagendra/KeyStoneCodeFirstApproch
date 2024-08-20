using KeyStoneCodeFirst_BusinessEntities.InterFace;
using KeyStoneCodeFirst_BusinessEntities.KarvyMfsModel;
using KeyStoneCodeFirst_BusinessEntities.ModelDTO;
using KeyStoneCodeFirstApproch_RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneCodeFirstApproch_ServiceLayer
{
    public class KaFolioService : IKaFolioService
    {
        IKaFolioRepository _kaFolioRepository;
        public KaFolioService(IKaFolioRepository kaFolioRepository)
        {
            _kaFolioRepository= kaFolioRepository;
        }
        public bool AddKaFolioDetails(KaFolioDTO kaFolioDTO)
        {
            KaFolio obj = new KaFolio();
            obj.Id = kaFolioDTO.Id;
             obj.FolioName = kaFolioDTO.FolioName;
            obj.FolioValue = kaFolioDTO.FolioValue;
            obj.FundBasedFolio = kaFolioDTO.FundBasedFolio;
            _kaFolioRepository.AddKaFolioDetails(obj);
            return true;
        }

        public bool DeleteKaFolioDetails(int id)
        {
            _kaFolioRepository.DeleteKaFolioDetails(id);
            return true;
        }

        public List<KaFolioDTO> GetAllKaFolioDetails()
        {
            List<KaFolioDTO> kaFolioDTOs = new List<KaFolioDTO>();

            List<KaFolio> kaFolios = _kaFolioRepository.GetAllKaFolioDetails();
            foreach (KaFolio kaFolio in kaFolios)
            {
                KaFolioDTO obj = new KaFolioDTO();
                obj.Id = kaFolio.Id;
                obj.FolioName = kaFolio.FolioName;
                obj.FolioValue = kaFolio.FolioValue;
                obj.FundBasedFolio = kaFolio.FundBasedFolio;
                _kaFolioRepository.AddKaFolioDetails(kaFolio);
            }
            return kaFolioDTOs;
        }

        public List<KaFolioDTO> GetKaFolioDetailsByID(int id)
        {
            List<KaFolioDTO> kaFolioDTOs = new List<KaFolioDTO>();

            List<KaFolio> kaFolios = _kaFolioRepository.GetAllKaFolioDetails();
            foreach (KaFolio kaFolio in kaFolios)
            {
                KaFolioDTO obj = new KaFolioDTO();
                obj.Id = kaFolio.Id;
                obj.FolioName = kaFolio.FolioName;
                obj.FolioValue = kaFolio.FolioValue;
                obj.FundBasedFolio = kaFolio.FundBasedFolio;
                kaFolioDTOs.Add(obj);
            }
            return kaFolioDTOs;

        }

        public bool UpdateKaFolioDetails(KaFolioDTO kaFolioDTO)
        {
            KaFolio obj = new KaFolio();
            obj.Id = kaFolioDTO.Id;
            obj.FolioName = kaFolioDTO.FolioName;
            obj.FolioValue = kaFolioDTO.FolioValue;
            obj.FundBasedFolio = kaFolioDTO.FundBasedFolio;
            _kaFolioRepository.UpdateKaFolioDetails(obj);
            return true;
        }
            
        
    }
}
