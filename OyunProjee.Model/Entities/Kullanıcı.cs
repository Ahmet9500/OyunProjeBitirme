using OyunProjee.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjee.Model.Entities
{
    public class Kullanıcı: OyunProjeEntity
    {
        public string KullanıcıAdı{ get; set; }
        public string KullanıcıSoyadı { get; set; }
        public string EMail { get; set; }
        public string Sifre { get; set; }
        public int OyunId { get; set; }
        public Oyun Oyun { get; set; }
        public int KarakterId { get; set; }
        public Karakter Karakter { get; set; }
    }
}
