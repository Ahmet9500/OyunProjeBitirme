using OyunProjee.Core.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjee.Model.Entities
{
    public class Karakter : OyunProjeEntity
    {
        public string OyunAdı { get; set; }
        public string OyuncuAdı { get; set; }
        public string OyuncuOzellikleri { get; set; }
        public int Gucu { get; set; }
        public int Vurus { get; set; }
        public int FızıkselOzellik { get; set; }
        public Oyun Oyun { get; set; }
        public int OyunId { get; set; }
    }
}
