using OyunProjee.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjee.Model.Entities
{
    public class Oyun : OyunProjeEntity
    {
        public string OyunAdı { get; set; }
        public DateTime? KurulusTarihi { get; set; }
        public string Türü { get; set; }
        public decimal Fiyat { get; set; }
        


    }
}
