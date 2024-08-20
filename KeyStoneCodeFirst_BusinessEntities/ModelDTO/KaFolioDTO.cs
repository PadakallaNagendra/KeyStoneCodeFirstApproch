using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneCodeFirst_BusinessEntities.ModelDTO
{
    public class KaFolioDTO
    {
        public int Id { get; set; }
        public string? FolioName { get; set; }
        public string? FolioValue { get; set; }
        public int FundBasedFolio { get; set; }
    }
}
